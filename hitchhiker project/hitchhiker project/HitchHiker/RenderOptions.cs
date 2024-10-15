using System;
using System.Windows.Forms;

namespace LoneRobot.UI
{
    public class RenderOptions : Form
    {
        private RadioButton radioButtonSmall;
        private RadioButton radioButtonMedium;
        private RadioButton radioButtonLarge;

        public RenderOptions()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Add controls and layout here
            // Example:
            radioButtonSmall = new RadioButton
            {
                Text = "Small",
                Location = new System.Drawing.Point(10, 10)
            };

            radioButtonMedium = new RadioButton
            {
                Text = "Medium",
                Location = new System.Drawing.Point(10, 40)
            };

            radioButtonLarge = new RadioButton
            {
                Text = "Large",
                Location = new System.Drawing.Point(10, 70)
            };

            Controls.Add(radioButtonSmall);
            Controls.Add(radioButtonMedium);
            Controls.Add(radioButtonLarge);
        }

        [Obsolete("This method is obsolete. Use a different approach.")]
        private void SomeObsoleteMethod()
        {
            // Obsolete code here
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // RenderOptions
            // 
            this.ClientSize = new System.Drawing.Size(511, 363);
            this.Name = "RenderOptions";
            this.ResumeLayout(false);

        }
    }
}
