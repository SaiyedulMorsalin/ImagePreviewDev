// Decompiled with JetBrains decompiler
// Type: LoneRobot.UI.HitchHikerFavouritesDialog
// Assembly: HitchHiker, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0532B763-C6E8-474A-A94B-4B81B2597EA1
// Assembly location: C:\Users\zahid\Desktop\HitchHiker.dll

using LoneRobot.UI.Controls;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace LoneRobot.UI
{
  [DesignerGenerated]
  public class HitchHikerFavouritesDialog : Form
  {
    private IContainer components;
    [AccessedThroughProperty("ListBoxFavourites")]
    private ListBox _ListBoxFavourites;
    [AccessedThroughProperty("Button_projUP")]
    private Button _Button_projUP;
    [AccessedThroughProperty("Button_projDown")]
    private Button _Button_projDown;
    [AccessedThroughProperty("Button_ProjCancel")]
    private Button _Button_ProjCancel;
    [AccessedThroughProperty("Button_ProjOK")]
    private Button _Button_ProjOK;
    [AccessedThroughProperty("FileBrowser")]
    private FolderBrowserDialog _FileBrowser;
    [AccessedThroughProperty("Button_projDel")]
    private Button _Button_projDel;
    [AccessedThroughProperty("Button_ProjAdd")]
    private Button _Button_ProjAdd;
    private HitchHiker HitchHikerRef;

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (HitchHikerFavouritesDialog));
      this.ListBoxFavourites = new ListBox();
      this.Button_ProjCancel = new Button();
      this.Button_ProjOK = new Button();
      this.FileBrowser = new FolderBrowserDialog();
      this.Button_projUP = new Button();
      this.Button_projDel = new Button();
      this.Button_ProjAdd = new Button();
      this.Button_projDown = new Button();
      this.SuspendLayout();
      this.ListBoxFavourites.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.ListBoxFavourites.BackColor = SystemColors.ControlDark;
      this.ListBoxFavourites.BorderStyle = BorderStyle.FixedSingle;
      this.ListBoxFavourites.Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ListBoxFavourites.FormattingEnabled = true;
      ListBox listBoxFavourites1 = this.ListBoxFavourites;
      Point point1 = new Point(35, 4);
      Point point2 = point1;
      listBoxFavourites1.Location = point2;
      ListBox listBoxFavourites2 = this.ListBoxFavourites;
      Padding padding1 = new Padding(1);
      Padding padding2 = padding1;
      listBoxFavourites2.Margin = padding2;
      this.ListBoxFavourites.Name = "ListBoxFavourites";
      ListBox listBoxFavourites3 = this.ListBoxFavourites;
      Size size1 = new Size(425, 145);
      Size size2 = size1;
      listBoxFavourites3.Size = size2;
      this.ListBoxFavourites.TabIndex = 0;
      this.Button_ProjCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.Button_ProjCancel.FlatStyle = FlatStyle.Flat;
      Button buttonProjCancel1 = this.Button_ProjCancel;
      point1 = new Point(381, 160);
      Point point3 = point1;
      buttonProjCancel1.Location = point3;
      Button buttonProjCancel2 = this.Button_ProjCancel;
      padding1 = new Padding(1);
      Padding padding3 = padding1;
      buttonProjCancel2.Margin = padding3;
      this.Button_ProjCancel.Name = "Button_ProjCancel";
      Button buttonProjCancel3 = this.Button_ProjCancel;
      size1 = new Size(73, 26);
      Size size3 = size1;
      buttonProjCancel3.Size = size3;
      this.Button_ProjCancel.TabIndex = 4;
      this.Button_ProjCancel.Text = "Cancel";
      this.Button_ProjCancel.UseVisualStyleBackColor = false;
      this.Button_ProjOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.Button_ProjOK.FlatStyle = FlatStyle.Flat;
      Button buttonProjOk1 = this.Button_ProjOK;
      point1 = new Point(306, 160);
      Point point4 = point1;
      buttonProjOk1.Location = point4;
      Button buttonProjOk2 = this.Button_ProjOK;
      padding1 = new Padding(1);
      Padding padding4 = padding1;
      buttonProjOk2.Margin = padding4;
      this.Button_ProjOK.Name = "Button_ProjOK";
      Button buttonProjOk3 = this.Button_ProjOK;
      size1 = new Size(73, 26);
      Size size4 = size1;
      buttonProjOk3.Size = size4;
      this.Button_ProjOK.TabIndex = 5;
      this.Button_ProjOK.Text = "OK";
      this.Button_ProjOK.UseVisualStyleBackColor = false;
      this.FileBrowser.Description = "Pick a folder to specify a new Project location";
      this.FileBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
      this.Button_projUP.FlatStyle = FlatStyle.Flat;
      this.Button_projUP.Image = (Image) LoneRobot.UI.My.Resources.Resources.up_16;
      Button buttonProjUp1 = this.Button_projUP;
      point1 = new Point(1, 4);
      Point point5 = point1;
      buttonProjUp1.Location = point5;
      Button buttonProjUp2 = this.Button_projUP;
      padding1 = new Padding(1);
      Padding padding5 = padding1;
      buttonProjUp2.Margin = padding5;
      this.Button_projUP.Name = "Button_projUP";
      Button buttonProjUp3 = this.Button_projUP;
      size1 = new Size(30, 30);
      Size size5 = size1;
      buttonProjUp3.Size = size5;
      this.Button_projUP.TabIndex = 1;
      this.Button_projUP.TextAlign = ContentAlignment.MiddleRight;
      this.Button_projUP.UseVisualStyleBackColor = false;
      this.Button_projDel.FlatStyle = FlatStyle.Flat;
      this.Button_projDel.Image = (Image) LoneRobot.UI.My.Resources.Resources.minus;
      Button buttonProjDel1 = this.Button_projDel;
      point1 = new Point(1, 77);
      Point point6 = point1;
      buttonProjDel1.Location = point6;
      Button buttonProjDel2 = this.Button_projDel;
      padding1 = new Padding(1);
      Padding padding6 = padding1;
      buttonProjDel2.Margin = padding6;
      this.Button_projDel.Name = "Button_projDel";
      Button buttonProjDel3 = this.Button_projDel;
      padding1 = new Padding(0, 1, 3, 0);
      Padding padding7 = padding1;
      buttonProjDel3.Padding = padding7;
      Button buttonProjDel4 = this.Button_projDel;
      size1 = new Size(30, 30);
      Size size6 = size1;
      buttonProjDel4.Size = size6;
      this.Button_projDel.TabIndex = 3;
      this.Button_projDel.TextAlign = ContentAlignment.MiddleRight;
      this.Button_projDel.UseVisualStyleBackColor = false;
      this.Button_ProjAdd.FlatStyle = FlatStyle.Flat;
      this.Button_ProjAdd.Image = (Image) LoneRobot.UI.My.Resources.Resources.plus;
      Button buttonProjAdd1 = this.Button_ProjAdd;
      point1 = new Point(1, 45);
      Point point7 = point1;
      buttonProjAdd1.Location = point7;
      Button buttonProjAdd2 = this.Button_ProjAdd;
      padding1 = new Padding(1);
      Padding padding8 = padding1;
      buttonProjAdd2.Margin = padding8;
      this.Button_ProjAdd.Name = "Button_ProjAdd";
      Button buttonProjAdd3 = this.Button_ProjAdd;
      size1 = new Size(30, 30);
      Size size7 = size1;
      buttonProjAdd3.Size = size7;
      this.Button_ProjAdd.TabIndex = 6;
      this.Button_ProjAdd.TextAlign = ContentAlignment.MiddleRight;
      this.Button_ProjAdd.UseVisualStyleBackColor = false;
      this.Button_projDown.FlatStyle = FlatStyle.Flat;
      this.Button_projDown.Image = (Image) LoneRobot.UI.My.Resources.Resources.down_16;
      Button buttonProjDown1 = this.Button_projDown;
      point1 = new Point(1, 118);
      Point point8 = point1;
      buttonProjDown1.Location = point8;
      Button buttonProjDown2 = this.Button_projDown;
      padding1 = new Padding(1);
      Padding padding9 = padding1;
      buttonProjDown2.Margin = padding9;
      this.Button_projDown.Name = "Button_projDown";
      Button buttonProjDown3 = this.Button_projDown;
      size1 = new Size(30, 30);
      Size size8 = size1;
      buttonProjDown3.Size = size8;
      this.Button_projDown.TabIndex = 2;
      this.Button_projDown.TextAlign = ContentAlignment.MiddleRight;
      this.Button_projDown.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(7f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(462, 199);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Button_projUP);
      this.Controls.Add((Control) this.Button_projDel);
      this.Controls.Add((Control) this.Button_ProjAdd);
      this.Controls.Add((Control) this.Button_ProjOK);
      this.Controls.Add((Control) this.Button_ProjCancel);
      this.Controls.Add((Control) this.ListBoxFavourites);
      this.Controls.Add((Control) this.Button_projDown);
      this.Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (HitchHikerFavouritesDialog);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.SizeGripStyle = SizeGripStyle.Show;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Manage Favourites";
      this.ResumeLayout(false);
    }

    internal virtual ListBox ListBoxFavourites
    {
      [DebuggerNonUserCode] get => this._ListBoxFavourites;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ListBoxFavourites = value;
    }

    internal virtual Button Button_projUP
    {
      [DebuggerNonUserCode] get => this._Button_projUP;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        if (this._Button_projUP != null)
          this._Button_projUP.Click -= eventHandler;
        this._Button_projUP = value;
        if (this._Button_projUP == null)
          return;
        this._Button_projUP.Click += eventHandler;
      }
    }

    internal virtual Button Button_projDown
    {
      [DebuggerNonUserCode] get => this._Button_projDown;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        if (this._Button_projDown != null)
          this._Button_projDown.Click -= eventHandler;
        this._Button_projDown = value;
        if (this._Button_projDown == null)
          return;
        this._Button_projDown.Click += eventHandler;
      }
    }

    internal virtual Button Button_ProjCancel
    {
      [DebuggerNonUserCode] get => this._Button_ProjCancel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_ProjCancel_Click);
        if (this._Button_ProjCancel != null)
          this._Button_ProjCancel.Click -= eventHandler;
        this._Button_ProjCancel = value;
        if (this._Button_ProjCancel == null)
          return;
        this._Button_ProjCancel.Click += eventHandler;
      }
    }

    internal virtual Button Button_ProjOK
    {
      [DebuggerNonUserCode] get => this._Button_ProjOK;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_ProjOK_Click);
        if (this._Button_ProjOK != null)
          this._Button_ProjOK.Click -= eventHandler;
        this._Button_ProjOK = value;
        if (this._Button_ProjOK == null)
          return;
        this._Button_ProjOK.Click += eventHandler;
      }
    }

    internal virtual FolderBrowserDialog FileBrowser
    {
      [DebuggerNonUserCode] get => this._FileBrowser;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._FileBrowser = value;
    }

    internal virtual Button Button_projDel
    {
      [DebuggerNonUserCode] get => this._Button_projDel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        if (this._Button_projDel != null)
          this._Button_projDel.Click -= eventHandler;
        this._Button_projDel = value;
        if (this._Button_projDel == null)
          return;
        this._Button_projDel.Click += eventHandler;
      }
    }

    internal virtual Button Button_ProjAdd
    {
      [DebuggerNonUserCode] get => this._Button_ProjAdd;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button_ProjAdd_Click);
        if (this._Button_ProjAdd != null)
          this._Button_ProjAdd.Click -= eventHandler;
        this._Button_ProjAdd = value;
        if (this._Button_ProjAdd == null)
          return;
        this._Button_ProjAdd.Click += eventHandler;
      }
    }

    public HitchHikerFavouritesDialog(ref HitchHiker HitchHikerRef)
    {
      // ISSUE: unable to decompile the method.
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      if (this.ListBoxFavourites.SelectedIndex >= checked (this.ListBoxFavourites.Items.Count - 1))
        return;
      string str = Conversions.ToString(this.ListBoxFavourites.Items[this.ListBoxFavourites.SelectedIndex]);
      this.ListBoxFavourites.Items[this.ListBoxFavourites.SelectedIndex] = (object) Conversions.ToString(this.ListBoxFavourites.Items[checked (this.ListBoxFavourites.SelectedIndex + 1)]);
      this.ListBoxFavourites.Items[checked (this.ListBoxFavourites.SelectedIndex + 1)] = (object) str;
      this.ListBoxFavourites.SetSelected(checked (this.ListBoxFavourites.SelectedIndex + 1), true);
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      if (!(this.ListBoxFavourites.SelectedIndex != 0 & this.ListBoxFavourites.Items.Count > 0))
        return;
      string str = Conversions.ToString(this.ListBoxFavourites.Items[this.ListBoxFavourites.SelectedIndex]);
      this.ListBoxFavourites.Items[this.ListBoxFavourites.SelectedIndex] = (object) Conversions.ToString(this.ListBoxFavourites.Items[checked (this.ListBoxFavourites.SelectedIndex - 1)]);
      this.ListBoxFavourites.Items[checked (this.ListBoxFavourites.SelectedIndex - 1)] = (object) str;
      this.ListBoxFavourites.SetSelected(checked (this.ListBoxFavourites.SelectedIndex - 1), true);
    }

    private void Button3_Click(object sender, EventArgs e) => this.ListBoxFavourites.Items.Remove(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(this.ListBoxFavourites.SelectedItem)));

    private void Button_ProjAdd_Click(object sender, EventArgs e)
    {
      if (this.FileBrowser.ShowDialog() != DialogResult.OK)
        return;
      this.ListBoxFavourites.Items.Add((object) this.FileBrowser.SelectedPath);
    }

    private void Button_ProjCancel_Click(object sender, EventArgs e) => this.Close();

    private void ProjectSetup_Load(object sender, EventArgs e)
    {
    }

    private void Button_ProjOK_Click(object sender, EventArgs e)
    {
      if (this.ListBoxFavourites.Items.Count < 1)
      {
        int num = (int) MessageBox.Show("You must specify at least one favourite!", "HitchHiker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        XmlDocument xmlDocument = new XmlDocument();
        XmlElement element1 = xmlDocument.CreateElement("LoneRobot");
        xmlDocument.AppendChild((XmlNode) element1);
        XmlElement element2 = xmlDocument.CreateElement("HitchHiker");
        XmlNode xmlNode = element1.AppendChild((XmlNode) element2);
        XmlElement element3 = xmlDocument.CreateElement("Favourites");
        try
        {
          foreach (object obj in this.ListBoxFavourites.Items)
          {
            object objectValue = RuntimeHelpers.GetObjectValue(obj);
            XmlElement element4 = xmlDocument.CreateElement("Path");
            element4.InnerText = Conversions.ToString(objectValue);
            element3.AppendChild((XmlNode) element4);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        xmlNode.AppendChild((XmlNode) element3);
        xmlDocument.Save(this.HitchHikerRef.ScriptPath + "\\HitchHikerFavourites.xml");
        this.Close();
      }
    }
  }
}
