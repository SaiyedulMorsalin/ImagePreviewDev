using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Image_Preview.Controls
{
    public partial class mybtn : UserControl
    {
        private ContextMenuStrip contextMenuStrip;
        private static Dictionary<string, Image> imageCache = new Dictionary<string, Image>(); // Image cache

        public string btn_text = "";
        public FileInfo filepath = null;

        // Constructor
        public mybtn()
        {
            InitializeComponent();
            InitializeContextMenu();
        }

        // Initialize the context menu
        private void InitializeContextMenu()
        {
            contextMenuStrip = new ContextMenuStrip();

            ToolStripMenuItem item1 = new ToolStripMenuItem("Option 1", null, Item1_Click);
            ToolStripMenuItem item2 = new ToolStripMenuItem("Option 2", null, Item2_Click);
            ToolStripMenuItem item3 = new ToolStripMenuItem("Delete", null, (sender, e) => Item3_Click(filepath.FullName));

            contextMenuStrip.Items.AddRange(new ToolStripItem[] { item1, item2, item3 });
            this.ContextMenuStrip = contextMenuStrip;
        }

        // Refresh button text and load image
        public void RefreshControl()
        {
            button1.Text = btn_text;
            LoadImages();
        }

        // Handle button click to copy the file path to the clipboard
        private void button1_Click(object sender, EventArgs e)
        {
            if (filepath != null)
            {
                Clipboard.SetText(filepath.FullName);
            }
        }

        private static List<string> cacheOrder = new List<string>(); // Keeps track of cache order
        private const int maxCacheSize = 1000000; // Max number of images to keep in cache

        private async void LoadImages()
        {
            ToolTip toolTip = new ToolTip();

            try
            {
                // Load image and cache it if not already cached
                if (!imageCache.ContainsKey(filepath.FullName))
                {
                    await Task.Run(() =>
                    {
                        using (var img = Image.FromFile(filepath.FullName))
                        {
                            // Create a smaller bitmap to avoid out of memory issues
                            var resizedImage = new Bitmap(img, new Size(175, 175));
                            var thumbnail = resizedImage.GetThumbnailImage(175, 175, null, IntPtr.Zero);

                            // Add image to cache with cache management
                            AddImageToCache(filepath.FullName, new Bitmap(thumbnail));
                        }
                    });
                }

                // Set image from cache
                button1.BackgroundImage?.Dispose(); // Clear previous image to free up memory
                button1.BackgroundImage = imageCache[filepath.FullName];
                button1.Text = ""; // Clear text once the image is loaded
                toolTip.SetToolTip(button1, $"Filename: {filepath.Name}\nPath: {filepath.FullName}");
            }
            catch (OutOfMemoryException)
            {
                button1.BackgroundImage = null;
                MessageBox.Show("Error: The image is too large to load.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                button1.BackgroundImage = null;
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            button1.Click += button3_Click;
        }

        
        private static void AddImageToCache(string path, Image image)
        {
            // If cache size exceeds the max limit, remove the oldest cached image
            if (imageCache.Count >= maxCacheSize)
            {
                string oldestKey = cacheOrder[0];
                cacheOrder.RemoveAt(0); 
                imageCache[oldestKey].Dispose(); 
                imageCache.Remove(oldestKey); // Remove from dictionary
            }

           
            imageCache[path] = image;
            cacheOrder.Add(path); // Add to the end (most recently used)
        }



        // Show image details when button is clicked
        private void button3_Click(object sender, EventArgs e)
        {
            if (filepath != null)
            {
                ShowImageDetails(filepath.FullName);
            }
            else
            {
                MessageBox.Show("Error displaying image details:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Show image details in a MessageBox
        private void ShowImageDetails(string imagePath)
        {
            try
            {
                FileInfo imageFile = new FileInfo(imagePath);
                string fileSizeInKB = (imageFile.Length / 1024).ToString() + " KB";
                string creationDate = imageFile.CreationTime.ToString("g");
                string rating = "Not available"; // Default rating value
                string tags = "Not available";   // Default tags value
                string resolution = GetImageResolution(imageFile);

                // Read metadata
                var directories = ImageMetadataReader.ReadMetadata(imageFile.FullName);

                // Extract rating
                var ratingDirectory = directories.OfType<ExifIfd0Directory>().FirstOrDefault();
                if (ratingDirectory != null && ratingDirectory.ContainsTag(ExifDirectoryBase.TagRating))
                {
                    rating = ratingDirectory.GetDescription(ExifDirectoryBase.TagRating);
                }

                // Extract tags (User Comment)
                var tagDirectory = directories.OfType<ExifIfd0Directory>().FirstOrDefault();
                if (tagDirectory != null && tagDirectory.ContainsTag(ExifDirectoryBase.TagArtist))
                {
                    tags = tagDirectory.GetDescription(ExifDirectoryBase.TagArtist);
                }

                string message = $"File: {imageFile.Name}\n" +
                                 $"Size: {fileSizeInKB}\n" +
                                 $"Resolution: {resolution}\n" +
                                 $"Created On: {creationDate}\n" +
                                 $"Rating: {rating}\n" +
                                 $"Tags: {tags}";

                MessageBox.Show(message, "Image Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying image details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Get image resolution
        private string GetImageResolution(FileInfo imageFile)
        {
            if (imageFile.Extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase) ||
                imageFile.Extension.Equals(".png", StringComparison.OrdinalIgnoreCase))
            {
                using (var image = Image.FromFile(imageFile.FullName))
                {
                    return $"{image.Width}x{image.Height} Image Tags {image.Tag} {image.PropertyIdList}";
                }
            }
            return "Unknown";
        }
        private static (string Resolution, string Rating, string Tags) GetImageDetails(FileInfo imageFile)
        {
            string resolution = "Unknown";
            string rating = "Not available";
            string tags = "Not available";

            try
            {
                // Get image resolution
                using (var image = Image.FromFile(imageFile.FullName))
                {
                    resolution = $"{image.Width}x{image.Height}";
                }

                // Read metadata
                var directories = ImageMetadataReader.ReadMetadata(imageFile.FullName);

                // Extract rating
                var ratingDirectory = directories.OfType<ExifIfd0Directory>().FirstOrDefault();
                if (ratingDirectory != null && ratingDirectory.ContainsTag(ExifDirectoryBase.TagRating))
                {
                    rating = ratingDirectory.GetDescription(ExifDirectoryBase.TagRating);
                }

                // Extract tags (User Comment)
                var tagDirectory = directories.OfType<ExifIfd0Directory>().FirstOrDefault();
                if (tagDirectory != null && tagDirectory.ContainsTag(ExifDirectoryBase.TagUserComment))
                {
                    tags = tagDirectory.GetDescription(ExifDirectoryBase.TagUserComment);
                }
            }
            catch (Exception ex)
            {
                // Log or handle exceptions if needed
                Console.WriteLine($"Error retrieving image details: {ex.Message}");
            }

            return (resolution, rating, tags);
        }


        // Option 1 selected event
        private void Item1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Option 1 selected!");
        }

        // Option 2 selected event
        private void Item2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Option 2 selected!");
        }

        // Delete the file and reload the panel
        private void Item3_Click(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);

                    // Remove the image from cache
                    if (imageCache.ContainsKey(filePath))
                    {
                        imageCache.Remove(filePath);
                    }

                    // Reload the control to reflect the deletion
                    ReloadControl();

                    MessageBox.Show($"{filePath} deleted successfully.");
                }
                else
                {
                    MessageBox.Show("File not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Reload the control (you should adjust how Reload works as per your application needs)
        private void ReloadControl()
        {
            // You would implement the actual reload logic here
            UserControl1 instance = new UserControl1();
            instance.Reload();
        }

        // Clear the image cache and free memory
        public void ClearCache()
        {
            

            MessageBox.Show("All image cache has been cleared successfully.", "Cache Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var image in imageCache.Values)
            {
                image.Dispose(); // Dispose images to release resources
            }

            imageCache.Clear(); // Clear the dictionary
            MessageBox.Show($"All image cache has been cleared successfully.{imageCache}", "Cache Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
