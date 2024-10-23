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
using System.Windows.Shapes;
using Autodesk.Max;
using CSharpUtilities;
using MaxCustomControls;
using System.Globalization;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using Image_Preview.Properties;
using Path = System.IO.Path;
namespace Image_Preview
{
    public partial class UserControl1 : UserControl
    {


        public static string extensions = ".jpg|.png";
        public static string saveThumbImages = @"C:\Newfolder";
        private ThumbNailSize _currentThumbSize = ThumbNailSize.Large;
        private ContextMenu menu;

        public string CurrentFolderDirectory = null;
        public string[] CurrentImagePaths = null;
    


        public UserControl1()
        {

            InitializeComponent();

            ContextMenuStrip contextMenuStripView = new ContextMenuStrip();
            ContextMenuStrip contextMenuStripSort = new ContextMenuStrip();
           
            
            ToolStripMenuItem tinyMenuItem = new ToolStripMenuItem("Tiny", Resources.tiny, (sender, e) => ChangeThumbSize(ThumbNailSize.Tiny));
            ToolStripMenuItem mediumMenuItem = new ToolStripMenuItem("Medium", Resources.meduim, (sender, e) => ChangeThumbSize(ThumbNailSize.Medium));
            ToolStripMenuItem largeMenuItem = new ToolStripMenuItem("Large", Resources.large, (sender, e) => ChangeThumbSize(ThumbNailSize.Large));
         
            contextMenuStripView.Items.AddRange(new ToolStripMenuItem[] { tinyMenuItem, mediumMenuItem, largeMenuItem });

           
            this.iconButton1.ContextMenuStrip = contextMenuStripView;
            this.iconButton3.ContextMenuStrip = contextMenuStripSort;


            this.iconButton1.MouseDown += new MouseEventHandler(this.iconButton1_MouseDown);
            this.iconButton3.MouseDown += new MouseEventHandler(this.iconButton2_MouseDown);
        }

        public delegate void ThumbPickedEventHandler(object sender, PickedEventArgs e);
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
            Reload();  
        }

        private async void ImageSortByRating()
        {


            //if (CurrentFolderDirectory != null)
            //{
            //    await PopulateSortedByRating(CurrentFolderDirectory);
            //}
            //else if (CurrentImagePaths != null && CurrentImagePaths.Length != 0)
            //{
            //    await PopulateSortedByRating(CurrentImagePaths);
            //}
        }
        private async void Reload()
        {
            if (CurrentImagePaths != null && CurrentImagePaths.Length != 0 )
            {
                await Populate(CurrentImagePaths);
            }
            if (CurrentFolderDirectory != null )
            {
                await Populate(CurrentFolderDirectory);
            }
            


        }

      






        public async Task Populate(string path)
        {
            flowLayoutPanel1.Controls.Clear();

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] files = directoryInfo.GetFiles();
            CurrentFolderDirectory = path;
            CurrentImagePaths = null;


            var sortedFiles = files.OrderBy(f => f.FullName).ToArray();


            string[] extsn = extensions.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var file in sortedFiles)
            {
                if (extsn.Any(ext => file.Extension.ToLower().Contains(ext.ToLower())))
                {
                    
                    Button customBtn = new Button();
                    Image thumbnail = await GetThumbnailAsync(file.FullName, _currentThumbSize);
                    customBtn.BackgroundImage = thumbnail;
                    customBtn.Size = new System.Drawing.Size((int)_currentThumbSize, (int)_currentThumbSize);
                    customBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    customBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    customBtn.Click += (sender, e) => pickeditem(file.FullName, thumbnail);
                    flowLayoutPanel1.Controls.Add(customBtn);
                }
            }
        }
        public async Task Populate(string[] imagePaths)
        {

            Array.Sort(imagePaths);

            this.flowLayoutPanel1.Controls.Clear();
            CurrentImagePaths = imagePaths;
            CurrentFolderDirectory = null;
            

            foreach (var imagePath in imagePaths)
            {
                if (!File.Exists(imagePath))
                {

                    continue;
                }

                string[] extsn = extensions.Split('|', (char)StringSplitOptions.RemoveEmptyEntries);
                if (!extsn.Any(ext => imagePath.ToLower().EndsWith(ext.ToLower())))
                {

                    continue;
                }

                Button customBtn = new Button();
                Image thumbnail = await GetThumbnailAsync(imagePath, _currentThumbSize);
                customBtn.BackgroundImage = thumbnail;
                customBtn.Size = new System.Drawing.Size((int)_currentThumbSize, (int)_currentThumbSize);
                customBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                customBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                customBtn.Click += (sender, e) => pickeditem(imagePath, thumbnail);

                flowLayoutPanel1.Controls.Add(customBtn);
            }
        }


        public event EventHandler Clicked;
        public string scriptCommand;
        public string CurrentItem;
        public Image CurrentImage;
        public string maxScriptCode;
        public event ThumbPickedEventHandler ThumbPicked;
        public void pickeditem(string path, Image thumbnail)
        {

            CurrentItem = path;
            CurrentImage = thumbnail;
            ThumbPicked?.Invoke(this, new PickedEventArgs(path, thumbnail));

          

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
                    var thumbnail = img.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);
                    img.Dispose();

                    return thumbnail;
                }
            });
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