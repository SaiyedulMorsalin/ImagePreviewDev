// Decompiled with JetBrains decompiler
// Type: LoneRobot.UI.Controls.NamedImage
// Assembly: HitchHiker, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0532B763-C6E8-474A-A94B-4B81B2597EA1
// Assembly location: C:\Users\zahid\Desktop\HitchHiker.dll

using System.Drawing;

namespace LoneRobot.UI.Controls
{
  internal class NamedImage
  {
    private Image _image;
    private int _width;
    private int _height;
    private string _fileName;
    private string _FullPath;

    public Image Image
    {
      get => this._image;
      set => this._image = value;
    }

    public int Width
    {
      get => this._width;
      set => this._width = value;
    }

    public int Height
    {
      get => this._height;
      set => this._height = value;
    }

    public string FileName
    {
      get => this._fileName;
      set => this._fileName = value;
    }

    public string FullPath
    {
      get => this._FullPath;
      set => this._FullPath = value;
    }

    public NamedImage(Image image, string FullPath, string Filename)
    {
      this.Image = image;
      this.FullPath = FullPath;
      this.FileName = Filename;
    }
  }
}
