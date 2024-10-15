// Decompiled with JetBrains decompiler
// Type: LoneRobot.UI.Controls.CustomPanel
// Assembly: HitchHiker, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0532B763-C6E8-474A-A94B-4B81B2597EA1
// Assembly location: C:\Users\zahid\Desktop\HitchHiker.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LoneRobot.UI.Controls
{
  [ToolboxBitmap(typeof (Panel))]
  public class CustomPanel : Panel
  {
    private Color _BackColour1;
    private Color _BackColour2;
    private LinearGradientMode _GradientMode;
    private BorderStyle _BorderStyle;
    private Color _BorderColour;
    private int _BorderWidth;
    private int _Curvature;
    private CornerCurveMode _CurveMode;

    [Category("Appearance")]
    [Description("The primary background color used to display text and graphics in the control.")]
    [DefaultValue(typeof (Color), "Window")]
    public new Color BackColor
    {
      get => this._BackColour1;
      set
      {
        this._BackColour1 = value;
        this.Invalidate();
      }
    }

    [Category("Appearance")]
    [DefaultValue(typeof (Color), "Window")]
    [Description("The secondary background color used to paint the control.")]
    public Color BackColor2
    {
      get => this._BackColour2;
      set
      {
        this._BackColour2 = value;
        if (!this.DesignMode)
          return;
        this.Invalidate();
      }
    }

    [Category("Appearance")]
    [Description("The gradient direction used to paint the control.")]
    [DefaultValue(typeof (LinearGradientMode), "None")]
    public LinearGradientMode GradientMode
    {
      get => this._GradientMode;
      set
      {
        this._GradientMode = value;
        if (!this.DesignMode)
          return;
        this.Invalidate();
      }
    }

    [Description("The border style used to paint the control.")]
    [Category("Appearance")]
    [DefaultValue(typeof (BorderStyle), "None")]
    public new BorderStyle BorderStyle
    {
      get => this._BorderStyle;
      set
      {
        this._BorderStyle = value;
        if (!this.DesignMode)
          return;
        this.Invalidate();
      }
    }

    [Category("Appearance")]
    [DefaultValue(typeof (Color), "WindowFrame")]
    [Description("The border color used to paint the control.")]
    public Color BorderColor
    {
      get => this._BorderColour;
      set
      {
        this._BorderColour = value;
        if (!this.DesignMode)
          return;
        this.Invalidate();
      }
    }

    [Description("The width of the border used to paint the control.")]
    [DefaultValue(typeof (int), "1")]
    [Category("Appearance")]
    public int BorderWidth
    {
      get => this._BorderWidth;
      set
      {
        this._BorderWidth = value;
        if (!this.DesignMode)
          return;
        this.Invalidate();
      }
    }

    [Description("The radius of the curve used to paint the corners of the control.")]
    [Category("Appearance")]
    [DefaultValue(typeof (int), "0")]
    public int Curvature
    {
      get => this._Curvature;
      set
      {
        this._Curvature = value;
        if (!this.DesignMode)
          return;
        this.Invalidate();
      }
    }

    [DefaultValue(typeof (CornerCurveMode), "All")]
    [Category("Appearance")]
    [Description("The style of the curves to be drawn on the control.")]
    public CornerCurveMode CurveMode
    {
      get => this._CurveMode;
      set
      {
        this._CurveMode = value;
        if (!this.DesignMode)
          return;
        this.Invalidate();
      }
    }

    private int adjustedCurve
    {
      get
      {
        int adjustedCurve = 0;
        if (this._CurveMode != CornerCurveMode.None)
        {
          double curvature = (double) this._Curvature;
          Rectangle clientRectangle = this.ClientRectangle;
          double num = (double) clientRectangle.Width / 2.0;
          adjustedCurve = curvature <= num ? this._Curvature : CustomPanel.DoubleToInt((double) this.ClientRectangle.Width / 2.0);
          if ((double) adjustedCurve > (double) this.ClientRectangle.Height / 2.0)
          {
            clientRectangle = this.ClientRectangle;
            adjustedCurve = CustomPanel.DoubleToInt((double) clientRectangle.Height / 2.0);
          }
        }
        return adjustedCurve;
      }
    }

    public CustomPanel()
    {
      this._BackColour1 = SystemColors.Window;
      this._BackColour2 = SystemColors.Window;
      this._GradientMode = LinearGradientMode.None;
      this._BorderStyle = BorderStyle.None;
      this._BorderColour = SystemColors.WindowFrame;
      this._BorderWidth = 1;
      this._Curvature = 0;
      this._CurveMode = CornerCurveMode.All;
      this.SetDefaultControlStyles();
      this.DoubleBuffered = true;
      this.customInitialisation();
    }

    private void SetDefaultControlStyles()
    {
      this.SetStyle(ControlStyles.DoubleBuffer, true);
      this.SetStyle(ControlStyles.AllPaintingInWmPaint, false);
      this.SetStyle(ControlStyles.ResizeRedraw, true);
      this.SetStyle(ControlStyles.UserPaint, true);
      this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
    }

    private void customInitialisation()
    {
      this.SuspendLayout();
      base.BackColor = Color.Transparent;
      this.BorderStyle = BorderStyle.None;
      this.ResumeLayout(false);
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
      base.OnPaintBackground(e);
      e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
      GraphicsPath path = this.GetPath();
      Rectangle clientRectangle = this.ClientRectangle;
      if (this.ClientRectangle.Width == 0)
        checked { ++clientRectangle.Width; }
      if (this.ClientRectangle.Height == 0)
        checked { ++clientRectangle.Height; }
      LinearGradientBrush linearGradientBrush = this._GradientMode != LinearGradientMode.None ? new LinearGradientBrush(clientRectangle, this._BackColour1, this._BackColour2, (System.Drawing.Drawing2D.LinearGradientMode) this._GradientMode) : new LinearGradientBrush(clientRectangle, this._BackColour1, this._BackColour1, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
      e.Graphics.FillPath((Brush) linearGradientBrush, path);
      linearGradientBrush.Dispose();
      switch (this._BorderStyle)
      {
        case BorderStyle.FixedSingle:
          Pen pen = new Pen(this._BorderColour, (float) this._BorderWidth);
          e.Graphics.DrawPath(pen, path);
          pen.Dispose();
          break;
        case BorderStyle.Fixed3D:
          CustomPanel.DrawBorder3D(e.Graphics, this.ClientRectangle);
          break;
      }
      linearGradientBrush.Dispose();
      path.Dispose();
    }

    protected GraphicsPath GetPath()
    {
      GraphicsPath path = new GraphicsPath();
      if (this._BorderStyle == BorderStyle.Fixed3D)
      {
        path.AddRectangle(this.ClientRectangle);
      }
      else
      {
        try
        {
          int num1 = 0;
          Rectangle clientRectangle = this.ClientRectangle;
          int num2 = 0;
          switch (this._BorderStyle)
          {
            case BorderStyle.None:
              num1 = this.adjustedCurve;
              break;
            case BorderStyle.FixedSingle:
              if (this._BorderWidth > 1)
                num2 = CustomPanel.DoubleToInt((double) this.BorderWidth / 2.0);
              num1 = this.adjustedCurve;
              break;
          }
          if (num1 == 0)
          {
            path.AddRectangle(Rectangle.Inflate(clientRectangle, checked (-num2), checked (-num2)));
          }
          else
          {
            int num3 = checked (clientRectangle.Width - 1 - num2);
            int num4 = checked (clientRectangle.Height - 1 - num2);
            int num5 = (this._CurveMode & CornerCurveMode.TopRight) == CornerCurveMode.None ? 1 : checked (num1 * 2);
            path.AddArc(checked (num3 - num5), num2, num5, num5, 270f, 90f);
            int num6 = (this._CurveMode & CornerCurveMode.BottomRight) == CornerCurveMode.None ? 1 : checked (num1 * 2);
            path.AddArc(checked (num3 - num6), checked (num4 - num6), num6, num6, 0.0f, 90f);
            int num7 = (this._CurveMode & CornerCurveMode.BottomLeft) == CornerCurveMode.None ? 1 : checked (num1 * 2);
            path.AddArc(num2, checked (num4 - num7), num7, num7, 90f, 90f);
            int num8 = (this._CurveMode & CornerCurveMode.TopLeft) == CornerCurveMode.None ? 1 : checked (num1 * 2);
            path.AddArc(num2, num2, num8, num8, 180f, 90f);
            path.CloseFigure();
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          path.AddRectangle(this.ClientRectangle);
          ProjectData.ClearProjectError();
        }
      }
      return path;
    }

    public static void DrawBorder3D(Graphics graphics, Rectangle rectangle)
    {
      graphics.SmoothingMode = SmoothingMode.Default;
      graphics.DrawLine(SystemPens.ControlDark, rectangle.X, rectangle.Y, checked (rectangle.Width - 1), rectangle.Y);
      graphics.DrawLine(SystemPens.ControlDark, rectangle.X, rectangle.Y, rectangle.X, checked (rectangle.Height - 1));
      graphics.DrawLine(SystemPens.ControlDarkDark, checked (rectangle.X + 1), checked (rectangle.Y + 1), checked (rectangle.Width - 1), checked (rectangle.Y + 1));
      graphics.DrawLine(SystemPens.ControlDarkDark, checked (rectangle.X + 1), checked (rectangle.Y + 1), checked (rectangle.X + 1), checked (rectangle.Height - 1));
      graphics.DrawLine(SystemPens.ControlLight, checked (rectangle.X + 1), checked (rectangle.Height - 2), checked (rectangle.Width - 2), checked (rectangle.Height - 2));
      graphics.DrawLine(SystemPens.ControlLight, checked (rectangle.Width - 2), checked (rectangle.Y + 1), checked (rectangle.Width - 2), checked (rectangle.Height - 2));
      graphics.DrawLine(SystemPens.ControlLightLight, rectangle.X, checked (rectangle.Height - 1), checked (rectangle.Width - 1), checked (rectangle.Height - 1));
      graphics.DrawLine(SystemPens.ControlLightLight, checked (rectangle.Width - 1), rectangle.Y, checked (rectangle.Width - 1), checked (rectangle.Height - 1));
    }

    public static int DoubleToInt(double value) => Decimal.ToInt32(Decimal.Floor(Decimal.Parse(value.ToString())));
  }
}
