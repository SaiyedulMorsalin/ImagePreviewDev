// Decompiled with JetBrains decompiler
// Type: LoneRobot.UI.Controls.HikerPickedEventArgs
// Assembly: HitchHiker, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0532B763-C6E8-474A-A94B-4B81B2597EA1
// Assembly location: C:\Users\zahid\Desktop\HitchHiker.dll

using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoneRobot.UI.Controls
{
  public class HikerPickedEventArgs : EventArgs
  {
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

    public HikerPickedEventArgs(Image image, string fileName, HitchHiker control)
    {
      this.Image = image;
      this.FileName = fileName;
      control.CurrentItem = fileName;
    }

    public HikerPickedEventArgs(
      Image image,
      string fileName,
      HitchHiker control,
      Point Location,
      MouseButtons MouseButton)
    {
      this.Image = image;
      this.FileName = fileName;
      this.Location = Location;
      this.MouseButton = MouseButton;
      control.CurrentItem = fileName;
    }
  }
}
