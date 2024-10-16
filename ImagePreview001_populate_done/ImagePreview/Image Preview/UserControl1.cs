using Image_Preview.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Max;
namespace Image_Preview
{
    public partial class UserControl1 : UserControl
    {
        public static string Filepath = @"C:\Users\vn\Desktop";  // Default path for saving images
        public static string extensions = ".jpg|.png";                // Supported file extensions
        public static string saveThumbImages = @"C:\Newfolder"; // for small thumb.....save directory
        // Constructor
        public UserControl1()
        {
            InitializeComponent();
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





        private void button1_Click_1(object sender, EventArgs e) { }
    }
}
