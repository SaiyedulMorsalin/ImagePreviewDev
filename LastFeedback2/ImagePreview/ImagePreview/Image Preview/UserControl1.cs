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
        public static string Filepath = @"C:\Users\vn\Desktop";  // Default path for saving images
        public static string Extensions = ".jpg|.png";            // Supported file extensions

        // Constructor
        public UserControl1()
        {
            InitializeComponent();
        }

        
        public async Task CopyFileAsync(string sourceFile, string destinationFile)
        {
            const int bufferSize = 10*1024 * 1024;  // Buffer size for file copy

            try
            {
                using (FileStream sourceStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize, useAsync: true))
                using (FileStream destinationStream = new FileStream(destinationFile, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize, useAsync: true))
                {
                    await sourceStream.CopyToAsync(destinationStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error copying file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        public async Task DirectoryLoad(string path)
        {
            if (!Directory.Exists(path))
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
            string[] extensions = Extensions.Split('|', (char)StringSplitOptions.RemoveEmptyEntries);

            List<Task> copyTasks = new List<Task>();

            foreach (var file in files)
            {
                if (extensions.Any(ext => file.Extension.ToLower().Contains(ext.ToLower())))
                {
                
                    Controls.mybtn btn = new Controls.mybtn
                    {
                        btn_text = file.Name,
                        filepath = file
                    };

                    
                    Image thumbnail = await GetThumbnailAsync(file.FullName);
                    btn.BackgroundImage = thumbnail;

                    flowLayoutPanel1.Controls.Add(btn);

                    string destinationFile = Path.Combine(Filepath, file.Name);
                    if (!File.Exists(destinationFile))
                    {
                        copyTasks.Add(CopyFileAsync(file.FullName, destinationFile));  
                    }
                }
            }

            await Task.WhenAll(copyTasks);  
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
                string[] extensions = Extensions.Split('|', (char)StringSplitOptions.RemoveEmptyEntries);

                foreach (var file in files)
                {
                    if (extensions.Any(ext => file.Extension.ToLower().Contains(ext.ToLower())))
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

      
        public static void ShowImageDetails(string imagePath)
        {
            try
            {
                FileInfo imageFile = new FileInfo(imagePath);
                string fileSizeInKB = (imageFile.Length / 1024).ToString() + " KB";
                string creationDate = imageFile.CreationTime.ToString("g");

                string resolution = GetImageResolution(imageFile);

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

        

    

        private void button1_Click_1(object sender, EventArgs e) => Reload();
    }
}
