using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Max;

namespace Image_Preview.Controls
{
    public partial class mybtn : UserControl
    {
        private ContextMenuStrip contextMenuStrip;
        public string btn_text = "";
        public FileInfo filepath = null;
        private string _CurrentItem = null;
        private readonly string cacheDirectory = @"C:\ImageCache";

        public Button ourbtn2;
        public static string smallThumbImagesDirectory = @"C:\SmallThumb";

        public mybtn()
        {
            InitializeComponent();
            InitializeContextMenu();

            if (!Directory.Exists(cacheDirectory))
                Directory.CreateDirectory(cacheDirectory);

            if (!Directory.Exists(smallThumbImagesDirectory))
                Directory.CreateDirectory(smallThumbImagesDirectory);

            button1.Click += button3_Click;
            ourbtn2 = this.button1;
        }

        private void InitializeContextMenu()
        {
            contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.Items.AddRange(new ToolStripItem[]
            {
                new ToolStripMenuItem("Option 1", null, (sender, e) => MessageBox.Show("Option 1 selected!")),
                new ToolStripMenuItem("Option 2", null, (sender, e) => MessageBox.Show("Option 2 selected!")),
                new ToolStripMenuItem("Delete", null, (sender, e) => DeleteImage(filepath?.FullName)),
                new ToolStripMenuItem("Clear Cache", null, (sender, e) => ClearCache())
            });

            this.ContextMenuStrip = contextMenuStrip;
        }

        public void RefreshControl()
        {
            button1.Text = btn_text;
            LoadImages();
        }
        IGlobal maxGlobal = Autodesk.Max.GlobalInterface.Instance;
      
        private async void LoadImages()
        {
            try
            {
                if (filepath == null || !File.Exists(filepath.FullName))
                    throw new FileNotFoundException("File not found.");

                // Ensure valid image formats
                string[] validExtensions = { ".jpg", ".jpeg", ".png" };
                if (!validExtensions.Contains(Path.GetExtension(filepath.FullName).ToLower()))
                    return;

                // Load image and update button
                Image image = await GetImageFromCacheOrLoadAsync(filepath.FullName);
                button1.BackgroundImage?.Dispose();  // Dispose the old image
                button1.BackgroundImage = image;
                button1.Text = "";

                // Tooltip with image details
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

            using (Image image = Image.FromFile(imagePath))
            {
                var thumbnail = image.GetThumbnailImage(175, 175, null, IntPtr.Zero);
                string thumbPath = Path.Combine(smallThumbImagesDirectory, Path.GetFileNameWithoutExtension(imagePath) + "_thumbnail.jpg");

                thumbnail.Save(thumbPath, System.Drawing.Imaging.ImageFormat.Jpeg);

                // Cache the thumbnail
                await SaveImageToCache(imagePath, thumbnail);

                return thumbnail;
            }
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

        public string CurrentItem ="Studio design";
        private void button3_Click(object sender, EventArgs e)
        {
            if (filepath == null)
            {
                MessageBox.Show("Image Path Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IGlobal global = GlobalInterface.Instance;
                string scriptCommand = "print \"Hello from MAXScript!\"";
                Autodesk.Max.MAXScript.ScriptSource source = Autodesk.Max.MAXScript.ScriptSource.Dynamic;
                global.ExecuteMAXScriptScript(scriptCommand, source, true, null, true);
                return;
            }
            IGlobal global1 = GlobalInterface.Instance;
            
            Autodesk.Max.MAXScript.ScriptSource source1 = Autodesk.Max.MAXScript.ScriptSource.Dynamic;
            global1.ExecuteMAXScriptScript(filepath.FullName, source1, true, null, true);
            CurrentItem = filepath.FullName;
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

                string message = $"File: {imageFile.Name} {CurrentItem}\nSize: {fileSizeInKB}\nResolution: {resolution}\nCreated On: {creationDate}";
                MessageBox.Show(message, "Image Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying image details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetImageResolution(FileInfo imageFile)
        {
            using (Image image = Image.FromFile(imageFile.FullName))
            {
                return $"{image.Width}x{image.Height}";
            }
        }

        private void DeleteImage(string filePath)
        {
            try
            {
                if (filePath == null || !File.Exists(filePath))
                {
                    MessageBox.Show("File not found.");
                    return;
                }

                File.Delete(filePath);
                ReloadControl();
                MessageBox.Show($"{filePath} deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadControl()
        {
            this.Refresh();
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
