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
namespace Image_Preview
{
    public partial class UserControl1 : UserControl
    {

        
        public static string extensions = ".jpg|.png";              
        public static string saveThumbImages = @"C:\Newfolder";
        private ThumbNailSize _currentThumbSize = ThumbNailSize.Large;  
        private ContextMenu menu;
     
        public string CurrentFolderDirectory = null;
        public string[] LocalImagePaths = null;
        public string[] CurrentImagePaths = null;
        private bool onRating = false;

  
        public UserControl1()
        {

            InitializeComponent();
            
            // Load icons for thumbnail size
            //Image tinyIcon = Image.FromFile(@"C:\Users\mdsai\OneDrive\Desktop\IMG102\ImagePreview\Image Preview\Resources\tiny.png");
            //Image mediumIcon = Image.FromFile(@"C:\Users\mdsai\OneDrive\Desktop\IMG102\ImagePreview\Image Preview\Resources\medium.png");
            //Image largeIcon = Image.FromFile(@"C:\Users\mdsai\OneDrive\Desktop\IMG102\ImagePreview\Image Preview\Resources\large.png");

            // Create a new ContextMenuStrip and add view options
            ContextMenuStrip contextMenuStripView = new ContextMenuStrip();
            ContextMenuStrip contextMenuStripSort = new ContextMenuStrip();
            ToolStripMenuItem tinyMenuItem = new ToolStripMenuItem("Tiny", null, (sender, e) => ChangeThumbSize(ThumbNailSize.Tiny));
            ToolStripMenuItem mediumMenuItem = new ToolStripMenuItem("Medium", null, (sender, e) => ChangeThumbSize(ThumbNailSize.Medium));
            ToolStripMenuItem largeMenuItem = new ToolStripMenuItem("Large", null, (sender, e) => ChangeThumbSize(ThumbNailSize.Large));
            // Add the options to the context menu in view
            contextMenuStripView.Items.AddRange(new ToolStripMenuItem[] { tinyMenuItem, mediumMenuItem, largeMenuItem });

            // Create a new ContextMenuStrip and add Sorting options
           
           
            ToolStripMenuItem rating = new ToolStripMenuItem("Rating", null,  (sender, e) =>  ImageSortByRating());
            //ToolStripMenuItem twostar = new ToolStripMenuItem("2 Rating", null, async (sender, e) => await PopulateSortedByRating(FileDirectory, 2));
            //ToolStripMenuItem threestar = new ToolStripMenuItem("3 Rating", null, async (sender, e) => await PopulateSortedByRating(FileDirectory, 3));
            //ToolStripMenuItem fourstar = new ToolStripMenuItem("4 Rating", null, async (sender, e) => await PopulateSortedByRating(FileDirectory, 4));
            //ToolStripMenuItem fivestar = new ToolStripMenuItem("5 Rating", null, async (sender, e) => await PopulateSortedByRating(FileDirectory, 5));

            contextMenuStripSort.Items.AddRange(new ToolStripMenuItem[] { rating});
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
        private  void ChangeThumbSize(ThumbNailSize size)
        {
            _currentThumbSize = size;
           Reload();  // Reload the images with the new size
        }
        
        private async void ImageSortByRating()
        {

         
            if ( CurrentFolderDirectory != null)
            {
                await PopulateSortedByRating(CurrentFolderDirectory);
            }
            else if (CurrentImagePaths != null && CurrentImagePaths.Length != 0)
            {
                await PopulateSortedByRating(CurrentImagePaths);
            }
        }
        private async void Reload()
        {
            if (CurrentImagePaths != null && CurrentImagePaths.Length != 0 && !onRating)
            {
                await Populate(CurrentImagePaths);
            }
            if (CurrentFolderDirectory != null && onRating == false)
            {
                await Populate(CurrentFolderDirectory);
            }
            if (onRating == true && CurrentFolderDirectory != null)
            {
                await PopulateSortedByRating(CurrentFolderDirectory);
            }
            if (onRating == true && CurrentImagePaths != null && CurrentImagePaths.Length != 0 ){
                await PopulateSortedByRating(CurrentImagePaths);
            }
           

        }
        
        private async Task PopulateSortedByRating(string path)
        {
            flowLayoutPanel1.Controls.Clear();

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] files = directoryInfo.GetFiles();
            onRating = true;
            // Filter and sort files by rating in descending order
            var filteredFiles = files.Where(f =>
            {
                ShellFile shellFile = ShellFile.FromFilePath(f.FullName);
                int? rating = (int?)shellFile.Properties.System.Rating.Value;
                int stars = (rating.HasValue) ? rating.Value / 20 + 1 : 0;
                return stars >= 0;
            })
            .OrderByDescending(f =>
            {
                ShellFile shellFile = ShellFile.FromFilePath(f.FullName);
                int? rating = (int?)shellFile.Properties.System.Rating.Value;
                return (rating.HasValue) ? rating.Value : 0; 
            })
            .ThenBy(f => f.FullName) 
            .ToArray();

            foreach (var file in filteredFiles)
            {
                ShellFile shellFile = ShellFile.FromFilePath(file.FullName);
                int? rating = (int?)shellFile.Properties.System.Rating.Value;
                int stars = (rating.HasValue) ? rating.Value / 20 + 1 : 0;

                Button customBtn = new Button();
                Image thumbnail = await GetThumbnailAsync(file.FullName, _currentThumbSize);
                customBtn.BackgroundImage = thumbnail;
                customBtn.Size = new System.Drawing.Size((int)_currentThumbSize, (int)_currentThumbSize);
                customBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                customBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                customBtn.Click += (sender, e) => pickeditem(file.FullName, thumbnail, stars);
                flowLayoutPanel1.Controls.Add(customBtn);
            }

        }
        private async Task PopulateSortedByRating(string[] imagePaths)
        {
            flowLayoutPanel1.Controls.Clear();
            onRating = true;

            // Filter and sort files by rating in descending order
            var filteredFiles = imagePaths.Where(path =>
            {
                ShellFile shellFile = ShellFile.FromFilePath(path);
                int? rating = (int?)shellFile.Properties.System.Rating.Value;
                int stars = (rating.HasValue) ? rating.Value / 20 + 1 : 0;
                return stars >= 0;
            })
            .OrderByDescending(path =>
            {
                ShellFile shellFile = ShellFile.FromFilePath(path);
                int? rating = (int?)shellFile.Properties.System.Rating.Value;
                return (rating.HasValue) ? rating.Value : 0;
            })
            .ThenBy(path => path) // Secondary sorting by file name
            .ToArray();

            // Create buttons for each filtered image
            foreach (var imagePath in filteredFiles)
            {
                ShellFile shellFile = ShellFile.FromFilePath(imagePath);
                int? rating = (int?)shellFile.Properties.System.Rating.Value;
                int stars = (rating.HasValue) ? rating.Value / 20 + 1 : 0;

                Button customBtn = new Button();
                Image thumbnail = await GetThumbnailAsync(imagePath, _currentThumbSize);
                customBtn.BackgroundImage = thumbnail;
                customBtn.Size = new System.Drawing.Size((int)_currentThumbSize, (int)_currentThumbSize);
                customBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                customBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                customBtn.Click += (sender, e) => pickeditem(imagePath, thumbnail, stars);
                flowLayoutPanel1.Controls.Add(customBtn);
            }
        }






        public async Task Populate(string path)
        {
            flowLayoutPanel1.Controls.Clear();

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] files = directoryInfo.GetFiles();
            CurrentFolderDirectory = path;
            onRating = false;


            var sortedFiles = files.OrderBy(f => f.FullName).ToArray();
         

            string[] extsn = extensions.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var file in sortedFiles)
            {
                if (extsn.Any(ext => file.Extension.ToLower().Contains(ext.ToLower())))
                {
                    ShellFile shellFile = ShellFile.FromFilePath(file.FullName);
                    int? rating = (int?)shellFile.Properties.System.Rating.Value;
                    int stars = (rating.HasValue) ? rating.Value / 20 + 1 : 0;
                    Button customBtn = new Button();
                    Image thumbnail = await GetThumbnailAsync(file.FullName, _currentThumbSize);
                    customBtn.BackgroundImage = thumbnail;
                    customBtn.Size = new System.Drawing.Size((int)_currentThumbSize, (int)_currentThumbSize);
                    customBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    customBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    customBtn.Click += (sender, e) => pickeditem(file.FullName, thumbnail, stars); 
                    flowLayoutPanel1.Controls.Add(customBtn);
                }
            }
        }

        public event EventHandler Clicked;
        public string scriptCommand;
        public string CurrentItem;
        public Image CurrentImage;
        public string maxScriptCode;
        public event ThumbPickedEventHandler ThumbPicked; 

       

        public void pickeditem(string path, Image thumbnail,int star)
        {
            
                //IGlobal global = GlobalInterface.Instance;
                CurrentItem = path;
                CurrentImage = thumbnail;

                //scriptCommand = $"print \"{path}\"";
                //Autodesk.Max.MAXScript.ScriptSource source = Autodesk.Max.MAXScript.ScriptSource.Dynamic;
                //global.ExecuteMAXScriptScript(scriptCommand, source, true, null, true);

                ThumbPicked?.Invoke(this, new PickedEventArgs(path, thumbnail));

                //MessageBox.Show($"Star: {star} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }


        public async Task Populate(string[] imagePaths)
        {

             Array.Sort(imagePaths);

            this.flowLayoutPanel1.Controls.Clear();
            CurrentImagePaths = imagePaths;
            onRating = false;

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
                customBtn.Click += (sender, e) => pickeditem(imagePath, thumbnail,5);

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

        private async void button1_Click_3(object sender, EventArgs e)
        {

            string[] paths = { @"C:\Users\mdsai\OneDrive\Desktop\SirImages\WhatsApp Image 2024-10-06 at 21.50.07_0d27f5be - Copy (2).jpg", @"C:\Users\mdsai\OneDrive\Desktop\SirImages\WhatsApp Image 2024-10-06 at 21.50.07_0d27f5be - Copy.jpg", @"C:\Users\mdsai\OneDrive\Desktop\SirImages\WhatsApp Image 2024-10-06 at 21.50.07_0d27f5be.jpg", @"C:\Users\mdsai\OneDrive\Desktop\SirImages\WhatsApp Image 2024-10-06 at 21.50.07_4ae1d9d6 - Copy (2).jpg" };
            await Populate(@"C:\Users\mdsai\OneDrive\Desktop\SirImages");
            //await Populate(paths);
        }

        private void fiveStarClick(object sender, EventArgs e)
        {
            pb_star1.Image = Resources.yellow_star;
            pb_star2.Image = Resources.yellow_star;
            pb_star3.Image = Resources.yellow_star;
            pb_star4.Image = Resources.yellow_star;
            pb_star5.Image = Resources.yellow_star;
        }

        private void fourStarClick(object sender, EventArgs e)
        {
            pb_star1.Image = Resources.yellow_star;
            pb_star2.Image = Resources.yellow_star;
            pb_star3.Image = Resources.yellow_star;
            pb_star4.Image = Resources.yellow_star;
            pb_star5.Image = Resources.white_star;
        }

        private void threeStarClick(object sender, EventArgs e)
        {
            pb_star1.Image = Resources.yellow_star;
            pb_star2.Image = Resources.yellow_star;
            pb_star3.Image = Resources.yellow_star;
            pb_star4.Image = Resources.white_star;
            pb_star5.Image = Resources.white_star;
        }

        private void twoStarClick(object sender, EventArgs e)
        {
            pb_star1.Image = Resources.yellow_star;
            pb_star2.Image = Resources.yellow_star;
            pb_star3.Image = Resources.white_star;
            pb_star4.Image = Resources.white_star;
            pb_star5.Image = Resources.white_star;
        }

        private void oneStarClick(object sender, EventArgs e)
        {
            pb_star1.Image = Resources.yellow_star;
            pb_star2.Image = Resources.white_star;
            pb_star3.Image = Resources.white_star;
            pb_star4.Image = Resources.white_star;
            pb_star5.Image = Resources.white_star;

        }
    }
}
