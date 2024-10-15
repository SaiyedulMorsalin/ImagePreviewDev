// Decompiled with JetBrains decompiler
// Type: LoneRobot.UI.MaxToolStripRenderer
// Assembly: HitchHiker, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0532B763-C6E8-474A-A94B-4B81B2597EA1
// Assembly location: C:\Users\zahid\Desktop\HitchHiker.dll

using ManagedServices;
using System.Windows.Forms;

namespace LoneRobot.UI
{
  public class MaxToolStripRenderer : ToolStripProfessionalRenderer
  {
    private CuiUpdater MaxColors;

    protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
    {
    }

    protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
    {
      e.ArrowColor = this.MaxColors.GetTextColor();
      base.OnRenderArrow(e);
    }

    public MaxToolStripRenderer() => this.MaxColors = CuiUpdater.GetInstance();

    public MaxToolStripRenderer(ProfessionalColorTable maxcolortable)
      : base(maxcolortable)
    {
      this.MaxColors = CuiUpdater.GetInstance();
    }

    protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
    {
      e.TextColor = this.MaxColors.GetTextColor();
      base.OnRenderItemText(e);
    }
  }
}
