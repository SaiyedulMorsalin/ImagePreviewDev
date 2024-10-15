// Decompiled with JetBrains decompiler
// Type: LoneRobot.UI.MaxUIProfessionalColorTable
// Assembly: HitchHiker, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0532B763-C6E8-474A-A94B-4B81B2597EA1
// Assembly location: C:\Users\zahid\Desktop\HitchHiker.dll

using ManagedServices;
using System.Drawing;
using System.Windows.Forms;

namespace LoneRobot.UI
{
  public class MaxUIProfessionalColorTable : ProfessionalColorTable
  {
    private CuiUpdater MaxColors;

    public MaxUIProfessionalColorTable() => this.MaxColors = CuiUpdater.GetInstance();

    public override Color ButtonCheckedGradientBegin => this.MaxColors.GetControlColor();

    public override Color ButtonCheckedGradientEnd => this.MaxColors.GetControlColor();

    public override Color ButtonCheckedGradientMiddle => this.MaxColors.GetControlColor();

    public override Color ButtonPressedGradientBegin => this.MaxColors.GetButtonPressedColor();

    public override Color ButtonPressedGradientEnd => this.MaxColors.GetButtonPressedColor();

    public override Color ButtonPressedGradientMiddle => this.MaxColors.GetButtonPressedColor();

    public override Color ButtonSelectedBorder => this.MaxColors.GetButtonPressedColor();

    public override Color ButtonSelectedGradientBegin => this.MaxColors.GetButtonPressedColor();

    public override Color ButtonSelectedGradientEnd => this.MaxColors.GetButtonPressedColor();

    public override Color ButtonSelectedGradientMiddle => this.MaxColors.GetButtonPressedColor();

    public override Color CheckBackground => this.MaxColors.GetControlColor();

    public override Color GripDark => this.MaxColors.GetControlColor();

    public override Color GripLight => this.MaxColors.GetTextColor();

    public override Color ImageMarginGradientBegin => this.MaxColors.GetControlColor();

    public override Color ImageMarginGradientEnd => this.MaxColors.GetControlColor();

    public override Color ImageMarginGradientMiddle => this.MaxColors.GetControlColor();

    public override Color ImageMarginRevealedGradientBegin => this.MaxColors.GetControlColor();

    public override Color ImageMarginRevealedGradientEnd => this.MaxColors.GetControlColor();

    public override Color ImageMarginRevealedGradientMiddle => this.MaxColors.GetControlColor();

    public override Color MenuBorder => this.MaxColors.GetControlColor();

    public override Color MenuItemBorder => Color.FromArgb(174, 207, 247);

    public override Color MenuItemPressedGradientBegin => this.MaxColors.GetButtonPressedColor();

    public override Color MenuItemPressedGradientEnd => this.MaxColors.GetButtonPressedColor();

    public override Color MenuItemPressedGradientMiddle => this.MaxColors.GetButtonPressedColor();

    public override Color MenuItemSelected => this.MaxColors.GetButtonPressedColor();

    public override Color MenuItemSelectedGradientBegin => this.MaxColors.GetButtonPressedColor();

    public override Color MenuItemSelectedGradientEnd => this.MaxColors.GetButtonPressedColor();

    public override Color MenuStripGradientBegin => this.MaxColors.GetControlColor();

    public override Color MenuStripGradientEnd => this.MaxColors.GetControlColor();

    public override Color OverflowButtonGradientBegin => this.MaxColors.GetTextColor();

    public override Color OverflowButtonGradientEnd => this.MaxColors.GetTextColor();

    public override Color OverflowButtonGradientMiddle => this.MaxColors.GetTextColor();

    public override Color RaftingContainerGradientBegin => this.MaxColors.GetControlColor();

    public override Color RaftingContainerGradientEnd => this.MaxColors.GetControlColor();

    public override Color SeparatorDark => this.MaxColors.GetTextColor();

    public override Color SeparatorLight => this.MaxColors.GetControlColor();

    public override Color ToolStripBorder => this.MaxColors.GetTextColor();

    public override Color ToolStripGradientBegin => this.MaxColors.GetControlColor();

    public override Color ToolStripGradientEnd => this.MaxColors.GetControlColor();

    public override Color ToolStripGradientMiddle => this.MaxColors.GetControlColor();

    public override Color ToolStripContentPanelGradientBegin => this.MaxColors.GetControlColor();

    public override Color ToolStripContentPanelGradientEnd => this.MaxColors.GetControlColor();

    public override Color ToolStripDropDownBackground => this.MaxColors.GetControlColor();

    public override Color StatusStripGradientBegin => this.MaxColors.GetControlColor();

    public override Color StatusStripGradientEnd => this.MaxColors.GetControlColor();

    public override Color ToolStripPanelGradientBegin => this.MaxColors.GetControlColor();

    public override Color ToolStripPanelGradientEnd => this.MaxColors.GetControlColor();
  }
}
