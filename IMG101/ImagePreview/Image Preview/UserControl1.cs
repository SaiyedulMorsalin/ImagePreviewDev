using Image_Preview.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Max;
using Image_Preview;
//using Autodesk.MaxScript;
using System.Runtime.InteropServices;

namespace Image_Preview
{
    public partial class UserControl1 : UserControl
    {
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
        private UserControl1.ThumbNailSize _ThumbNails;
        private Size _Thumbsize;
        private ToolStripDropDownButton ToolStripThumbsize;
        private string _CurrentItem;


        // Public Properties
        public static string extensions = ".jpg|.png";                // Supported file extensions
        public static string saveThumbImages = @"C:\Newfolder"; // for small thumb.....save directory
    
        public string CurrentMapFolder => new FileInfo(this.CurrentItem).DirectoryName;



        // Constructor
        public UserControl1()
        {
            InitializeComponent();
            this.ToolStripThumbsize = new ToolStripDropDownButton();
            this._Thumbsize = new Size(70, 70);


        }
        public string CurrentItem
        {
            get => this._CurrentItem;
            set => this._CurrentItem = value;
        }


        public async Task Populate(string path =null,string[] imagePaths =null)
        {
            if (Directory.Exists(path) && !string.IsNullOrEmpty(path) && imagePaths != null && imagePaths.Length != 0)
            {
               
                await DirectoryLoad(path);
                MessageBox.Show($"Show All Images From Directory and Images Array List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadImagesFromArray(imagePaths,false);

            }
            
            else if (imagePaths != null && imagePaths.Length != 0)
            {
               
                await LoadImagesFromArray(imagePaths, true);
            }
            else if(Directory.Exists(path) && !string.IsNullOrEmpty(path)){
                await DirectoryLoad(path);
            }



        }
 

        public Size Thumbsize
        {
            get { return _Thumbsize; }
            set
            {
                if (value.Height < 22)
                    value.Height = 22;
                if (value.Width < 22)
                    value.Width = 22;
                _Thumbsize = value;
                UpdateDisplay();
            }
        }

        private void UpdateDisplay()
        {
            // Update the thumbnail size in your flowLayoutPanel1
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Controls.mybtn mybtnControl)
                {
                    Image thumbnail = GetThumbnailAsync(mybtnControl.filepath.FullName, Thumbsize.Width, Thumbsize.Height).Result;
                    mybtnControl.BackgroundImage = thumbnail;
                    mybtnControl.RefreshControl();
                }
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
                
                    Controls.mybtn btn = new Controls.mybtn
                    {
                        btn_text = file.Name,
                        filepath = file
                    };

                    
                    Image thumbnail = await GetThumbnailAsync(file.FullName);
                    btn.BackgroundImage = thumbnail;
                    btn.RefreshControl();
                    flowLayoutPanel1.Controls.Add(btn);

                   
                }
            }
            

          
        }
        public async Task LoadImagesFromArray(string[] imagePaths,bool all_true)
        {

            if (all_true) {
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


                Controls.mybtn btn = new Controls.mybtn
                {
                    btn_text = Path.GetFileName(imagePath),
                    filepath = new FileInfo(imagePath),
                    BackgroundImage = thumbnail

                };


                btn.RefreshControl();
                flowLayoutPanel1.Controls.Add(btn);



            }


        }



        private async Task<Image> GetThumbnailAsync(string imagePath, int width = 175, int height = 175) => await Task.Run(() =>
        {
            using (var img = Image.FromFile(imagePath))
            {
                return img.GetThumbnailImage(width, height, null, IntPtr.Zero);
            }
        });


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

     
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

   
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }


        public enum ThumbNailSize
        {
            Tiny = 24, // 0x00000018
            Small = 50, // 0x00000032
            Medium = 70, // 0x00000046
            Large = 90, // 0x0000005A
            ExtraLarge = 150, // 0x00000096
        }



        private void button1_Click_1(object sender, EventArgs e) { }
    }
}
