// Decompiled with JetBrains decompiler
// Type: LoneRobot.UI.Controls.CornerCurveMode
// Assembly: HitchHiker, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0532B763-C6E8-474A-A94B-4B81B2597EA1
// Assembly location: C:\Users\zahid\Desktop\HitchHiker.dll

using System;

namespace LoneRobot.UI.Controls
{
  [Flags]
  public enum CornerCurveMode
  {
    None = 0,
    TopLeft = 1,
    TopRight = 2,
    TopLeft_TopRight = TopRight | TopLeft, // 0x00000003
    BottomLeft = 4,
    TopLeft_BottomLeft = BottomLeft | TopLeft, // 0x00000005
    TopRight_BottomLeft = BottomLeft | TopRight, // 0x00000006
    TopLeft_TopRight_BottomLeft = TopRight_BottomLeft | TopLeft, // 0x00000007
    BottomRight = 8,
    BottomRight_TopLeft = BottomRight | TopLeft, // 0x00000009
    BottomRight_TopRight = BottomRight | TopRight, // 0x0000000A
    BottomRight_TopLeft_TopRight = BottomRight_TopRight | TopLeft, // 0x0000000B
    BottomRight_BottomLeft = BottomRight | BottomLeft, // 0x0000000C
    BottomRight_TopLeft_BottomLeft = BottomRight_BottomLeft | TopLeft, // 0x0000000D
    BottomRight_TopRight_BottomLeft = BottomRight_BottomLeft | TopRight, // 0x0000000E
    All = BottomRight_TopRight_BottomLeft | TopLeft, // 0x0000000F
  }
}
