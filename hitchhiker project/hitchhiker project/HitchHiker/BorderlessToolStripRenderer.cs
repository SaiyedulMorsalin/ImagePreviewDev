// Decompiled with JetBrains decompiler
// Type: LoneRobot.UI.BorderlessToolStripRenderer
// Assembly: HitchHiker, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0532B763-C6E8-474A-A94B-4B81B2597EA1
// Assembly location: C:\Users\zahid\Desktop\HitchHiker.dll

using ManagedServices;
using MaxCustomControls;
using System.Windows.Forms;

namespace LoneRobot.UI
{
  public class BorderlessToolStripRenderer : MaxToolStripSystemRenderer
  {
    private CuiUpdater MaxColors;

    protected virtual void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
    {
    }

    protected virtual void OnRenderArrow(ToolStripArrowRenderEventArgs e)
    {
      e.ArrowColor = this.MaxColors.GetTextColor();
      // ISSUE: explicit non-virtual call
      __nonvirtual (((ToolStripRenderer) this).OnRenderArrow(e));
    }

    public BorderlessToolStripRenderer() => this.MaxColors = CuiUpdater.GetInstance();
  }
}
