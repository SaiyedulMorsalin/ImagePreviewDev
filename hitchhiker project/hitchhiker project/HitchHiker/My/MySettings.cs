// Decompiled with JetBrains decompiler
// Type: LoneRobot.UI.My.MySettings
// Assembly: HitchHiker, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0532B763-C6E8-474A-A94B-4B81B2597EA1
// Assembly location: C:\Users\zahid\Desktop\HitchHiker.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace LoneRobot.UI.My
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());

    [DebuggerNonUserCode]
    public MySettings()
    {
    }

    public static MySettings Default => MySettings.defaultInstance;
  }
}
