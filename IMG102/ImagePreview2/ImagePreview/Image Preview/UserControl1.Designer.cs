﻿using System.Drawing;
using System.Windows.Forms;

namespace Image_Preview
{
    partial class UserControl1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.pb_star1 = new System.Windows.Forms.PictureBox();
            this.pb_star2 = new System.Windows.Forms.PictureBox();
            this.pb_star3 = new System.Windows.Forms.PictureBox();
            this.pb_star4 = new System.Windows.Forms.PictureBox();
            this.pb_star5 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star5)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(680, 454);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.385049F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.61495F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.15625F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.84375F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(709, 552);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.04418F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.95582F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(26, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(679, 46);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.iconButton1);
            this.flowLayoutPanel2.Controls.Add(this.iconButton3);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(208, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(465, 34);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(93, 33);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "View";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.SortAmountAsc;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton3.Location = new System.Drawing.Point(102, 3);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(93, 33);
            this.iconButton3.TabIndex = 0;
            this.iconButton3.Text = "Sort";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel3.Controls.Add(this.iconButton2);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(196, 34);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Image_Preview.Properties.Resources.studio_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton2.Location = new System.Drawing.Point(73, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(114, 33);
            this.iconButton2.TabIndex = 0;
            this.iconButton2.Text = "Studio D\'xine";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.pb_star1);
            this.flowLayoutPanel4.Controls.Add(this.pb_star2);
            this.flowLayoutPanel4.Controls.Add(this.pb_star3);
            this.flowLayoutPanel4.Controls.Add(this.pb_star4);
            this.flowLayoutPanel4.Controls.Add(this.pb_star5);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(26, 515);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(200, 34);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // pb_star1
            // 
            this.pb_star1.Image = global::Image_Preview.Properties.Resources.white_star;
            this.pb_star1.Location = new System.Drawing.Point(3, 3);
            this.pb_star1.Name = "pb_star1";
            this.pb_star1.Size = new System.Drawing.Size(33, 31);
            this.pb_star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_star1.TabIndex = 0;
            this.pb_star1.TabStop = false;
            this.pb_star1.Click += new System.EventHandler(this.oneStarClick);
            // 
            // pb_star2
            // 
            this.pb_star2.Image = global::Image_Preview.Properties.Resources.white_star;
            this.pb_star2.Location = new System.Drawing.Point(42, 3);
            this.pb_star2.Name = "pb_star2";
            this.pb_star2.Size = new System.Drawing.Size(33, 31);
            this.pb_star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_star2.TabIndex = 1;
            this.pb_star2.TabStop = false;
            this.pb_star2.Click += new System.EventHandler(this.twoStarClick);
            // 
            // pb_star3
            // 
            this.pb_star3.Image = global::Image_Preview.Properties.Resources.white_star;
            this.pb_star3.Location = new System.Drawing.Point(81, 3);
            this.pb_star3.Name = "pb_star3";
            this.pb_star3.Size = new System.Drawing.Size(33, 31);
            this.pb_star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_star3.TabIndex = 2;
            this.pb_star3.TabStop = false;
            this.pb_star3.Click += new System.EventHandler(this.threeStarClick);
            // 
            // pb_star4
            // 
            this.pb_star4.Image = global::Image_Preview.Properties.Resources.white_star;
            this.pb_star4.Location = new System.Drawing.Point(120, 3);
            this.pb_star4.Name = "pb_star4";
            this.pb_star4.Size = new System.Drawing.Size(33, 31);
            this.pb_star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_star4.TabIndex = 3;
            this.pb_star4.TabStop = false;
            this.pb_star4.Click += new System.EventHandler(this.fourStarClick);
            // 
            // pb_star5
            // 
            this.pb_star5.Image = global::Image_Preview.Properties.Resources.white_star;
            this.pb_star5.Location = new System.Drawing.Point(159, 3);
            this.pb_star5.Name = "pb_star5";
            this.pb_star5.Size = new System.Drawing.Size(33, 31);
            this.pb_star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_star5.TabIndex = 4;
            this.pb_star5.TabStop = false;
            this.pb_star5.Click += new System.EventHandler(this.fiveStarClick);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(709, 552);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FlowLayoutPanel flowLayoutPanel3;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel4;
        private PictureBox pb_star1;
        private PictureBox pb_star2;
        private PictureBox pb_star3;
        private PictureBox pb_star4;
        private PictureBox pb_star5;
    }
}
