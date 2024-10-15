using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Preview.Controls
{
    public partial class ImagePickedEventArgs : UserControl
    {
        public ImagePickedEventArgs()
        {
            InitializeComponent();
        }
        private Image _image;
        private string _fileName;
        private Point _MousePos;
        private MouseButtons _MouseButton;

        public Image Image
        {
            get => this._image;
            set => this._image = value;
        }
        public string FileName
        {
            get => this._fileName;
            set => this._fileName = value;
        }

        public Point Location
        {
            get => this._MousePos;
            set => this._MousePos = value;
        }

        public MouseButtons MouseButton
        {
            get => this._MouseButton;
            set => this._MouseButton = value;
        }
        public ImagePickedEventArgs(Image image, string fileName, UserControl1 control)
        {
            this.Image = image;
            this.FileName = fileName;
            control.CurrentItem = fileName;
        }
    }
}
