﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.IO;

namespace ImagePreview
{
    public partial class UserControl1 : UserControl
    {
        public static string Filepath = @"C:\Users\vn\Desktop";  // Default path for saving images
        public static string extensions = ".jpg|.png";                // Supported file extensions
        public static string saveThumbImages = @"C:\Newfolder"; // for small thumb.....save directory
        private UserControl1.ThumbNailSize _ThumbNails;
        private ContextMenu menu;
        public UserControl1()
        {

            InitializeComponent();

            Image tinyIcon = Image.FromFile(@"C:\Users\mdsai\OneDrive\Desktop\IMG102\ImagePreview\Image Preview\Resources\tiny.png");
            Image mediumIcon = Image.FromFile(@"C:\Users\mdsai\OneDrive\Desktop\IMG102\ImagePreview\Image Preview\Resources\medium.png");
            Image largeIcon = Image.FromFile(@"C:\Users\mdsai\OneDrive\Desktop\IMG102\ImagePreview\Image Preview\Resources\large.png");
            // Create a new ContextMenuStrip and add "Rating" options
            ContextMenuStrip contextMenuStripView = new ContextMenuStrip();
            ToolStripMenuItem oneStar = new ToolStripMenuItem("Tiny", tinyIcon, (sender, e) => thumb_size_tiny());
            ToolStripMenuItem twoStars = new ToolStripMenuItem("Medium", mediumIcon, (sender, e) => SetRating(2));
            ToolStripMenuItem threeStars = new ToolStripMenuItem("Large", largeIcon, (sender, e) => SetRating(3));
            ToolStripMenuItem large = new ToolStripMenuItem("Large", largeIcon, (sender, e) => Reload());
            contextMenuStripView.Items.AddRange(new ToolStripMenuItem[] { oneStar, twoStars, threeStars, large });
            //this.iconButton1.ContextMenuStrip = contextMenuStripView;


            //this.iconButton1.MouseDown += new MouseEventHandler(this.iconButton1_MouseDown);
        }


        private void iconButton1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {

                //this.iconButton1.ContextMenuStrip.Show(this.iconButton1, e.Location);
            }
        }
        private void thumb_size_tiny()
        {
            DisposeImages();
            flowLayoutPanel1.Controls.Clear();

        }
        private void SetRating(int rating)
        {
            MessageBox.Show($"You selected {rating} star(s)!");
        }

        private void Reload()
        {


        }

        public async Task Populate(string path = null, string[] imagePaths = null)
        {
            if (Directory.Exists(path) && !string.IsNullOrEmpty(path) && imagePaths != null && imagePaths.Length != 0)
            {

                await DirectoryLoad(path);
                MessageBox.Show($"Show All Images From Directory and Images Array List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                   
                    Button outbtn = new Button();



                    Image thumbnail = await GetThumbnailAsync(file.FullName);
                    outbtn.BackgroundImage = thumbnail;
                   
                    Button customebtn = new Button();
                    customebtn.BackgroundImage = thumbnail;
                    customebtn.Size = new System.Drawing.Size(150, 150);
                    customebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    customebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    //btn.RefreshControl();
                    flowLayoutPanel1.Controls.Add(customebtn);


                }
            }



        }
        public async Task LoadImagesFromArray(string[] imagePaths, bool all_true)
        {

            if (all_true)
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


                Image thumbnail = await GetThumbnailAsync(imagePath);


                
                //flowLayoutPanel1.Controls.Add(btn);



            }


        }



        public async Task<Image> GetThumbnailAsync(string imagePath, ThumbNailSize size = ThumbNailSize.Tiny)
        {

            int thumbSize = (int)size;

            return await Task.Run(() =>
            {
                using (var img = Image.FromFile(imagePath))
                {

                    return img.GetThumbnailImage(thumbSize, thumbSize, null, IntPtr.Zero);
                }
            });
        }


        private void DisposeImages()
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
               
            }
        }








        private static string GetImageResolution(FileInfo imageFile)
        {
            if (imageFile.Extension.ToLower() == ".jpg" || imageFile.Extension.ToLower() == ".png")
            {
                using (var image = Image.FromFile(imageFile.FullName))
                {
                    return $"{image.Width}x{image.Height}";
                }
            }
            return "Unknown";
        }


        public static void ClearImageCache()
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }




        public enum ThumbNailSize
        {
            Tiny = 50,
            Medium = 70,
            Large = 300,
        }
    }
}
