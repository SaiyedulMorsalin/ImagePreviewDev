using Image_Preview.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Preview
{
    public partial class UserControl1 : UserControl
    {
        public static string Filepath = @"C:\Users\vn\Desktop"; 
        public static string extensions = ".jpg|.png";               
        public static string saveThumbImages = @"C:\Newfolder";
        // Constructor
        public UserControl1()
        {
            InitializeComponent();
        }
        public async Task Populate()
        {

        }
        public async Task DirectoryLoad(string path = null, string[] imagePaths = null)
        {
           
            if (imagePaths != null && imagePaths.Length > 0)
            {
                await LoadImagesFromArray(imagePaths);
            }
            else
            {
              
                if (string.IsNullOrEmpty(path) || !Directory.Exists(path))
                {
                    MessageBox.Show("Source directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            
                if (!Directory.Exists(Filepath))
                {
                    Directory.CreateDirectory(Filepath);
                }

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

                        // Asynchronously load the thumbnail
                        Image thumbnail = await GetThumbnailAsync(file.FullName);
                        btn.BackgroundImage = thumbnail;

                      
                        flowLayoutPanel1.Controls.Add(btn);
                    }
                }
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

 
        public  void Reload()
        {
            flowLayoutPanel1.Width = this.Width - 20;
            flowLayoutPanel1.Controls.Clear();

            if (Directory.Exists(Filepath))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(Filepath);
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
                        btn.RefreshControl();
                        flowLayoutPanel1.Controls.Add(btn);
                    }
                }
            }
            else
            {
                MessageBox.Show("Folder directory not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

       
       
        public async Task LoadImagesFromArray(string[] imagePaths)
        {
           
            DisposeImages();
            flowLayoutPanel1.Controls.Clear();

    

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


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

   
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            string[] imagepaths = { @"C:\Users\mdsai\OneDrive\Desktop\dll_prop.jpg", @"C:\Users\mdsai\OneDrive\Desktop\errors.jpg", @"C:\Users\mdsai\OneDrive\Desktop\pro_struc.png", @"C:\Users\mdsai\OneDrive\Desktop\nice_qoute.png" };
        }

        

    

        private void button1_Click_1(object sender, EventArgs e) => Reload();

        private async void button1_Click_2(object sender, EventArgs e)
        {
            string[] imagepaths = {
                @"C:\Users\mdsai\OneDrive\Desktop\dll_prop.jpg",
                @"C:\Users\mdsai\OneDrive\Desktop\errors.jpg",
                @"C:\Users\mdsai\OneDrive\Desktop\pro_struc.png",
                @"C:\Users\mdsai\OneDrive\Desktop\pro_struc.png",
                @"C:\Users\mdsai\OneDrive\Desktop\pro_struc.png",
                @"C:\Users\mdsai\OneDrive\Desktop\pro_struc.png",
                @"C:\Users\mdsai\OneDrive\Desktop\pro_struc.png",
                @"C:\Users\mdsai\OneDrive\Desktop\pro_struc.png",
                @"C:\Users\mdsai\OneDrive\Desktop\pro_struc.png",
                @"C:\Users\mdsai\OneDrive\Desktop\pro_struc.png",
                @"C:\Users\mdsai\OneDrive\Desktop\pro_struc.png",
                @"C:\Users\mdsai\OneDrive\Desktop\pro_struc.png",
                @"C:\Users\mdsai\OneDrive\Desktop\pro_struc.png",
                @"C:\Users\mdsai\OneDrive\Desktop\pro_struc.png",
                @"C:\Users\mdsai\OneDrive\Desktop\pro_struc.png",

            };

            await LoadImagesFromArray(imagepaths);
        }
        public async void ArrayofImagesList(string[] imagepaths)
        {
            
            await LoadImagesFromArray(imagepaths);
        }
    }
}
