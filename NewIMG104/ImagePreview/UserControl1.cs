using System;
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
    public partial class UserControl1: UserControl
    {

        // public variables.....
        public static string Filepath = @"C:\Users\vn\Desktop";  // Default path for saving images
        public static string extensions = ".jpg|.png";                // Supported file extensions
        public static string saveThumbImages = @"C:\Newfolder"; // for small thumb.....save directory




        // private varialbes.........

        [AccessedThroughProperty("ToolStripMenuBar")]
        private ToolStrip _ToolStripMenuBar;
        private ToolStripDropDownButton _ToolStripFiletypes;
        [AccessedThroughProperty("ToolStripThumbsize")]
        private ToolStripDropDownButton _ToolStripThumbsize;
        [AccessedThroughProperty("TinyToolStripMenuItem")]
        private ToolStripMenuItem _TinyToolStripMenuItem;
        [AccessedThroughProperty("SmallToolStripMenuItem")]
        private ToolStripMenuItem _SmallToolStripMenuItem;
        [AccessedThroughProperty("MediumToolStripMenuItem")]
        private ToolStripMenuItem _MediumToolStripMenuItem;
        [AccessedThroughProperty("LargeToolStripMenuItem")]
        private ToolStripMenuItem _LargeToolStripMenuItem;
        [AccessedThroughProperty("ExtraLargeToolStripMenuItem")]
        private Size _Thumbsize;
        private ToolStripDropDownButton ToolStripThumbsize;
        private string _CurrentItem;





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
            
        }
        private async Task DirectoryLoad(string path)
        {



         
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

                    Button customebtn = new Button
                    {
                        BackgroundImage = thumbnail,
                        Size = new System.Drawing.Size(150, 150),
                        BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom,
                        FlatStyle = System.Windows.Forms.FlatStyle.Flat
                    };
                    flowLayoutPanel1.Controls.Add(customebtn);


                }
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

        private void thumb_size_tiny()
        {
           
            flowLayoutPanel1.Controls.Clear();

        }
        private void SetRating(int rating)
        {
            MessageBox.Show($"You selected {rating} star(s)!");
        }
        private void LoadImage(string filepath)
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
