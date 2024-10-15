using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Preview.Controls
{
    public partial class mybtn : UserControl
    {
        private ContextMenuStrip contextMenuStrip;

        public string btn_text = "";
        public FileInfo filepath = null;


        public mybtn()
        {
            InitializeComponent();
            InitializeContextMenu();
        }

        private void InitializeContextMenu()
        {
            contextMenuStrip = new ContextMenuStrip();

            ToolStripMenuItem item1 = new ToolStripMenuItem("Option 1", null, Item1_Click);
            ToolStripMenuItem item2 = new ToolStripMenuItem("Option 2", null, Item2_Click);
            ToolStripMenuItem item3 = new ToolStripMenuItem("Delete", null, (sender, e) => Item3_Click(filepath.FullName));
            ToolStripMenuItem item4 = new ToolStripMenuItem("All Image Delete and Clear Cache", null, (sender, e) => ClearCache());

            contextMenuStrip.Items.AddRange(new ToolStripItem[] { item1, item2, item3 });
            this.ContextMenuStrip = contextMenuStrip;
        }

    
        public void RefreshControl()
        {
            button1.Text = btn_text;
            LoadImages();
        }

  
        private void button1_Click(object sender, EventArgs e)
        {
            if (filepath != null)
            {
                Clipboard.SetText(filepath.FullName);
            }
        }


        public static Dictionary<string, Image> imageCache = new Dictionary<string, Image>();


        private async void LoadImages()
        {
            ToolTip toolTip = new ToolTip();

            try
            {
      
                if (!File.Exists(filepath.FullName))
                {
                    MessageBox.Show("Error: File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

       
                string[] validExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
                string extension = Path.GetExtension(filepath.FullName).ToLower();
                if (!validExtensions.Contains(extension))
                {
                  
                    return;
                }

               
                if (!imageCache.ContainsKey(filepath.FullName))
                {

                    await Task.Run(() => LoadAndCacheImage(filepath.FullName));
                }

                if (imageCache.ContainsKey(filepath.FullName))
                {
                    button1.BackgroundImage?.Dispose(); 
                    button1.BackgroundImage = imageCache[filepath.FullName];  // Use cached image
                    button1.Text = "";
                    toolTip.SetToolTip(button1, $"Filename: {filepath.Name}\nPath: {filepath.FullName}");
                }
            }
            catch (OutOfMemoryException)
            {
                button1.BackgroundImage = null;
                MessageBox.Show("Error: The image is too large to load.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                button1.BackgroundImage = null;
                MessageBox.Show("Error: Invalid image format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                button1.BackgroundImage = null;
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            button1.Click -= button3_Click;
            button1.Click += button3_Click;
        }

        private void LoadAndCacheImage(string imagePath)
        {
            try
            {
               
                using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    using (var img = Image.FromStream(stream, false, false))
                    {
                        
                        var thumbnail = img.GetThumbnailImage(175, 175, null, IntPtr.Zero);
                        var cachedImage = new Bitmap(thumbnail);

                        
                        lock (imageCache)
                        {
                            if (!imageCache.ContainsKey(imagePath))
                            {
                                imageCache[imagePath] = cachedImage;
                            }
                        }
                    }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Error: Invalid image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error caching image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (filepath != null)
            {
                ShowImageDetails(filepath.FullName);
            }
        }

       
        private void ShowImageDetails(string imagePath)
        {
            try
            {
                FileInfo imageFile = new FileInfo(imagePath);
                string fileSizeInKB = (imageFile.Length / 1024).ToString() + " KB";
                string creationDate = imageFile.CreationTime.ToString("g");

                string resolution = GetImageResolution(imageFile);

                string message = $"File: {imageFile.Name}\n" +
                                $"Size: {fileSizeInKB}\n" +
                                $"Resolution: {resolution}\n" +
                                $"Created On: {creationDate}";

                MessageBox.Show(message, "Image Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying image details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private string GetImageResolution(FileInfo imageFile)
        {
            if (imageFile.Extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase) ||
                imageFile.Extension.Equals(".png", StringComparison.OrdinalIgnoreCase) ||
                 imageFile.Extension.Equals(".jpeg", StringComparison.OrdinalIgnoreCase))
            {
                using (var image = Image.FromFile(imageFile.FullName))
                {
                    return $"{image.Width}x{image.Height}";
                }
            }
            return "Unknown";
        }

       
        private void Item1_Click(object sender, EventArgs e) => MessageBox.Show("Option 1 selected!");

  
        private void Item2_Click(object sender, EventArgs e) => MessageBox.Show("Option 2 selected!");

       
        private void Item3_Click(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);

                 
                    if (imageCache.ContainsKey(filePath))
                    {
                        imageCache.Remove(filePath);
                    }
                    UserControl1 userControl1 = new UserControl1();
                    userControl1.Reload();
                  
                    

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

   
        private void ReloadControl()
        {
           
    

        }

       
        public static void ClearCache()
        {
            foreach (var image in imageCache.Values)
            {
                image.Dispose(); 
            }
            MessageBox.Show("All image cache has been clear.....", "All Image Cache Clear", MessageBoxButtons.OK, MessageBoxIcon.Information);
            imageCache.Clear();


        }


    }
}
