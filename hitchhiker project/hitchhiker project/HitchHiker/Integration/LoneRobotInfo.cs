// Decompiled with JetBrains decompiler
// Type: LoneRobot.UI.Integration.LoneRobotInfo
// Assembly: HitchHiker, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0532B763-C6E8-474A-A94B-4B81B2597EA1
// Assembly location: C:\Users\zahid\Desktop\HitchHiker.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace LoneRobot.UI.Integration
{
  [DesignerGenerated]
  public class LoneRobotInfo : Form
  {
    private IContainer components;
    [AccessedThroughProperty("LabelLR")]
    private Label _LabelLR;
    [AccessedThroughProperty("LabelLogo")]
    private Label _LabelLogo;
    [AccessedThroughProperty("TimerClose")]
    private Timer _TimerClose;
    [AccessedThroughProperty("LabelMessage")]
    private Label _LabelMessage;

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      this.LabelLR = new Label();
      this.TimerClose = new Timer(this.components);
      this.LabelLogo = new Label();
      this.LabelMessage = new Label();
      this.SuspendLayout();
      this.LabelLR.AutoSize = true;
      this.LabelLR.Font = new Font("Verdana", 8f, FontStyle.Bold);
      this.LabelLR.ForeColor = Color.White;
      Label labelLr1 = this.LabelLR;
      Point point1 = new Point(12, 9);
      Point point2 = point1;
      labelLr1.Location = point2;
      this.LabelLR.Name = "LabelLR";
      Label labelLr2 = this.LabelLR;
      Size size1 = new Size(79, 13);
      Size size2 = size1;
      labelLr2.Size = size2;
      this.LabelLR.TabIndex = 0;
      this.LabelLR.Text = "LoneRobot ";
      this.TimerClose.Interval = 3000;
      this.LabelLogo.Dock = DockStyle.Right;
      this.LabelLogo.Image = (Image) LoneRobot.UI.My.Resources.Resources.purple_robot_small_posed;
      Label labelLogo1 = this.LabelLogo;
      point1 = new Point(85, 0);
      Point point3 = point1;
      labelLogo1.Location = point3;
      this.LabelLogo.Name = "LabelLogo";
      Label labelLogo2 = this.LabelLogo;
      size1 = new Size(155, 178);
      Size size3 = size1;
      labelLogo2.Size = size3;
      this.LabelLogo.TabIndex = 1;
      this.LabelMessage.AutoSize = true;
      this.LabelMessage.Font = new Font("Verdana", 8f, FontStyle.Bold);
      this.LabelMessage.ForeColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      Label labelMessage1 = this.LabelMessage;
      point1 = new Point(12, 146);
      Point point4 = point1;
      labelMessage1.Location = point4;
      this.LabelMessage.Name = "LabelMessage";
      Label labelMessage2 = this.LabelMessage;
      size1 = new Size(0, 13);
      Size size4 = size1;
      labelMessage2.Size = size4;
      this.LabelMessage.TabIndex = 2;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(51, 83, 102);
      this.BackgroundImageLayout = ImageLayout.None;
      size1 = new Size(240, 178);
      this.ClientSize = size1;
      this.ControlBox = false;
      this.Controls.Add((Control) this.LabelMessage);
      this.Controls.Add((Control) this.LabelLR);
      this.Controls.Add((Control) this.LabelLogo);
      this.FormBorderStyle = FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (LoneRobotInfo);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.SizeGripStyle = SizeGripStyle.Hide;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Label LabelLR
    {
      [DebuggerNonUserCode] get => this._LabelLR;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LoneRobotInfo_Click);
        if (this._LabelLR != null)
          this._LabelLR.Click -= eventHandler;
        this._LabelLR = value;
        if (this._LabelLR == null)
          return;
        this._LabelLR.Click += eventHandler;
      }
    }

    internal virtual Label LabelLogo
    {
      [DebuggerNonUserCode] get => this._LabelLogo;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.LoneRobotInfo_Click);
        if (this._LabelLogo != null)
          this._LabelLogo.Click -= eventHandler;
        this._LabelLogo = value;
        if (this._LabelLogo == null)
          return;
        this._LabelLogo.Click += eventHandler;
      }
    }

    internal virtual Timer TimerClose
    {
      [DebuggerNonUserCode] get => this._TimerClose;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TimerClose_Tick);
        if (this._TimerClose != null)
          this._TimerClose.Tick -= eventHandler;
        this._TimerClose = value;
        if (this._TimerClose == null)
          return;
        this._TimerClose.Tick += eventHandler;
      }
    }

    internal virtual Label LabelMessage
    {
      [DebuggerNonUserCode] get => this._LabelMessage;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LabelMessage = value;
    }

    public LoneRobotInfo(string Message)
    {
      this.Click += new EventHandler(this.LoneRobotInfo_Click);
      this.Load += new EventHandler(this.LoneRobotInfo_Load);
      this.InitializeComponent();
      this.LabelMessage.Text = Message;
    }

    private void LoneRobotInfo_Click(object sender, EventArgs e) => this.Close();

    private void LoneRobotInfo_Load(object sender, EventArgs e) => this.TimerClose.Start();

    private void TimerClose_Tick(object sender, EventArgs e) => this.Close();
  }
}
