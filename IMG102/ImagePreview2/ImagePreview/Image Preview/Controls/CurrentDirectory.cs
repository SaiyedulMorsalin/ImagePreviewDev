using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Preview.Controls
{
    public class CurrentDirectory
    {
        public string _CurrentFolder { get; private set; }

        public CurrentDirectory(string CurrentFolder)
        {
            this._CurrentFolder = CurrentFolder;
            MessageBox.Show($"CurrentDirectory: {CurrentFolder}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}
