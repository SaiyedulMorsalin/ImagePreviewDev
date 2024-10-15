using Image_Preview.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Preview
{
    public partial class UserControl1 : UserControl
    {
        public static string Filepath = @"C:\Users\vn\Desktop";  // Default path for saving images
        public string[] LocalImagePaths;
        public static string extensions = ".jpg|.png";                // Supported file extensions
        public static string saveThumbImages = @"C:\Newfolder"; // for small thumb.....save directory
        private ThumbNailSize _currentThumbSize = ThumbNailSize.Large;  // Default size
        private ContextMenu menu;
        public UserControl1()
        {

            InitializeComponent();

            // Load icons for thumbnail size
            Image tinyIcon = Image.FromFile(@"C:\Users\mdsai\OneDrive\Desktop\IMG102\ImagePreview\Image Preview\Resources\tiny.png");
            Image mediumIcon = Image.FromFile(@"C:\Users\mdsai\OneDrive\Desktop\IMG102\ImagePreview\Image Preview\Resources\medium.png");
            Image largeIcon = Image.FromFile(@"C:\Users\mdsai\OneDrive\Desktop\IMG102\ImagePreview\Image Preview\Resources\large.png");

            // Create a new ContextMenuStrip and add view options
            ContextMenuStrip contextMenuStripView = new ContextMenuStrip();
            ContextMenuStrip contextMenuStripSort = new ContextMenuStrip();
            ToolStripMenuItem tinyMenuItem = new ToolStripMenuItem("Tiny", tinyIcon, (sender, e) => ChangeThumbSize(ThumbNailSize.Tiny));
            ToolStripMenuItem mediumMenuItem = new ToolStripMenuItem("Medium", mediumIcon, (sender, e) => ChangeThumbSize(ThumbNailSize.Medium));
            ToolStripMenuItem largeMenuItem = new ToolStripMenuItem("Large", largeIcon, (sender, e) => ChangeThumbSize(ThumbNailSize.Large));
            // Add the options to the context menu in view
            contextMenuStripView.Items.AddRange(new ToolStripMenuItem[] { tinyMenuItem, mediumMenuItem, largeMenuItem });

            // Create a new ContextMenuStrip and add Sorting options
            ToolStripMenuItem onestar = new ToolStripMenuItem("1 Rating", tinyIcon, (sender, e) => ChangeThumbSize(ThumbNailSize.Tiny));
            ToolStripMenuItem twostar = new ToolStripMenuItem("2 Rating", mediumIcon, (sender, e) => ChangeThumbSize(ThumbNailSize.Medium));
            ToolStripMenuItem threestar = new ToolStripMenuItem("3 Rating", largeIcon, (sender, e) => ChangeThumbSize(ThumbNailSize.Large));
            ToolStripMenuItem fourstar = new ToolStripMenuItem("4 Rating", tinyIcon, (sender, e) => ChangeThumbSize(ThumbNailSize.Tiny));
            ToolStripMenuItem fivestar = new ToolStripMenuItem("5 Rating", mediumIcon, (sender, e) => ChangeThumbSize(ThumbNailSize.Medium));
            contextMenuStripSort.Items.AddRange(new ToolStripMenuItem[] {fivestar,fourstar,threestar,twostar,onestar});

            this.iconButton1.ContextMenuStrip = contextMenuStripView;
            this.iconButton3.ContextMenuStrip = contextMenuStripSort;


            this.iconButton1.MouseDown += new MouseEventHandler(this.iconButton1_MouseDown);
            this.iconButton3.MouseDown += new MouseEventHandler(this.iconButton2_MouseDown);
        }
       
       
        private void iconButton1_MouseDown(object sender, MouseEventArgs e)
        {
          
            if (e.Button == MouseButtons.Left)
            {
               
                this.iconButton1.ContextMenuStrip.Show(this.iconButton1, e.Location);
            }
        }
        private void iconButton2_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {

                this.iconButton3.ContextMenuStrip.Show(this.iconButton3, e.Location);
            }
        }
        private void ChangeThumbSize(ThumbNailSize size)
        {
            _currentThumbSize = size;
            Reload();  // Reload the images with the new size
        }

        private async void Reload()
        {
           
            
            await Populate(Filepath, LocalImagePaths);  
        }



        public async Task Populate(string path = null, string[] imagePaths = null)
        {

            Filepath = path;
            LocalImagePaths = imagePaths;
            if (Directory.Exists(path) && !string.IsNullOrEmpty(path) && imagePaths != null && imagePaths.Length != 0)
            {
                await DirectoryLoad(path);
                MessageBox.Show($"Showing all images from directory and array list.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadImagesFromArray(imagePaths, false);
            }
            else if (imagePaths != null && imagePaths.Length != 0)
            {
                await LoadImagesFromArray(imagePaths, true);
            }
            else if (Directory.Exists(path) && !string.IsNullOrEmpty(path))
            {
                await DirectoryLoad(path);
            }
        }


        private async Task DirectoryLoad(string path)
        {
            DisposeImages();
            flowLayoutPanel1.Controls.Clear();

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] files = directoryInfo.GetFiles();
            string[] extsn = extensions.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var file in files)
            {
                if (extsn.Any(ext => file.Extension.ToLower().Contains(ext.ToLower())))
                {
                   

                    Button customBtn = new Button();
                    Image thumbnail = await GetThumbnailAsync(file.FullName, _currentThumbSize);
                    customBtn.BackgroundImage = thumbnail;
                    customBtn.Size = new System.Drawing.Size((int)_currentThumbSize, (int)_currentThumbSize);
                    customBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    customBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    flowLayoutPanel1.Controls.Add(customBtn);
                }
            }
        }

        public async Task LoadImagesFromArray(string[] imagePaths, bool clearControls)
        {
            if (clearControls)
            {
                DisposeImages();
                flowLayoutPanel1.Controls.Clear();
            }

            foreach (var imagePath in imagePaths)
            {
                if (!File.Exists(imagePath))
                {
                    MessageBox.Show($"File '{imagePath}' does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                string[] extsn = extensions.Split('|', (char)StringSplitOptions.RemoveEmptyEntries);
                if (!extsn.Any(ext => imagePath.ToLower().EndsWith(ext.ToLower())))
                {
                    MessageBox.Show($"Unsupported file type for '{imagePath}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                Image thumbnail = await GetThumbnailAsync(imagePath, _currentThumbSize);
                Button customBtn = new Button();
                customBtn.BackgroundImage = thumbnail;
                customBtn.Size = new System.Drawing.Size((int)_currentThumbSize, (int)_currentThumbSize);
                customBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                customBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                flowLayoutPanel1.Controls.Add(customBtn);
            }
        }

        public async Task<Image> GetThumbnailAsync(string imagePath, ThumbNailSize size)
        {
            int targetThumbSize = (int)size; 

            return await Task.Run(() =>
            {
                using (var img = Image.FromFile(imagePath))
                {
                 
                    int originalWidth = img.Width;
                    int originalHeight = img.Height;

               
                    double scalingFactor = Math.Min((double)targetThumbSize / originalWidth, (double)targetThumbSize / originalHeight);

                   
                    int newWidth = (int)(originalWidth * scalingFactor);
                    int newHeight = (int)(originalHeight * scalingFactor);

                 
                    return img.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);
                }
            });
        }

        private void DisposeImages()
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Controls.mybtn mybtnControl && mybtnControl.BackgroundImage != null)
                {
                    mybtnControl.BackgroundImage.Dispose();
                }
            }
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

   
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }





        private void button1_Click_1(object sender, EventArgs e) { }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }
        public enum ThumbNailSize
        {
            Tiny = 70, 
            Medium = 100, 
            Large = 175, 
        }
    }
}
