using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Preview.Controls
{
    public partial class mybtn : UserControl
    {
        private ContextMenuStrip contextMenuStrip;
        public string btn_text = "";
        public FileInfo filepath = null;

        private readonly string cacheDirectory = @"C:\ImageCache";
        

        public mybtn()
        {
            InitializeComponent();
            InitializeContextMenu();
            if (!Directory.Exists(cacheDirectory))
                Directory.CreateDirectory(cacheDirectory);
        }

        private void InitializeContextMenu()
        {
            contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.Items.AddRange(new ToolStripItem[]
            {
                new ToolStripMenuItem("Option 1", null, (sender, e) => MessageBox.Show("Option 1 selected!")),
                new ToolStripMenuItem("Option 2", null, (sender, e) => MessageBox.Show("Option 2 selected!")),
                new ToolStripMenuItem("Delete", null, (sender, e) => DeleteImage(filepath.FullName)),
                new ToolStripMenuItem("Clear Cache", null, (sender, e) => ClearCache())
            });

            this.ContextMenuStrip = contextMenuStrip;
        }

        public void RefreshControl()
        {
            button1.Text = btn_text;
            LoadImages();
        }

        private async void LoadImages()
        {
            try
            {
                if (!File.Exists(filepath.FullName))
                    throw new FileNotFoundException("Error: File not found.");

                string[] validExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
                if (!validExtensions.Contains(Path.GetExtension(filepath.FullName).ToLower()))
                    return;

                // Load from cache or generate a thumbnail
                Image image = await GetImageFromCacheOrLoadAsync(filepath.FullName);
                button1.BackgroundImage?.Dispose();
                button1.BackgroundImage = image;
                button1.Text = "";
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(button1, $"Filename: {filepath.Name}\nPath: {filepath.FullName}");
            }
            catch (Exception ex)
            {
                button1.BackgroundImage = null;
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task<Image> GetImageFromCacheOrLoadAsync(string imagePath)
        {
            Image cachedImage = await LoadImageFromCache(imagePath);
            if (cachedImage != null)
                return cachedImage;

            Image image = Image.FromFile(imagePath);
            var thumbnail = image.GetThumbnailImage(175, 175, null, IntPtr.Zero);
            await SaveImageToCache(imagePath, thumbnail);
            return thumbnail;
        }

        public async Task SaveImageToCache(string filePath, Image image)
        {
            string cachePath = GetCacheFilePath(filePath);
            await Task.Run(() =>
            {
                using (FileStream fs = new FileStream(cachePath, FileMode.Create, FileAccess.Write))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, image);
                }
            });
        }

        public async Task<Image> LoadImageFromCache(string filePath)
        {
            string cachePath = GetCacheFilePath(filePath);
            if (!File.Exists(cachePath))
                return null;

            return await Task.Run(() =>
            {
                using (FileStream fs = new FileStream(cachePath, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (Image)formatter.Deserialize(fs);
                }
            });
        }

        private string GetCacheFilePath(string originalFilePath)
        {
            string fileName = Path.GetFileNameWithoutExtension(originalFilePath);
            return Path.Combine(cacheDirectory, fileName + ".imgcache");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (filepath != null)
                Clipboard.SetText(filepath.FullName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (filepath != null)
                ShowImageDetails(filepath.FullName);
        }

        private void ShowImageDetails(string imagePath)
        {
            try
            {
                FileInfo imageFile = new FileInfo(imagePath);
                string fileSizeInKB = (imageFile.Length / 1024).ToString() + " KB";
                string resolution = GetImageResolution(imageFile);
                string creationDate = imageFile.CreationTime.ToString("g");

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
            using (var image = Image.FromFile(imageFile.FullName))
            {
                return $"{image.Width}x{image.Height}";
            }
        }

        private void DeleteImage(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);

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

        private void ReloadControl()
        {
            // Reload your control here (if applicable)
            // e.g., this.Invalidate() or this.Refresh();
        }

        public void ClearCache()
        {
            foreach (var cacheFile in Directory.GetFiles(cacheDirectory, "*.imgcache"))
            {
                File.Delete(cacheFile);
            }

          
            MessageBox.Show("All image cache has been cleared.", "Cache Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
