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

namespace ImagePreview
{
    public partial class UserControl1: UserControl
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
        private Size _Thumbsize;
        private ToolStripDropDownButton ToolStripThumbsize;
        private string _CurrentItem;

        public UserControl1()
        {
            InitializeComponent();
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
    }
}
