// Decompiled with JetBrains decompiler
// Type: LoneRobot.UI.Controls.HitchHiker
// Assembly: HitchHiker, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0532B763-C6E8-474A-A94B-4B81B2597EA1
// Assembly location: C:\Users\zahid\Desktop\HitchHiker.dll

using CSharpUtilities;
using LoneRobot.UI.Integration;
using LoneRobot.UI.My;
using ManagedServices;
using MaxCustomControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace LoneRobot.UI.Controls
{
  [DesignerGenerated]
  [DefaultEvent("ThumbPicked")]
  [Description("A UI Tool designed for 3DSMax Integration")]
  public class HitchHiker : MaxUserControl
  {
    private IContainer components;
    [AccessedThroughProperty("ThumbBoard")]
    private FlowLayoutPanel _ThumbBoard;
    [AccessedThroughProperty("TableLayoutPanelUC")]
    private TableLayoutPanel _TableLayoutPanelUC;
    [AccessedThroughProperty("FileToolTip")]
    private ToolTip _FileToolTip;
    [AccessedThroughProperty("TableLayoutPanelProgress")]
    private TableLayoutPanel _TableLayoutPanelProgress;
    [AccessedThroughProperty("ButtonCancel")]
    private Button _ButtonCancel;
    [AccessedThroughProperty("ProgressUpdate")]
    private ProgressBar _ProgressUpdate;
    [AccessedThroughProperty("MaxThreadWorker")]
    private SynchronizingBackgroundWorker _MaxThreadWorker;
    [AccessedThroughProperty("RefreshMenuItem")]
    private ToolStripMenuItem _RefreshMenuItem;
    [AccessedThroughProperty("JpgMenuItem")]
    private ToolStripMenuItem _JpgMenuItem;
    [AccessedThroughProperty("BmpMenuItem")]
    private ToolStripMenuItem _BmpMenuItem;
    [AccessedThroughProperty("TifMenuItem")]
    private ToolStripMenuItem _TifMenuItem;
    [AccessedThroughProperty("PngMenuItem")]
    private ToolStripMenuItem _PngMenuItem;
    [AccessedThroughProperty("SearchForMenu")]
    private ContextMenuStrip _SearchForMenu;
    [AccessedThroughProperty("PickDirectory")]
    private FolderBrowserDialog _PickDirectory;
    [AccessedThroughProperty("RpfMenuItem")]
    private ToolStripMenuItem _RpfMenuItem;
    [AccessedThroughProperty("TgaMenuItem")]
    private ToolStripMenuItem _TgaMenuItem;
    [AccessedThroughProperty("AviMenuItem")]
    private ToolStripMenuItem _AviMenuItem;
    [AccessedThroughProperty("WavMenuItem")]
    private ToolStripMenuItem _WavMenuItem;
    [AccessedThroughProperty("PSDMenuItem")]
    private ToolStripMenuItem _PSDMenuItem;
    [AccessedThroughProperty("MaxMenuItem")]
    private ToolStripMenuItem _MaxMenuItem;
    [AccessedThroughProperty("MenuToolTip")]
    private ToolTip _MenuToolTip;
    [AccessedThroughProperty("ToolStripMenuBar")]
    private ToolStrip _ToolStripMenuBar;
    [AccessedThroughProperty("ToolStripButtonIncExc")]
    private ToolStripButton _ToolStripButtonIncExc;
    [AccessedThroughProperty("ToolStripButtonLogic")]
    private ToolStripButton _ToolStripButtonLogic;
    [AccessedThroughProperty("TextBoxSearchString")]
    private ToolStripTextBox _TextBoxSearchString;
    [AccessedThroughProperty("ToolStripFiletypes")]
    private ToolStripDropDownButton _ToolStripFiletypes;
    [AccessedThroughProperty("ToolStripThumbsize")]
    private ToolStripDropDownButton _ToolStripThumbsize;
    [AccessedThroughProperty("TinyToolStripMenuItem")]
    private ToolStripMenuItem _TinyToolStripMenuItem;
    [AccessedThroughProperty("SmallToolStripMenuItem")]
    private ToolStripMenuItem _SmallToolStripMenuItem;
    [AccessedThroughProperty("MediumToolStripMenuItem")]
    private ToolStripMenuItem _MediumToolStripMenuItem;
    [AccessedThroughProperty("LargeToolStripMenuItem")]
    private ToolStripMenuItem _LargeToolStripMenuItem;
    [AccessedThroughProperty("ExtraLargeToolStripMenuItem")]
    private ToolStripMenuItem _ExtraLargeToolStripMenuItem;
    [AccessedThroughProperty("ToolStripDisplayStyle")]
    private ToolStripDropDownButton _ToolStripDisplayStyle;
    [AccessedThroughProperty("ImagesOnlyToolStripMenuItem")]
    private ToolStripMenuItem _ImagesOnlyToolStripMenuItem;
    [AccessedThroughProperty("ImagesAndTextToolStripMenuItem")]
    private ToolStripMenuItem _ImagesAndTextToolStripMenuItem;
    [AccessedThroughProperty("IconsOnlyToolStripMenuItem")]
    private ToolStripMenuItem _IconsOnlyToolStripMenuItem;
    [AccessedThroughProperty("IconsTextToolStripMenuItem")]
    private ToolStripMenuItem _IconsTextToolStripMenuItem;
    [AccessedThroughProperty("TextOnlyToolStripMenuItem")]
    private ToolStripMenuItem _TextOnlyToolStripMenuItem;
    [AccessedThroughProperty("ToolStripSort")]
    private ToolStripDropDownButton _ToolStripSort;
    [AccessedThroughProperty("SortbyNameToolStripMenuItem")]
    private ToolStripMenuItem _SortbyNameToolStripMenuItem;
    [AccessedThroughProperty("ByFilesizeAscendingMenuItem")]
    private ToolStripMenuItem _ByFilesizeAscendingMenuItem;
    [AccessedThroughProperty("SortByDateToolStripMenuItem")]
    private ToolStripMenuItem _SortByDateToolStripMenuItem;
    [AccessedThroughProperty("ToolStripSearchLabel")]
    private ToolStripLabel _ToolStripSearchLabel;
    [AccessedThroughProperty("ToolStripAbout")]
    private ToolStripButton _ToolStripAbout;
    [AccessedThroughProperty("ShowDataToolStripMenuItem")]
    private ToolStripMenuItem _ShowDataToolStripMenuItem;
    [AccessedThroughProperty("ImageTypeToolStripMenuItem")]
    private ToolStripMenuItem _ImageTypeToolStripMenuItem;
    [AccessedThroughProperty("RefreshToolStripMenuItem")]
    private ToolStripMenuItem _RefreshToolStripMenuItem;
    [AccessedThroughProperty("BmpToolStripMenuItem")]
    private ToolStripMenuItem _BmpToolStripMenuItem;
    [AccessedThroughProperty("JpgToolStripMenuItem")]
    private ToolStripMenuItem _JpgToolStripMenuItem;
    [AccessedThroughProperty("PngToolStripMenuItem")]
    private ToolStripMenuItem _PngToolStripMenuItem;
    [AccessedThroughProperty("TgaToolStripMenuItem")]
    private ToolStripMenuItem _TgaToolStripMenuItem;
    [AccessedThroughProperty("TifToolStripMenuItem")]
    private ToolStripMenuItem _TifToolStripMenuItem;
    [AccessedThroughProperty("PsdToolStripMenuItem")]
    private ToolStripMenuItem _PsdToolStripMenuItem;
    [AccessedThroughProperty("RpfToolStripMenuItem")]
    private ToolStripMenuItem _RpfToolStripMenuItem;
    [AccessedThroughProperty("ToolStripSeparator7")]
    private ToolStripSeparator _ToolStripSeparator7;
    [AccessedThroughProperty("OtherTypesToolStripMenuItem1")]
    private ToolStripMenuItem _OtherTypesToolStripMenuItem1;
    [AccessedThroughProperty("MaxToolStripMenuItem")]
    private ToolStripMenuItem _MaxToolStripMenuItem;
    [AccessedThroughProperty("AviToolStripMenuItem")]
    private ToolStripMenuItem _AviToolStripMenuItem;
    [AccessedThroughProperty("WavToolStripMenuItem")]
    private ToolStripMenuItem _WavToolStripMenuItem;
    [AccessedThroughProperty("ToolStripSeparator8")]
    private ToolStripSeparator _ToolStripSeparator8;
    [AccessedThroughProperty("ToolStripSeparator9")]
    private ToolStripSeparator _ToolStripSeparator9;
    [AccessedThroughProperty("ToolStripButtonDirectory")]
    private ToolStripDropDownButton _ToolStripButtonDirectory;
    [AccessedThroughProperty("ChooseToolStripMenuItem")]
    private ToolStripMenuItem _ChooseToolStripMenuItem;
    [AccessedThroughProperty("ToolStripSeparator10")]
    private ToolStripSeparator _ToolStripSeparator10;
    [AccessedThroughProperty("AddFavouriteToolStripMenuItem")]
    private ToolStripMenuItem _AddFavouriteToolStripMenuItem;
    [AccessedThroughProperty("ToolStripSeparator11")]
    private ToolStripSeparator _ToolStripSeparator11;
    [AccessedThroughProperty("ManageToolStripMenuItem")]
    private ToolStripMenuItem _ManageToolStripMenuItem;
    [AccessedThroughProperty("CacheThumbnailsToolStripMenuItem")]
    private ToolStripMenuItem _CacheThumbnailsToolStripMenuItem;
    private string _directory;
    private bool _ShowMenu;
    private bool _FullMenu;
    private Color _SelectedHighLight;
    private int _SelectedBorderWidth;
    private Color _ThumbPanelBackColor;
    private bool _ShowTooltips;
    private int _padding;
    private bool _ImageFormatsOnly;
    private HitchHiker.DisplayStyles _DisplayStyle;
    private HitchHiker.ThumbNailSize _ThumbNails;
    private string _CurrentItem;
    private ContentAlignment _TextAlign;
    private ContentAlignment _ImageAlign;
    private HitchHiker.filetypes _filetype;
    private Size _Thumbsize;
    public DataObject Fdata;
    private List<NamedImage> images;
    private HitchHiker.SortByOptions _sortby;
    private Button DashButtonSelected;
    private InterpolationMode _ThumbInterpolation;
    private InterpolationMode _ReturnImageInterpolation;
    private bool _ShowToolbar;
    private int _CurrentImageWidth;
    private int _CurrentImageHeight;
    private string _CurrentImageSize;
    private TextImageRelation _TextImageRelation;
    private Color _ButtonBackColor;
    private bool _binglybongly;
    private Random randomGenerator;
    private bool _RecursiveSearch;
    private bool _ButtonBorder;
    private object RightClickMenu;
    private ToolStripMenuItem MenuItem1;
    private ToolStripMenuItem MenuItem2;
    private ToolStripMenuItem MenuItem3;
    private ToolStripSeparator MenuItem4;
    private ToolStripMenuItem MenuItem5;
    private object MaxRightClickMenu;
    private ToolStripMenuItem MaxMenuItem1;
    private ToolStripMenuItem MaxMenuItem2;
    private ToolStripSeparator MaxMenuItem3;
    private ToolStripMenuItem MaxMenuItem4;
    public CuiUpdater Colorman;
    private bool AbortMaxLoadProcess;
    private int _RenderThumbsize;
    private bool _UseCustomBG;
    private Color _CustomBGColor;
    private bool _Capture;
    private bool _SaveAlpha;
    private int _RenderThumbsizeSmall;
    private int _RenderThumbsizeMedium;
    private int _RenderThumbsizeLarge;
    private bool _ShowFileDataOnButton;
    private HitchHiker.CacheState _CacheState;
    private bool _PurgeCache;
    private string _PopulateFilterPattern;
    private HitchHiker.PopulateFilterLogic _PopulateFilterLogic;
    private HitchHiker.PopulateFilterSearch _PopulateFilterSearch;
    private Font HHFont;
    public string ScriptPath;
    private bool _BypassCacheFolderWarning;
    private Button _FocusedControl;
    [Description("Gets the favourites from the stored xmlfile")]
    [Category("Data")]
    private StringCollection _Favourites;

    [DebuggerNonUserCode]
    protected virtual void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      // ISSUE: explicit non-virtual call
      __nonvirtual(((ContainerControl)this).Dispose(disposing));
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer)new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(HitchHiker));
      this.ThumbBoard = new FlowLayoutPanel();
      this.TableLayoutPanelUC = new TableLayoutPanel();
      this.TableLayoutPanelProgress = new TableLayoutPanel();
      this.ButtonCancel = new Button();
      this.ProgressUpdate = new ProgressBar();
      this.ToolStripMenuBar = new ToolStrip();
      this.ToolStripButtonDirectory = new ToolStripDropDownButton();
      this.ChooseToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripSeparator10 = new ToolStripSeparator();
      this.AddFavouriteToolStripMenuItem = new ToolStripMenuItem();
      this.ManageToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripSeparator11 = new ToolStripSeparator();
      this.ToolStripFiletypes = new ToolStripDropDownButton();
      this.ImageTypeToolStripMenuItem = new ToolStripMenuItem();
      this.BmpToolStripMenuItem = new ToolStripMenuItem();
      this.JpgToolStripMenuItem = new ToolStripMenuItem();
      this.PngToolStripMenuItem = new ToolStripMenuItem();
      this.TgaToolStripMenuItem = new ToolStripMenuItem();
      this.TifToolStripMenuItem = new ToolStripMenuItem();
      this.PsdToolStripMenuItem = new ToolStripMenuItem();
      this.RpfToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripSeparator7 = new ToolStripSeparator();
      this.OtherTypesToolStripMenuItem1 = new ToolStripMenuItem();
      this.MaxToolStripMenuItem = new ToolStripMenuItem();
      this.AviToolStripMenuItem = new ToolStripMenuItem();
      this.WavToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripThumbsize = new ToolStripDropDownButton();
      this.TinyToolStripMenuItem = new ToolStripMenuItem();
      this.SmallToolStripMenuItem = new ToolStripMenuItem();
      this.MediumToolStripMenuItem = new ToolStripMenuItem();
      this.LargeToolStripMenuItem = new ToolStripMenuItem();
      this.ExtraLargeToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripDisplayStyle = new ToolStripDropDownButton();
      this.ImagesOnlyToolStripMenuItem = new ToolStripMenuItem();
      this.ImagesAndTextToolStripMenuItem = new ToolStripMenuItem();
      this.IconsOnlyToolStripMenuItem = new ToolStripMenuItem();
      this.IconsTextToolStripMenuItem = new ToolStripMenuItem();
      this.TextOnlyToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripSeparator8 = new ToolStripSeparator();
      this.ShowDataToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripSeparator9 = new ToolStripSeparator();
      this.RefreshToolStripMenuItem = new ToolStripMenuItem();
      this.CacheThumbnailsToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripSort = new ToolStripDropDownButton();
      this.SortbyNameToolStripMenuItem = new ToolStripMenuItem();
      this.ByFilesizeAscendingMenuItem = new ToolStripMenuItem();
      this.SortByDateToolStripMenuItem = new ToolStripMenuItem();
      this.ToolStripSearchLabel = new ToolStripLabel();
      this.ToolStripButtonIncExc = new ToolStripButton();
      this.TextBoxSearchString = new ToolStripTextBox();
      this.ToolStripButtonLogic = new ToolStripButton();
      this.ToolStripAbout = new ToolStripButton();
      this.SearchForMenu = new ContextMenuStrip(this.components);
      this.RefreshMenuItem = new ToolStripMenuItem();
      this.AviMenuItem = new ToolStripMenuItem();
      this.BmpMenuItem = new ToolStripMenuItem();
      this.JpgMenuItem = new ToolStripMenuItem();
      this.PngMenuItem = new ToolStripMenuItem();
      this.PSDMenuItem = new ToolStripMenuItem();
      this.MaxMenuItem = new ToolStripMenuItem();
      this.RpfMenuItem = new ToolStripMenuItem();
      this.TgaMenuItem = new ToolStripMenuItem();
      this.TifMenuItem = new ToolStripMenuItem();
      this.WavMenuItem = new ToolStripMenuItem();
      this.FileToolTip = new ToolTip(this.components);
      this.MaxThreadWorker = new SynchronizingBackgroundWorker();
      this.PickDirectory = new FolderBrowserDialog();
      this.MenuToolTip = new ToolTip(this.components);
      this.TableLayoutPanelUC.SuspendLayout();
      this.TableLayoutPanelProgress.SuspendLayout();
      this.ToolStripMenuBar.SuspendLayout();
      this.SearchForMenu.SuspendLayout();
      ((Control)this).SuspendLayout();
      this.ThumbBoard.AutoScroll = true;
      this.ThumbBoard.BackColor = SystemColors.Control;
      this.ThumbBoard.BackgroundImageLayout = ImageLayout.Center;
      this.ThumbBoard.BorderStyle = BorderStyle.FixedSingle;
      this.ThumbBoard.Dock = DockStyle.Fill;
      this.ThumbBoard.Font = new Font("Verdana", 7f, FontStyle.Bold);
      FlowLayoutPanel thumbBoard1 = this.ThumbBoard;
      Point point1 = new Point(1, 22);
      Point point2 = point1;
      thumbBoard1.Location = point2;
      FlowLayoutPanel thumbBoard2 = this.ThumbBoard;
      Padding padding1 = new Padding(1, 0, 1, 1);
      Padding padding2 = padding1;
      thumbBoard2.Margin = padding2;
      this.ThumbBoard.Name = "ThumbBoard";
      FlowLayoutPanel thumbBoard3 = this.ThumbBoard;
      Size size1 = new Size(575, 227);
      Size size2 = size1;
      thumbBoard3.Size = size2;
      this.ThumbBoard.TabIndex = 3;
      this.TableLayoutPanelUC.ColumnCount = 1;
      this.TableLayoutPanelUC.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.TableLayoutPanelUC.Controls.Add((Control)this.ThumbBoard, 0, 1);
      this.TableLayoutPanelUC.Controls.Add((Control)this.TableLayoutPanelProgress, 0, 2);
      this.TableLayoutPanelUC.Controls.Add((Control)this.ToolStripMenuBar, 0, 0);
      this.TableLayoutPanelUC.Dock = DockStyle.Fill;
      TableLayoutPanel tableLayoutPanelUc1 = this.TableLayoutPanelUC;
      point1 = new Point(0, 0);
      Point point3 = point1;
      tableLayoutPanelUc1.Location = point3;
      TableLayoutPanel tableLayoutPanelUc2 = this.TableLayoutPanelUC;
      padding1 = new Padding(0);
      Padding padding3 = padding1;
      tableLayoutPanelUc2.Margin = padding3;
      this.TableLayoutPanelUC.Name = "TableLayoutPanelUC";
      this.TableLayoutPanelUC.RowCount = 3;
      this.TableLayoutPanelUC.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanelUC.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      this.TableLayoutPanelUC.RowStyles.Add(new RowStyle(SizeType.Absolute, 0.0f));
      this.TableLayoutPanelUC.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
      TableLayoutPanel tableLayoutPanelUc3 = this.TableLayoutPanelUC;
      size1 = new Size(577, 250);
      Size size3 = size1;
      tableLayoutPanelUc3.Size = size3;
      this.TableLayoutPanelUC.TabIndex = 4;
      this.TableLayoutPanelProgress.ColumnCount = 2;
      this.TableLayoutPanelProgress.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.TableLayoutPanelProgress.ColumnStyles.Add(new ColumnStyle());
      this.TableLayoutPanelProgress.Controls.Add((Control)this.ButtonCancel, 0, 0);
      this.TableLayoutPanelProgress.Controls.Add((Control)this.ProgressUpdate, 0, 0);
      this.TableLayoutPanelProgress.Dock = DockStyle.Fill;
      TableLayoutPanel layoutPanelProgress1 = this.TableLayoutPanelProgress;
      point1 = new Point(0, 250);
      Point point4 = point1;
      layoutPanelProgress1.Location = point4;
      TableLayoutPanel layoutPanelProgress2 = this.TableLayoutPanelProgress;
      padding1 = new Padding(0);
      Padding padding4 = padding1;
      layoutPanelProgress2.Margin = padding4;
      this.TableLayoutPanelProgress.Name = "TableLayoutPanelProgress";
      this.TableLayoutPanelProgress.RowCount = 1;
      this.TableLayoutPanelProgress.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      TableLayoutPanel layoutPanelProgress3 = this.TableLayoutPanelProgress;
      size1 = new Size(577, 1);
      Size size4 = size1;
      layoutPanelProgress3.Size = size4;
      this.TableLayoutPanelProgress.TabIndex = 4;
      this.ButtonCancel.BackColor = Color.FromArgb(128, (int)byte.MaxValue, 128);
      this.ButtonCancel.Dock = DockStyle.Fill;
      this.ButtonCancel.FlatStyle = FlatStyle.Flat;
      Button buttonCancel1 = this.ButtonCancel;
      point1 = new Point(527, 0);
      Point point5 = point1;
      buttonCancel1.Location = point5;
      Button buttonCancel2 = this.ButtonCancel;
      padding1 = new Padding(0);
      Padding padding5 = padding1;
      buttonCancel2.Margin = padding5;
      this.ButtonCancel.Name = "ButtonCancel";
      Button buttonCancel3 = this.ButtonCancel;
      size1 = new Size(50, 1);
      Size size5 = size1;
      buttonCancel3.Size = size5;
      this.ButtonCancel.TabIndex = 9;
      this.ButtonCancel.Text = "---";
      this.ButtonCancel.UseVisualStyleBackColor = false;
      this.ProgressUpdate.Dock = DockStyle.Fill;
      ProgressBar progressUpdate1 = this.ProgressUpdate;
      point1 = new Point(0, 0);
      Point point6 = point1;
      progressUpdate1.Location = point6;
      ProgressBar progressUpdate2 = this.ProgressUpdate;
      padding1 = new Padding(0);
      Padding padding6 = padding1;
      progressUpdate2.Margin = padding6;
      this.ProgressUpdate.MarqueeAnimationSpeed = 10;
      this.ProgressUpdate.Name = "ProgressUpdate";
      ProgressBar progressUpdate3 = this.ProgressUpdate;
      size1 = new Size(527, 1);
      Size size6 = size1;
      progressUpdate3.Size = size6;
      this.ProgressUpdate.Style = ProgressBarStyle.Continuous;
      this.ProgressUpdate.TabIndex = 5;
      this.ToolStripMenuBar.BackColor = SystemColors.ControlDark;
      this.ToolStripMenuBar.Dock = DockStyle.Fill;
      this.ToolStripMenuBar.Font = new Font("Verdana", 7f);
      ToolStrip toolStripMenuBar1 = this.ToolStripMenuBar;
      padding1 = new Padding(0);
      Padding padding7 = padding1;
      toolStripMenuBar1.GripMargin = padding7;
      this.ToolStripMenuBar.GripStyle = ToolStripGripStyle.Hidden;
      this.ToolStripMenuBar.Items.AddRange(new ToolStripItem[10]
      {
        (ToolStripItem) this.ToolStripButtonDirectory,
        (ToolStripItem) this.ToolStripFiletypes,
        (ToolStripItem) this.ToolStripThumbsize,
        (ToolStripItem) this.ToolStripDisplayStyle,
        (ToolStripItem) this.ToolStripSort,
        (ToolStripItem) this.ToolStripSearchLabel,
        (ToolStripItem) this.ToolStripButtonIncExc,
        (ToolStripItem) this.TextBoxSearchString,
        (ToolStripItem) this.ToolStripButtonLogic,
        (ToolStripItem) this.ToolStripAbout
      });
      ToolStrip toolStripMenuBar2 = this.ToolStripMenuBar;
      point1 = new Point(0, 0);
      Point point7 = point1;
      toolStripMenuBar2.Location = point7;
      this.ToolStripMenuBar.Name = "ToolStripMenuBar";
      ToolStrip toolStripMenuBar3 = this.ToolStripMenuBar;
      padding1 = new Padding(0);
      Padding padding8 = padding1;
      toolStripMenuBar3.Padding = padding8;
      this.ToolStripMenuBar.RenderMode = ToolStripRenderMode.System;
      ToolStrip toolStripMenuBar4 = this.ToolStripMenuBar;
      size1 = new Size(577, 22);
      Size size7 = size1;
      toolStripMenuBar4.Size = size7;
      this.ToolStripMenuBar.TabIndex = 7;
      this.ToolStripButtonDirectory.DropDownItems.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.ChooseToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator10,
        (ToolStripItem) this.AddFavouriteToolStripMenuItem,
        (ToolStripItem) this.ManageToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator11
      });
      this.ToolStripButtonDirectory.Image = (Image)LoneRobot.UI.My.Resources.Resources.folder;
      this.ToolStripButtonDirectory.ImageAlign = ContentAlignment.MiddleRight;
      this.ToolStripButtonDirectory.ImageScaling = ToolStripItemImageScaling.None;
      this.ToolStripButtonDirectory.ImageTransparentColor = Color.Magenta;
      this.ToolStripButtonDirectory.Name = "ToolStripButtonDirectory";
      ToolStripDropDownButton stripButtonDirectory = this.ToolStripButtonDirectory;
      size1 = new Size(82, 19);
      Size size8 = size1;
      stripButtonDirectory.Size = size8;
      this.ToolStripButtonDirectory.Text = "Directory";
      this.ToolStripButtonDirectory.ToolTipText = "Choose a directory";
      this.ChooseToolStripMenuItem.Name = "ChooseToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem1 = this.ChooseToolStripMenuItem;
      size1 = new Size(165, 22);
      Size size9 = size1;
      toolStripMenuItem1.Size = size9;
      this.ChooseToolStripMenuItem.Text = "Choose...";
      this.ToolStripSeparator10.Name = "ToolStripSeparator10";
      ToolStripSeparator stripSeparator10 = this.ToolStripSeparator10;
      size1 = new Size(162, 6);
      Size size10 = size1;
      stripSeparator10.Size = size10;
      this.AddFavouriteToolStripMenuItem.Name = "AddFavouriteToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem2 = this.AddFavouriteToolStripMenuItem;
      size1 = new Size(165, 22);
      Size size11 = size1;
      toolStripMenuItem2.Size = size11;
      this.AddFavouriteToolStripMenuItem.Text = "Add to favourites";
      this.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem3 = this.ManageToolStripMenuItem;
      size1 = new Size(165, 22);
      Size size12 = size1;
      toolStripMenuItem3.Size = size12;
      this.ManageToolStripMenuItem.Text = "Manage...";
      this.ToolStripSeparator11.Name = "ToolStripSeparator11";
      ToolStripSeparator stripSeparator11 = this.ToolStripSeparator11;
      size1 = new Size(162, 6);
      Size size13 = size1;
      stripSeparator11.Size = size13;
      this.ToolStripFiletypes.AutoSize = false;
      this.ToolStripFiletypes.AutoToolTip = false;
      this.ToolStripFiletypes.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.ToolStripFiletypes.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.ImageTypeToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator7,
        (ToolStripItem) this.OtherTypesToolStripMenuItem1
      });
      this.ToolStripFiletypes.Image = (Image)componentResourceManager.GetObject("ToolStripFiletypes.Image");
      this.ToolStripFiletypes.ImageTransparentColor = Color.Magenta;
      this.ToolStripFiletypes.Name = "ToolStripFiletypes";
      ToolStripDropDownButton toolStripFiletypes = this.ToolStripFiletypes;
      size1 = new Size(70, 19);
      Size size14 = size1;
      toolStripFiletypes.Size = size14;
      this.ToolStripFiletypes.Text = "FileTypes";
      this.ImageTypeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[7]
      {
        (ToolStripItem) this.BmpToolStripMenuItem,
        (ToolStripItem) this.JpgToolStripMenuItem,
        (ToolStripItem) this.PngToolStripMenuItem,
        (ToolStripItem) this.TgaToolStripMenuItem,
        (ToolStripItem) this.TifToolStripMenuItem,
        (ToolStripItem) this.PsdToolStripMenuItem,
        (ToolStripItem) this.RpfToolStripMenuItem
      });
      this.ImageTypeToolStripMenuItem.Name = "ImageTypeToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem4 = this.ImageTypeToolStripMenuItem;
      size1 = new Size(152, 22);
      Size size15 = size1;
      toolStripMenuItem4.Size = size15;
      this.ImageTypeToolStripMenuItem.Text = "Image Types";
      this.BmpToolStripMenuItem.Name = "BmpToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem5 = this.BmpToolStripMenuItem;
      size1 = new Size(106, 22);
      Size size16 = size1;
      toolStripMenuItem5.Size = size16;
      this.BmpToolStripMenuItem.Text = "*.bmp";
      this.JpgToolStripMenuItem.Name = "JpgToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem6 = this.JpgToolStripMenuItem;
      size1 = new Size(106, 22);
      Size size17 = size1;
      toolStripMenuItem6.Size = size17;
      this.JpgToolStripMenuItem.Text = "*.jpg";
      this.PngToolStripMenuItem.Name = "PngToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem7 = this.PngToolStripMenuItem;
      size1 = new Size(106, 22);
      Size size18 = size1;
      toolStripMenuItem7.Size = size18;
      this.PngToolStripMenuItem.Text = "*.png";
      this.TgaToolStripMenuItem.Name = "TgaToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem8 = this.TgaToolStripMenuItem;
      size1 = new Size(106, 22);
      Size size19 = size1;
      toolStripMenuItem8.Size = size19;
      this.TgaToolStripMenuItem.Text = "*.tga";
      this.TifToolStripMenuItem.Name = "TifToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem9 = this.TifToolStripMenuItem;
      size1 = new Size(106, 22);
      Size size20 = size1;
      toolStripMenuItem9.Size = size20;
      this.TifToolStripMenuItem.Text = "*.tif";
      this.PsdToolStripMenuItem.Name = "PsdToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem10 = this.PsdToolStripMenuItem;
      size1 = new Size(106, 22);
      Size size21 = size1;
      toolStripMenuItem10.Size = size21;
      this.PsdToolStripMenuItem.Text = "*.psd";
      this.RpfToolStripMenuItem.Name = "RpfToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem11 = this.RpfToolStripMenuItem;
      size1 = new Size(106, 22);
      Size size22 = size1;
      toolStripMenuItem11.Size = size22;
      this.RpfToolStripMenuItem.Text = "*.rpf";
      this.ToolStripSeparator7.Name = "ToolStripSeparator7";
      ToolStripSeparator toolStripSeparator7 = this.ToolStripSeparator7;
      size1 = new Size(149, 6);
      Size size23 = size1;
      toolStripSeparator7.Size = size23;
      this.OtherTypesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.MaxToolStripMenuItem,
        (ToolStripItem) this.AviToolStripMenuItem,
        (ToolStripItem) this.WavToolStripMenuItem
      });
      this.OtherTypesToolStripMenuItem1.Name = "OtherTypesToolStripMenuItem1";
      ToolStripMenuItem toolStripMenuItem1_1 = this.OtherTypesToolStripMenuItem1;
      size1 = new Size(152, 22);
      Size size24 = size1;
      toolStripMenuItem1_1.Size = size24;
      this.OtherTypesToolStripMenuItem1.Text = "Other Types";
      this.MaxToolStripMenuItem.Name = "MaxToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem12 = this.MaxToolStripMenuItem;
      size1 = new Size(106, 22);
      Size size25 = size1;
      toolStripMenuItem12.Size = size25;
      this.MaxToolStripMenuItem.Text = "*.max";
      this.AviToolStripMenuItem.Name = "AviToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem13 = this.AviToolStripMenuItem;
      size1 = new Size(106, 22);
      Size size26 = size1;
      toolStripMenuItem13.Size = size26;
      this.AviToolStripMenuItem.Text = "*.avi";
      this.WavToolStripMenuItem.Name = "WavToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem14 = this.WavToolStripMenuItem;
      size1 = new Size(106, 22);
      Size size27 = size1;
      toolStripMenuItem14.Size = size27;
      this.WavToolStripMenuItem.Text = "*.wav";
      this.ToolStripThumbsize.AutoSize = false;
      this.ToolStripThumbsize.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ToolStripThumbsize.DropDownItems.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.TinyToolStripMenuItem,
        (ToolStripItem) this.SmallToolStripMenuItem,
        (ToolStripItem) this.MediumToolStripMenuItem,
        (ToolStripItem) this.LargeToolStripMenuItem,
        (ToolStripItem) this.ExtraLargeToolStripMenuItem
      });
      this.ToolStripThumbsize.Font = new Font("Verdana", 7f);
      this.ToolStripThumbsize.Image = (Image)LoneRobot.UI.My.Resources.Resources.seasons;
      this.ToolStripThumbsize.ImageScaling = ToolStripItemImageScaling.None;
      this.ToolStripThumbsize.ImageTransparentColor = Color.Magenta;
      this.ToolStripThumbsize.Name = "ToolStripThumbsize";
      ToolStripDropDownButton toolStripThumbsize = this.ToolStripThumbsize;
      size1 = new Size(34, 19);
      Size size28 = size1;
      toolStripThumbsize.Size = size28;
      this.ToolStripThumbsize.Text = "Thumbs";
      this.ToolStripThumbsize.ToolTipText = "Thumb Size";
      this.TinyToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.TinyToolStripMenuItem.Font = new Font("Verdana", 7f);
      this.TinyToolStripMenuItem.Name = "TinyToolStripMenuItem";
      this.TinyToolStripMenuItem.ShortcutKeyDisplayString = "";
      this.TinyToolStripMenuItem.ShortcutKeys = Keys.T | Keys.Control;
      ToolStripMenuItem toolStripMenuItem15 = this.TinyToolStripMenuItem;
      size1 = new Size(172, 22);
      Size size29 = size1;
      toolStripMenuItem15.Size = size29;
      this.TinyToolStripMenuItem.Text = "Tiny";
      this.SmallToolStripMenuItem.Font = new Font("Verdana", 7f);
      this.SmallToolStripMenuItem.Name = "SmallToolStripMenuItem";
      this.SmallToolStripMenuItem.ShortcutKeys = Keys.S | Keys.Control;
      ToolStripMenuItem toolStripMenuItem16 = this.SmallToolStripMenuItem;
      size1 = new Size(172, 22);
      Size size30 = size1;
      toolStripMenuItem16.Size = size30;
      this.SmallToolStripMenuItem.Text = "Small";
      this.MediumToolStripMenuItem.Font = new Font("Verdana", 7f);
      this.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem";
      this.MediumToolStripMenuItem.ShortcutKeys = Keys.M | Keys.Control;
      ToolStripMenuItem toolStripMenuItem17 = this.MediumToolStripMenuItem;
      size1 = new Size(172, 22);
      Size size31 = size1;
      toolStripMenuItem17.Size = size31;
      this.MediumToolStripMenuItem.Text = "Medium";
      this.LargeToolStripMenuItem.Font = new Font("Verdana", 7f);
      this.LargeToolStripMenuItem.Name = "LargeToolStripMenuItem";
      this.LargeToolStripMenuItem.ShortcutKeys = Keys.L | Keys.Control;
      ToolStripMenuItem toolStripMenuItem18 = this.LargeToolStripMenuItem;
      size1 = new Size(172, 22);
      Size size32 = size1;
      toolStripMenuItem18.Size = size32;
      this.LargeToolStripMenuItem.Text = "Large";
      this.ExtraLargeToolStripMenuItem.Font = new Font("Verdana", 7f);
      this.ExtraLargeToolStripMenuItem.Name = "ExtraLargeToolStripMenuItem";
      this.ExtraLargeToolStripMenuItem.ShortcutKeys = Keys.X | Keys.Control;
      ToolStripMenuItem toolStripMenuItem19 = this.ExtraLargeToolStripMenuItem;
      size1 = new Size(172, 22);
      Size size33 = size1;
      toolStripMenuItem19.Size = size33;
      this.ExtraLargeToolStripMenuItem.Text = "Extra Large";
      this.ToolStripDisplayStyle.AutoToolTip = false;
      this.ToolStripDisplayStyle.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.ToolStripDisplayStyle.DropDownItems.AddRange(new ToolStripItem[10]
      {
        (ToolStripItem) this.ImagesOnlyToolStripMenuItem,
        (ToolStripItem) this.ImagesAndTextToolStripMenuItem,
        (ToolStripItem) this.IconsOnlyToolStripMenuItem,
        (ToolStripItem) this.IconsTextToolStripMenuItem,
        (ToolStripItem) this.TextOnlyToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator8,
        (ToolStripItem) this.ShowDataToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator9,
        (ToolStripItem) this.RefreshToolStripMenuItem,
        (ToolStripItem) this.CacheThumbnailsToolStripMenuItem
      });
      this.ToolStripDisplayStyle.Font = new Font("Verdana", 7f);
      this.ToolStripDisplayStyle.Image = (Image)componentResourceManager.GetObject("ToolStripDisplayStyle.Image");
      this.ToolStripDisplayStyle.ImageTransparentColor = Color.Magenta;
      this.ToolStripDisplayStyle.Name = "ToolStripDisplayStyle";
      ToolStripDropDownButton stripDisplayStyle = this.ToolStripDisplayStyle;
      size1 = new Size(58, 19);
      Size size34 = size1;
      stripDisplayStyle.Size = size34;
      this.ToolStripDisplayStyle.Text = "Display";
      this.ImagesOnlyToolStripMenuItem.Image = (Image)LoneRobot.UI.My.Resources.Resources.image_star;
      this.ImagesOnlyToolStripMenuItem.Name = "ImagesOnlyToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem20 = this.ImagesOnlyToolStripMenuItem;
      size1 = new Size(173, 22);
      Size size35 = size1;
      toolStripMenuItem20.Size = size35;
      this.ImagesOnlyToolStripMenuItem.Text = "Images Only";
      this.ImagesAndTextToolStripMenuItem.Name = "ImagesAndTextToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem21 = this.ImagesAndTextToolStripMenuItem;
      size1 = new Size(173, 22);
      Size size36 = size1;
      toolStripMenuItem21.Size = size36;
      this.ImagesAndTextToolStripMenuItem.Text = "Images + text";
      this.IconsOnlyToolStripMenuItem.Image = (Image)LoneRobot.UI.My.Resources.Resources.border_all;
      this.IconsOnlyToolStripMenuItem.Name = "IconsOnlyToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem22 = this.IconsOnlyToolStripMenuItem;
      size1 = new Size(173, 22);
      Size size37 = size1;
      toolStripMenuItem22.Size = size37;
      this.IconsOnlyToolStripMenuItem.Text = "Icons only";
      this.IconsTextToolStripMenuItem.Name = "IconsTextToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem23 = this.IconsTextToolStripMenuItem;
      size1 = new Size(173, 22);
      Size size38 = size1;
      toolStripMenuItem23.Size = size38;
      this.IconsTextToolStripMenuItem.Text = "Icons + text";
      this.TextOnlyToolStripMenuItem.Image = (Image)LoneRobot.UI.My.Resources.Resources.font_color;
      this.TextOnlyToolStripMenuItem.Name = "TextOnlyToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem24 = this.TextOnlyToolStripMenuItem;
      size1 = new Size(173, 22);
      Size size39 = size1;
      toolStripMenuItem24.Size = size39;
      this.TextOnlyToolStripMenuItem.Text = "Text only";
      this.ToolStripSeparator8.Name = "ToolStripSeparator8";
      ToolStripSeparator toolStripSeparator8 = this.ToolStripSeparator8;
      size1 = new Size(170, 6);
      Size size40 = size1;
      toolStripSeparator8.Size = size40;
      this.ShowDataToolStripMenuItem.CheckOnClick = true;
      this.ShowDataToolStripMenuItem.Name = "ShowDataToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem25 = this.ShowDataToolStripMenuItem;
      size1 = new Size(173, 22);
      Size size41 = size1;
      toolStripMenuItem25.Size = size41;
      this.ShowDataToolStripMenuItem.Text = "Show File Data";
      this.ToolStripSeparator9.Name = "ToolStripSeparator9";
      ToolStripSeparator toolStripSeparator9 = this.ToolStripSeparator9;
      size1 = new Size(170, 6);
      Size size42 = size1;
      toolStripSeparator9.Size = size42;
      this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
      this.RefreshToolStripMenuItem.ShortcutKeys = Keys.F5;
      ToolStripMenuItem toolStripMenuItem26 = this.RefreshToolStripMenuItem;
      size1 = new Size(173, 22);
      Size size43 = size1;
      toolStripMenuItem26.Size = size43;
      this.RefreshToolStripMenuItem.Text = "Refresh";
      this.CacheThumbnailsToolStripMenuItem.CheckOnClick = true;
      this.CacheThumbnailsToolStripMenuItem.Name = "CacheThumbnailsToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem27 = this.CacheThumbnailsToolStripMenuItem;
      size1 = new Size(173, 22);
      Size size44 = size1;
      toolStripMenuItem27.Size = size44;
      this.CacheThumbnailsToolStripMenuItem.Text = "Cache Thumbnails";
      this.ToolStripSort.AutoToolTip = false;
      this.ToolStripSort.BackgroundImageLayout = ImageLayout.None;
      this.ToolStripSort.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.ToolStripSort.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.SortbyNameToolStripMenuItem,
        (ToolStripItem) this.ByFilesizeAscendingMenuItem,
        (ToolStripItem) this.SortByDateToolStripMenuItem
      });
      this.ToolStripSort.Font = new Font("Verdana", 7f);
      this.ToolStripSort.Image = (Image)componentResourceManager.GetObject("ToolStripSort.Image");
      this.ToolStripSort.ImageTransparentColor = Color.Magenta;
      this.ToolStripSort.Name = "ToolStripSort";
      ToolStripDropDownButton toolStripSort = this.ToolStripSort;
      size1 = new Size(40, 19);
      Size size45 = size1;
      toolStripSort.Size = size45;
      this.ToolStripSort.Text = "Sort";
      this.SortbyNameToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("SortbyNameToolStripMenuItem.Image");
      this.SortbyNameToolStripMenuItem.Name = "SortbyNameToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem28 = this.SortbyNameToolStripMenuItem;
      size1 = new Size(152, 22);
      Size size46 = size1;
      toolStripMenuItem28.Size = size46;
      this.SortbyNameToolStripMenuItem.Text = "By Name";
      this.ByFilesizeAscendingMenuItem.Image = (Image)LoneRobot.UI.My.Resources.Resources.sort_filesize;
      this.ByFilesizeAscendingMenuItem.Name = "ByFilesizeAscendingMenuItem";
      ToolStripMenuItem ascendingMenuItem = this.ByFilesizeAscendingMenuItem;
      size1 = new Size(152, 22);
      Size size47 = size1;
      ascendingMenuItem.Size = size47;
      this.ByFilesizeAscendingMenuItem.Text = "By Size";
      this.SortByDateToolStripMenuItem.Image = (Image)LoneRobot.UI.My.Resources.Resources.calendar_16;
      this.SortByDateToolStripMenuItem.Name = "SortByDateToolStripMenuItem";
      ToolStripMenuItem toolStripMenuItem29 = this.SortByDateToolStripMenuItem;
      size1 = new Size(152, 22);
      Size size48 = size1;
      toolStripMenuItem29.Size = size48;
      this.SortByDateToolStripMenuItem.Text = "By Date";
      this.ToolStripSearchLabel.ForeColor = Color.Navy;
      this.ToolStripSearchLabel.Name = "ToolStripSearchLabel";
      ToolStripLabel stripSearchLabel = this.ToolStripSearchLabel;
      size1 = new Size(42, 19);
      Size size49 = size1;
      stripSearchLabel.Size = size49;
      this.ToolStripSearchLabel.Text = "Search";
      this.ToolStripButtonIncExc.AutoSize = false;
      this.ToolStripButtonIncExc.AutoToolTip = false;
      this.ToolStripButtonIncExc.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ToolStripButtonIncExc.Image = (Image)LoneRobot.UI.My.Resources.Resources.globe_16;
      this.ToolStripButtonIncExc.ImageScaling = ToolStripItemImageScaling.None;
      this.ToolStripButtonIncExc.ImageTransparentColor = Color.Magenta;
      this.ToolStripButtonIncExc.Name = "ToolStripButtonIncExc";
      ToolStripButton stripButtonIncExc = this.ToolStripButtonIncExc;
      size1 = new Size(22, 19);
      Size size50 = size1;
      stripButtonIncExc.Size = size50;
      this.ToolStripButtonIncExc.Tag = (object)"FilterNone";
      this.ToolStripButtonIncExc.ToolTipText = "All";
      this.TextBoxSearchString.BackColor = Color.FromArgb(51, 83, 102);
      this.TextBoxSearchString.BorderStyle = BorderStyle.FixedSingle;
      this.TextBoxSearchString.Font = new Font("Verdana", 7f);
      this.TextBoxSearchString.ForeColor = Color.White;
      ToolStripTextBox textBoxSearchString1 = this.TextBoxSearchString;
      padding1 = new Padding(0);
      Padding padding9 = padding1;
      textBoxSearchString1.Margin = padding9;
      this.TextBoxSearchString.Name = "TextBoxSearchString";
      ToolStripTextBox textBoxSearchString2 = this.TextBoxSearchString;
      size1 = new Size(140, 22);
      Size size51 = size1;
      textBoxSearchString2.Size = size51;
      this.TextBoxSearchString.ToolTipText = "Enter text to search filnames for certain parameters";
      this.ToolStripButtonLogic.AutoSize = false;
      this.ToolStripButtonLogic.CheckOnClick = true;
      this.ToolStripButtonLogic.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ToolStripButtonLogic.Image = (Image)componentResourceManager.GetObject("ToolStripButtonLogic.Image");
      this.ToolStripButtonLogic.ImageTransparentColor = Color.Magenta;
      this.ToolStripButtonLogic.Name = "ToolStripButtonLogic";
      ToolStripButton stripButtonLogic = this.ToolStripButtonLogic;
      size1 = new Size(23, 19);
      Size size52 = size1;
      stripButtonLogic.Size = size52;
      this.ToolStripButtonLogic.ToolTipText = "Filenames starting with";
      this.ToolStripAbout.Alignment = ToolStripItemAlignment.Right;
      this.ToolStripAbout.AutoSize = false;
      this.ToolStripAbout.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.ToolStripAbout.ImageScaling = ToolStripItemImageScaling.None;
      this.ToolStripAbout.ImageTransparentColor = Color.Magenta;
      this.ToolStripAbout.Name = "ToolStripAbout";
      ToolStripButton toolStripAbout = this.ToolStripAbout;
      size1 = new Size(22, 19);
      Size size53 = size1;
      toolStripAbout.Size = size53;
      this.ToolStripAbout.Text = "?";
      this.ToolStripAbout.ToolTipText = "About";
      this.SearchForMenu.AutoSize = false;
      this.SearchForMenu.BackColor = SystemColors.Control;
      this.SearchForMenu.Font = new Font("Verdana", 7f);
      this.SearchForMenu.ImeMode = ImeMode.Alpha;
      this.SearchForMenu.Items.AddRange(new ToolStripItem[11]
      {
        (ToolStripItem) this.RefreshMenuItem,
        (ToolStripItem) this.AviMenuItem,
        (ToolStripItem) this.BmpMenuItem,
        (ToolStripItem) this.JpgMenuItem,
        (ToolStripItem) this.PngMenuItem,
        (ToolStripItem) this.PSDMenuItem,
        (ToolStripItem) this.MaxMenuItem,
        (ToolStripItem) this.RpfMenuItem,
        (ToolStripItem) this.TgaMenuItem,
        (ToolStripItem) this.TifMenuItem,
        (ToolStripItem) this.WavMenuItem
      });
      this.SearchForMenu.Name = "SearchForMenu";
      this.SearchForMenu.ShowItemToolTips = false;
      ContextMenuStrip searchForMenu = this.SearchForMenu;
      size1 = new Size(54, 248);
      Size size54 = size1;
      searchForMenu.Size = size54;
      this.RefreshMenuItem.AutoSize = false;
      this.RefreshMenuItem.BackgroundImageLayout = ImageLayout.Center;
      this.RefreshMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.RefreshMenuItem.Image = (Image)LoneRobot.UI.My.Resources.Resources.refresh;
      this.RefreshMenuItem.ImageScaling = ToolStripItemImageScaling.None;
      this.RefreshMenuItem.Name = "RefreshMenuItem";
      ToolStripMenuItem refreshMenuItem = this.RefreshMenuItem;
      size1 = new Size(54, 22);
      Size size55 = size1;
      refreshMenuItem.Size = size55;
      this.RefreshMenuItem.ToolTipText = "Shift-Click to overwrite thumbnail cache";
      this.AviMenuItem.AutoSize = false;
      this.AviMenuItem.Image = (Image)LoneRobot.UI.My.Resources.Resources.avi;
      this.AviMenuItem.ImageScaling = ToolStripItemImageScaling.None;
      this.AviMenuItem.Name = "AviMenuItem";
      ToolStripMenuItem aviMenuItem = this.AviMenuItem;
      size1 = new Size(54, 22);
      Size size56 = size1;
      aviMenuItem.Size = size56;
      this.BmpMenuItem.AutoSize = false;
      this.BmpMenuItem.CheckOnClick = true;
      this.BmpMenuItem.Image = (Image)LoneRobot.UI.My.Resources.Resources.bmp;
      this.BmpMenuItem.ImageScaling = ToolStripItemImageScaling.None;
      this.BmpMenuItem.Name = "BmpMenuItem";
      ToolStripMenuItem bmpMenuItem = this.BmpMenuItem;
      size1 = new Size(54, 22);
      Size size57 = size1;
      bmpMenuItem.Size = size57;
      this.JpgMenuItem.AutoSize = false;
      this.JpgMenuItem.CheckOnClick = true;
      this.JpgMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.JpgMenuItem.Font = new Font("Verdana", 9f);
      this.JpgMenuItem.Image = (Image)LoneRobot.UI.My.Resources.Resources.jpg;
      this.JpgMenuItem.ImageAlign = ContentAlignment.TopLeft;
      this.JpgMenuItem.ImageScaling = ToolStripItemImageScaling.None;
      this.JpgMenuItem.Name = "JpgMenuItem";
      ToolStripMenuItem jpgMenuItem = this.JpgMenuItem;
      size1 = new Size(54, 22);
      Size size58 = size1;
      jpgMenuItem.Size = size58;
      this.PngMenuItem.AutoSize = false;
      this.PngMenuItem.CheckOnClick = true;
      this.PngMenuItem.Image = (Image)LoneRobot.UI.My.Resources.Resources.png;
      this.PngMenuItem.ImageScaling = ToolStripItemImageScaling.None;
      this.PngMenuItem.Name = "PngMenuItem";
      ToolStripMenuItem pngMenuItem = this.PngMenuItem;
      size1 = new Size(54, 22);
      Size size59 = size1;
      pngMenuItem.Size = size59;
      this.PSDMenuItem.AutoSize = false;
      this.PSDMenuItem.Image = (Image)LoneRobot.UI.My.Resources.Resources.psd;
      this.PSDMenuItem.ImageScaling = ToolStripItemImageScaling.None;
      this.PSDMenuItem.Name = "PSDMenuItem";
      ToolStripMenuItem psdMenuItem = this.PSDMenuItem;
      size1 = new Size(54, 22);
      Size size60 = size1;
      psdMenuItem.Size = size60;
      this.PSDMenuItem.Text = "PSDMenuItem";
      this.MaxMenuItem.AutoSize = false;
      this.MaxMenuItem.Image = (Image)LoneRobot.UI.My.Resources.Resources.max;
      this.MaxMenuItem.ImageScaling = ToolStripItemImageScaling.None;
      this.MaxMenuItem.Name = "MaxMenuItem";
      ToolStripMenuItem maxMenuItem = this.MaxMenuItem;
      size1 = new Size(54, 22);
      Size size61 = size1;
      maxMenuItem.Size = size61;
      this.MaxMenuItem.Text = "PSDMenuItem";
      this.RpfMenuItem.AutoSize = false;
      this.RpfMenuItem.CheckOnClick = true;
      this.RpfMenuItem.Image = (Image)LoneRobot.UI.My.Resources.Resources.rpf;
      this.RpfMenuItem.ImageScaling = ToolStripItemImageScaling.None;
      this.RpfMenuItem.Name = "RpfMenuItem";
      ToolStripMenuItem rpfMenuItem = this.RpfMenuItem;
      size1 = new Size(54, 22);
      Size size62 = size1;
      rpfMenuItem.Size = size62;
      this.TgaMenuItem.AutoSize = false;
      this.TgaMenuItem.CheckOnClick = true;
      this.TgaMenuItem.Image = (Image)LoneRobot.UI.My.Resources.Resources.tga;
      this.TgaMenuItem.ImageScaling = ToolStripItemImageScaling.None;
      this.TgaMenuItem.Name = "TgaMenuItem";
      ToolStripMenuItem tgaMenuItem = this.TgaMenuItem;
      size1 = new Size(54, 22);
      Size size63 = size1;
      tgaMenuItem.Size = size63;
      this.TifMenuItem.AutoSize = false;
      this.TifMenuItem.CheckOnClick = true;
      this.TifMenuItem.Image = (Image)LoneRobot.UI.My.Resources.Resources.tiff;
      this.TifMenuItem.ImageScaling = ToolStripItemImageScaling.None;
      this.TifMenuItem.Name = "TifMenuItem";
      ToolStripMenuItem tifMenuItem = this.TifMenuItem;
      size1 = new Size(54, 22);
      Size size64 = size1;
      tifMenuItem.Size = size64;
      this.WavMenuItem.AutoSize = false;
      this.WavMenuItem.Image = (Image)LoneRobot.UI.My.Resources.Resources.wav;
      this.WavMenuItem.ImageScaling = ToolStripItemImageScaling.None;
      this.WavMenuItem.Name = "WavMenuItem";
      ToolStripMenuItem wavMenuItem = this.WavMenuItem;
      size1 = new Size(54, 22);
      Size size65 = size1;
      wavMenuItem.Size = size65;
      this.WavMenuItem.Text = "ToolStripMenuItem1";
      this.FileToolTip.AutomaticDelay = 2000;
      this.FileToolTip.AutoPopDelay = 20000;
      this.FileToolTip.BackColor = SystemColors.Control;
      this.FileToolTip.InitialDelay = 500;
      this.FileToolTip.OwnerDraw = true;
      this.FileToolTip.ReshowDelay = 200;
      this.FileToolTip.ToolTipTitle = "Info";
      this.MaxThreadWorker.Synchronizer = (ISynchronizeInvoke)null;
      ((BackgroundWorker)this.MaxThreadWorker).WorkerReportsProgress = true;
      ((BackgroundWorker)this.MaxThreadWorker).WorkerSupportsCancellation = true;
      this.MenuToolTip.AutoPopDelay = 5000;
      this.MenuToolTip.InitialDelay = 500;
      this.MenuToolTip.ReshowDelay = 100;
      ((ContainerControl)this).AutoScaleDimensions = new SizeF(6f, 13f);
      ((ContainerControl)this).AutoScaleMode = AutoScaleMode.Font;
      ((Control)this).Controls.Add((Control)this.TableLayoutPanelUC);
      padding1 = new Padding(0);
      ((Control)this).Margin = padding1;
      ((Control)this).Name = nameof(HitchHiker);
      size1 = new Size(577, 250);
      ((Control)this).Size = size1;
      this.TableLayoutPanelUC.ResumeLayout(false);
      this.TableLayoutPanelUC.PerformLayout();
      this.TableLayoutPanelProgress.ResumeLayout(false);
      this.ToolStripMenuBar.ResumeLayout(false);
      this.ToolStripMenuBar.PerformLayout();
      this.SearchForMenu.ResumeLayout(false);
      ((Control)this).ResumeLayout(false);
    }

    internal virtual FlowLayoutPanel ThumbBoard
    {
      [DebuggerNonUserCode]
      get => this._ThumbBoard;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.Dashboard_MouseUp);
        if (this._ThumbBoard != null)
          this._ThumbBoard.MouseUp -= mouseEventHandler;
        this._ThumbBoard = value;
        if (this._ThumbBoard == null)
          return;
        this._ThumbBoard.MouseUp += mouseEventHandler;
      }
    }

    internal virtual TableLayoutPanel TableLayoutPanelUC
    {
      [DebuggerNonUserCode]
      get => this._TableLayoutPanelUC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._TableLayoutPanelUC = value;
    }

    internal virtual ToolTip FileToolTip
    {
      [DebuggerNonUserCode]
      get => this._FileToolTip;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        DrawToolTipEventHandler toolTipEventHandler = new DrawToolTipEventHandler(this.FileToolTip_Draw);
        if (this._FileToolTip != null)
          this._FileToolTip.Draw -= toolTipEventHandler;
        this._FileToolTip = value;
        if (this._FileToolTip == null)
          return;
        this._FileToolTip.Draw += toolTipEventHandler;
      }
    }

    internal virtual TableLayoutPanel TableLayoutPanelProgress
    {
      [DebuggerNonUserCode]
      get => this._TableLayoutPanelProgress;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._TableLayoutPanelProgress = value;
    }

    internal virtual Button ButtonCancel
    {
      [DebuggerNonUserCode]
      get => this._ButtonCancel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonCancel_Click);
        if (this._ButtonCancel != null)
          this._ButtonCancel.Click -= eventHandler;
        this._ButtonCancel = value;
        if (this._ButtonCancel == null)
          return;
        this._ButtonCancel.Click += eventHandler;
      }
    }

    internal virtual ProgressBar ProgressUpdate
    {
      [DebuggerNonUserCode]
      get => this._ProgressUpdate;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._ProgressUpdate = value;
    }

    internal virtual SynchronizingBackgroundWorker MaxThreadWorker
    {
      [DebuggerNonUserCode]
      get => this._MaxThreadWorker;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        ProgressChangedEventHandler changedEventHandler = new ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.MaxThreadWorker_DoWork);
        if (this._MaxThreadWorker != null)
        {
          ((BackgroundWorker)this._MaxThreadWorker).ProgressChanged -= changedEventHandler;
          ((BackgroundWorker)this._MaxThreadWorker).RunWorkerCompleted -= completedEventHandler;
          ((BackgroundWorker)this._MaxThreadWorker).DoWork -= workEventHandler;
        }
        this._MaxThreadWorker = value;
        if (this._MaxThreadWorker == null)
          return;
        ((BackgroundWorker)this._MaxThreadWorker).ProgressChanged += changedEventHandler;
        ((BackgroundWorker)this._MaxThreadWorker).RunWorkerCompleted += completedEventHandler;
        ((BackgroundWorker)this._MaxThreadWorker).DoWork += workEventHandler;
      }
    }

    internal virtual ToolStripMenuItem RefreshMenuItem
    {
      [DebuggerNonUserCode]
      get => this._RefreshMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.RefreshMenuItem_Click);
        if (this._RefreshMenuItem != null)
          this._RefreshMenuItem.Click -= eventHandler;
        this._RefreshMenuItem = value;
        if (this._RefreshMenuItem == null)
          return;
        this._RefreshMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem JpgMenuItem
    {
      [DebuggerNonUserCode]
      get => this._JpgMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.JpgToolStripMenuItem_Click);
        if (this._JpgMenuItem != null)
          this._JpgMenuItem.Click -= eventHandler;
        this._JpgMenuItem = value;
        if (this._JpgMenuItem == null)
          return;
        this._JpgMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem BmpMenuItem
    {
      [DebuggerNonUserCode]
      get => this._BmpMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.BmpToolStripMenuItem_Click);
        if (this._BmpMenuItem != null)
          this._BmpMenuItem.Click -= eventHandler;
        this._BmpMenuItem = value;
        if (this._BmpMenuItem == null)
          return;
        this._BmpMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem TifMenuItem
    {
      [DebuggerNonUserCode]
      get => this._TifMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.TifToolStripMenuItem_Click);
        if (this._TifMenuItem != null)
          this._TifMenuItem.Click -= eventHandler;
        this._TifMenuItem = value;
        if (this._TifMenuItem == null)
          return;
        this._TifMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem PngMenuItem
    {
      [DebuggerNonUserCode]
      get => this._PngMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.PngToolStripMenuItem_Click);
        if (this._PngMenuItem != null)
          this._PngMenuItem.Click -= eventHandler;
        this._PngMenuItem = value;
        if (this._PngMenuItem == null)
          return;
        this._PngMenuItem.Click += eventHandler;
      }
    }

    internal virtual ContextMenuStrip SearchForMenu
    {
      [DebuggerNonUserCode]
      get => this._SearchForMenu;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._SearchForMenu = value;
    }

    internal virtual FolderBrowserDialog PickDirectory
    {
      [DebuggerNonUserCode]
      get => this._PickDirectory;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._PickDirectory = value;
    }

    internal virtual ToolStripMenuItem RpfMenuItem
    {
      [DebuggerNonUserCode]
      get => this._RpfMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.RpfMenuItem_Click);
        if (this._RpfMenuItem != null)
          this._RpfMenuItem.Click -= eventHandler;
        this._RpfMenuItem = value;
        if (this._RpfMenuItem == null)
          return;
        this._RpfMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem TgaMenuItem
    {
      [DebuggerNonUserCode]
      get => this._TgaMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.TgaMenuItem_Click);
        if (this._TgaMenuItem != null)
          this._TgaMenuItem.Click -= eventHandler;
        this._TgaMenuItem = value;
        if (this._TgaMenuItem == null)
          return;
        this._TgaMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem AviMenuItem
    {
      [DebuggerNonUserCode]
      get => this._AviMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.AviMenuItem_Click);
        if (this._AviMenuItem != null)
          this._AviMenuItem.Click -= eventHandler;
        this._AviMenuItem = value;
        if (this._AviMenuItem == null)
          return;
        this._AviMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem WavMenuItem
    {
      [DebuggerNonUserCode]
      get => this._WavMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.WavMenuItem_Click);
        if (this._WavMenuItem != null)
          this._WavMenuItem.Click -= eventHandler;
        this._WavMenuItem = value;
        if (this._WavMenuItem == null)
          return;
        this._WavMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem PSDMenuItem
    {
      [DebuggerNonUserCode]
      get => this._PSDMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.PSDMenuItem_Click);
        if (this._PSDMenuItem != null)
          this._PSDMenuItem.Click -= eventHandler;
        this._PSDMenuItem = value;
        if (this._PSDMenuItem == null)
          return;
        this._PSDMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem MaxMenuItem
    {
      [DebuggerNonUserCode]
      get => this._MaxMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.MaxMenuItem_Click);
        if (this._MaxMenuItem != null)
          this._MaxMenuItem.Click -= eventHandler;
        this._MaxMenuItem = value;
        if (this._MaxMenuItem == null)
          return;
        this._MaxMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolTip MenuToolTip
    {
      [DebuggerNonUserCode]
      get => this._MenuToolTip;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._MenuToolTip = value;
    }

    internal virtual ToolStrip ToolStripMenuBar
    {
      [DebuggerNonUserCode]
      get => this._ToolStripMenuBar;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._ToolStripMenuBar = value;
    }

    internal virtual ToolStripButton ToolStripButtonIncExc
    {
      [DebuggerNonUserCode]
      get => this._ToolStripButtonIncExc;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripButtonIncExc_CheckedChanged);
        if (this._ToolStripButtonIncExc != null)
          this._ToolStripButtonIncExc.Click -= eventHandler;
        this._ToolStripButtonIncExc = value;
        if (this._ToolStripButtonIncExc == null)
          return;
        this._ToolStripButtonIncExc.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton ToolStripButtonLogic
    {
      [DebuggerNonUserCode]
      get => this._ToolStripButtonLogic;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripButtonLogic_CheckedChanged);
        if (this._ToolStripButtonLogic != null)
          this._ToolStripButtonLogic.CheckedChanged -= eventHandler;
        this._ToolStripButtonLogic = value;
        if (this._ToolStripButtonLogic == null)
          return;
        this._ToolStripButtonLogic.CheckedChanged += eventHandler;
      }
    }

    internal virtual ToolStripTextBox TextBoxSearchString
    {
      [DebuggerNonUserCode]
      get => this._TextBoxSearchString;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler1 = new EventHandler(this.TextBoxSearchString_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.TextString_FocusLost);
        EventHandler eventHandler3 = new EventHandler(this.TextString_Focus);
        if (this._TextBoxSearchString != null)
        {
          this._TextBoxSearchString.TextChanged -= eventHandler1;
          this._TextBoxSearchString.LostFocus -= eventHandler2;
          this._TextBoxSearchString.GotFocus -= eventHandler3;
        }
        this._TextBoxSearchString = value;
        if (this._TextBoxSearchString == null)
          return;
        this._TextBoxSearchString.TextChanged += eventHandler1;
        this._TextBoxSearchString.LostFocus += eventHandler2;
        this._TextBoxSearchString.GotFocus += eventHandler3;
      }
    }

    internal virtual ToolStripDropDownButton ToolStripFiletypes
    {
      [DebuggerNonUserCode]
      get => this._ToolStripFiletypes;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._ToolStripFiletypes = value;
    }

    internal virtual ToolStripDropDownButton ToolStripThumbsize
    {
      [DebuggerNonUserCode]
      get => this._ToolStripThumbsize;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._ToolStripThumbsize = value;
    }

    internal virtual ToolStripMenuItem TinyToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._TinyToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.TinyToolStripMenuItem_Click);
        if (this._TinyToolStripMenuItem != null)
          this._TinyToolStripMenuItem.Click -= eventHandler;
        this._TinyToolStripMenuItem = value;
        if (this._TinyToolStripMenuItem == null)
          return;
        this._TinyToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem SmallToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._SmallToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.SmallToolStripMenuItem_Click);
        if (this._SmallToolStripMenuItem != null)
          this._SmallToolStripMenuItem.Click -= eventHandler;
        this._SmallToolStripMenuItem = value;
        if (this._SmallToolStripMenuItem == null)
          return;
        this._SmallToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem MediumToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._MediumToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.MediumToolStripMenuItem_Click);
        if (this._MediumToolStripMenuItem != null)
          this._MediumToolStripMenuItem.Click -= eventHandler;
        this._MediumToolStripMenuItem = value;
        if (this._MediumToolStripMenuItem == null)
          return;
        this._MediumToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem LargeToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._LargeToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.LargeToolStripMenuItem_Click);
        if (this._LargeToolStripMenuItem != null)
          this._LargeToolStripMenuItem.Click -= eventHandler;
        this._LargeToolStripMenuItem = value;
        if (this._LargeToolStripMenuItem == null)
          return;
        this._LargeToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem ExtraLargeToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._ExtraLargeToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.ExtraLargeToolStripMenuItem_Click);
        if (this._ExtraLargeToolStripMenuItem != null)
          this._ExtraLargeToolStripMenuItem.Click -= eventHandler;
        this._ExtraLargeToolStripMenuItem = value;
        if (this._ExtraLargeToolStripMenuItem == null)
          return;
        this._ExtraLargeToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripDropDownButton ToolStripDisplayStyle
    {
      [DebuggerNonUserCode]
      get => this._ToolStripDisplayStyle;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._ToolStripDisplayStyle = value;
    }

    internal virtual ToolStripMenuItem ImagesOnlyToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._ImagesOnlyToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.ImagesOnlyToolStripMenuItem_Click);
        if (this._ImagesOnlyToolStripMenuItem != null)
          this._ImagesOnlyToolStripMenuItem.Click -= eventHandler;
        this._ImagesOnlyToolStripMenuItem = value;
        if (this._ImagesOnlyToolStripMenuItem == null)
          return;
        this._ImagesOnlyToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem ImagesAndTextToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._ImagesAndTextToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.ImagesAndTextToolStripMenuItem_Click);
        if (this._ImagesAndTextToolStripMenuItem != null)
          this._ImagesAndTextToolStripMenuItem.Click -= eventHandler;
        this._ImagesAndTextToolStripMenuItem = value;
        if (this._ImagesAndTextToolStripMenuItem == null)
          return;
        this._ImagesAndTextToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem IconsOnlyToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._IconsOnlyToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.IconsOnlyToolStripMenuItem_Click);
        if (this._IconsOnlyToolStripMenuItem != null)
          this._IconsOnlyToolStripMenuItem.Click -= eventHandler;
        this._IconsOnlyToolStripMenuItem = value;
        if (this._IconsOnlyToolStripMenuItem == null)
          return;
        this._IconsOnlyToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem IconsTextToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._IconsTextToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.IconsTextToolStripMenuItem_Click);
        if (this._IconsTextToolStripMenuItem != null)
          this._IconsTextToolStripMenuItem.Click -= eventHandler;
        this._IconsTextToolStripMenuItem = value;
        if (this._IconsTextToolStripMenuItem == null)
          return;
        this._IconsTextToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem TextOnlyToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._TextOnlyToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.TextOnlyToolStripMenuItem_Click);
        if (this._TextOnlyToolStripMenuItem != null)
          this._TextOnlyToolStripMenuItem.Click -= eventHandler;
        this._TextOnlyToolStripMenuItem = value;
        if (this._TextOnlyToolStripMenuItem == null)
          return;
        this._TextOnlyToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripDropDownButton ToolStripSort
    {
      [DebuggerNonUserCode]
      get => this._ToolStripSort;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._ToolStripSort = value;
    }

    internal virtual ToolStripMenuItem SortbyNameToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._SortbyNameToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.SortbyFilenameToolStripMenuItem_Click);
        if (this._SortbyNameToolStripMenuItem != null)
          this._SortbyNameToolStripMenuItem.Click -= eventHandler;
        this._SortbyNameToolStripMenuItem = value;
        if (this._SortbyNameToolStripMenuItem == null)
          return;
        this._SortbyNameToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem ByFilesizeAscendingMenuItem
    {
      [DebuggerNonUserCode]
      get => this._ByFilesizeAscendingMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.SortByFilesizeAscendingToolStripMenuItem_Click);
        if (this._ByFilesizeAscendingMenuItem != null)
          this._ByFilesizeAscendingMenuItem.Click -= eventHandler;
        this._ByFilesizeAscendingMenuItem = value;
        if (this._ByFilesizeAscendingMenuItem == null)
          return;
        this._ByFilesizeAscendingMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem SortByDateToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._SortByDateToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.SortByDateToolStripMenuItem_Click);
        if (this._SortByDateToolStripMenuItem != null)
          this._SortByDateToolStripMenuItem.Click -= eventHandler;
        this._SortByDateToolStripMenuItem = value;
        if (this._SortByDateToolStripMenuItem == null)
          return;
        this._SortByDateToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripLabel ToolStripSearchLabel
    {
      [DebuggerNonUserCode]
      get => this._ToolStripSearchLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._ToolStripSearchLabel = value;
    }

    internal virtual ToolStripButton ToolStripAbout
    {
      [DebuggerNonUserCode]
      get => this._ToolStripAbout;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripAbout_Click);
        if (this._ToolStripAbout != null)
          this._ToolStripAbout.Click -= eventHandler;
        this._ToolStripAbout = value;
        if (this._ToolStripAbout == null)
          return;
        this._ToolStripAbout.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem ShowDataToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._ShowDataToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.ShowDataToolStripMenuItem_CheckedChanged);
        if (this._ShowDataToolStripMenuItem != null)
          this._ShowDataToolStripMenuItem.CheckedChanged -= eventHandler;
        this._ShowDataToolStripMenuItem = value;
        if (this._ShowDataToolStripMenuItem == null)
          return;
        this._ShowDataToolStripMenuItem.CheckedChanged += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem ImageTypeToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._ImageTypeToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._ImageTypeToolStripMenuItem = value;
    }

    internal virtual ToolStripMenuItem RefreshToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._RefreshToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.RefreshMenuItem_Click);
        if (this._RefreshToolStripMenuItem != null)
          this._RefreshToolStripMenuItem.Click -= eventHandler;
        this._RefreshToolStripMenuItem = value;
        if (this._RefreshToolStripMenuItem == null)
          return;
        this._RefreshToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem BmpToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._BmpToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.BmpToolStripMenuItem_Click);
        if (this._BmpToolStripMenuItem != null)
          this._BmpToolStripMenuItem.Click -= eventHandler;
        this._BmpToolStripMenuItem = value;
        if (this._BmpToolStripMenuItem == null)
          return;
        this._BmpToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem JpgToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._JpgToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.JpgToolStripMenuItem_Click);
        if (this._JpgToolStripMenuItem != null)
          this._JpgToolStripMenuItem.Click -= eventHandler;
        this._JpgToolStripMenuItem = value;
        if (this._JpgToolStripMenuItem == null)
          return;
        this._JpgToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem PngToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._PngToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.PngToolStripMenuItem_Click);
        if (this._PngToolStripMenuItem != null)
          this._PngToolStripMenuItem.Click -= eventHandler;
        this._PngToolStripMenuItem = value;
        if (this._PngToolStripMenuItem == null)
          return;
        this._PngToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem TgaToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._TgaToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.TgaMenuItem_Click);
        if (this._TgaToolStripMenuItem != null)
          this._TgaToolStripMenuItem.Click -= eventHandler;
        this._TgaToolStripMenuItem = value;
        if (this._TgaToolStripMenuItem == null)
          return;
        this._TgaToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem TifToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._TifToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.TifToolStripMenuItem_Click);
        if (this._TifToolStripMenuItem != null)
          this._TifToolStripMenuItem.Click -= eventHandler;
        this._TifToolStripMenuItem = value;
        if (this._TifToolStripMenuItem == null)
          return;
        this._TifToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem PsdToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._PsdToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.PSDMenuItem_Click);
        if (this._PsdToolStripMenuItem != null)
          this._PsdToolStripMenuItem.Click -= eventHandler;
        this._PsdToolStripMenuItem = value;
        if (this._PsdToolStripMenuItem == null)
          return;
        this._PsdToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem RpfToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._RpfToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.RpfMenuItem_Click);
        if (this._RpfToolStripMenuItem != null)
          this._RpfToolStripMenuItem.Click -= eventHandler;
        this._RpfToolStripMenuItem = value;
        if (this._RpfToolStripMenuItem == null)
          return;
        this._RpfToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripSeparator ToolStripSeparator7
    {
      [DebuggerNonUserCode]
      get => this._ToolStripSeparator7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._ToolStripSeparator7 = value;
    }

    internal virtual ToolStripMenuItem OtherTypesToolStripMenuItem1
    {
      [DebuggerNonUserCode]
      get => this._OtherTypesToolStripMenuItem1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._OtherTypesToolStripMenuItem1 = value;
    }

    internal virtual ToolStripMenuItem MaxToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._MaxToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.MaxMenuItem_Click);
        if (this._MaxToolStripMenuItem != null)
          this._MaxToolStripMenuItem.Click -= eventHandler;
        this._MaxToolStripMenuItem = value;
        if (this._MaxToolStripMenuItem == null)
          return;
        this._MaxToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem AviToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._AviToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.AviMenuItem_Click);
        if (this._AviToolStripMenuItem != null)
          this._AviToolStripMenuItem.Click -= eventHandler;
        this._AviToolStripMenuItem = value;
        if (this._AviToolStripMenuItem == null)
          return;
        this._AviToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem WavToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._WavToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.WavMenuItem_Click);
        if (this._WavToolStripMenuItem != null)
          this._WavToolStripMenuItem.Click -= eventHandler;
        this._WavToolStripMenuItem = value;
        if (this._WavToolStripMenuItem == null)
          return;
        this._WavToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripSeparator ToolStripSeparator8
    {
      [DebuggerNonUserCode]
      get => this._ToolStripSeparator8;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._ToolStripSeparator8 = value;
    }

    internal virtual ToolStripSeparator ToolStripSeparator9
    {
      [DebuggerNonUserCode]
      get => this._ToolStripSeparator9;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._ToolStripSeparator9 = value;
    }

    internal virtual ToolStripDropDownButton ToolStripButtonDirectory
    {
      [DebuggerNonUserCode]
      get => this._ToolStripButtonDirectory;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._ToolStripButtonDirectory = value;
    }

    internal virtual ToolStripMenuItem ChooseToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._ChooseToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonPickDirectory_Click);
        if (this._ChooseToolStripMenuItem != null)
          this._ChooseToolStripMenuItem.Click -= eventHandler;
        this._ChooseToolStripMenuItem = value;
        if (this._ChooseToolStripMenuItem == null)
          return;
        this._ChooseToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripSeparator ToolStripSeparator10
    {
      [DebuggerNonUserCode]
      get => this._ToolStripSeparator10;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._ToolStripSeparator10 = value;
    }

    internal virtual ToolStripMenuItem AddFavouriteToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._AddFavouriteToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.AddFavouriteToolStripMenuItem_Click);
        if (this._AddFavouriteToolStripMenuItem != null)
          this._AddFavouriteToolStripMenuItem.Click -= eventHandler;
        this._AddFavouriteToolStripMenuItem = value;
        if (this._AddFavouriteToolStripMenuItem == null)
          return;
        this._AddFavouriteToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripSeparator ToolStripSeparator11
    {
      [DebuggerNonUserCode]
      get => this._ToolStripSeparator11;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set => this._ToolStripSeparator11 = value;
    }

    internal virtual ToolStripMenuItem ManageToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._ManageToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.ManageToolStripMenuItem_Click);
        if (this._ManageToolStripMenuItem != null)
          this._ManageToolStripMenuItem.Click -= eventHandler;
        this._ManageToolStripMenuItem = value;
        if (this._ManageToolStripMenuItem == null)
          return;
        this._ManageToolStripMenuItem.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem CacheThumbnailsToolStripMenuItem
    {
      [DebuggerNonUserCode]
      get => this._CacheThumbnailsToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        EventHandler eventHandler = new EventHandler(this.CacheThumbnailsToolStripMenuItem_CheckedChanged);
        if (this._CacheThumbnailsToolStripMenuItem != null)
          this._CacheThumbnailsToolStripMenuItem.CheckedChanged -= eventHandler;
        this._CacheThumbnailsToolStripMenuItem = value;
        if (this._CacheThumbnailsToolStripMenuItem == null)
          return;
        this._CacheThumbnailsToolStripMenuItem.CheckedChanged += eventHandler;
      }
    }

    public event HitchHiker.ThumbPickedEventHandler ThumbPicked;

    public HitchHiker()
    {
      this._directory = "";
      this._ShowMenu = true;
      this._FullMenu = true;
      this._SelectedHighLight = Color.Yellow;
      this._SelectedBorderWidth = 4;
      this._ThumbPanelBackColor = Color.Gray;
      this._ShowTooltips = true;
      this._padding = 1;
      this._ImageFormatsOnly = true;
      this._DisplayStyle = HitchHiker.DisplayStyles.Images;
      this._TextAlign = ContentAlignment.BottomCenter;
      this._ImageAlign = ContentAlignment.MiddleCenter;
      this._filetype = HitchHiker.filetypes.jpg;
      this._Thumbsize = new Size(70, 70);
      this.images = new List<NamedImage>();
      this._sortby = HitchHiker.SortByOptions.FileNameAscending;
      this._ThumbInterpolation = InterpolationMode.High;
      this._ReturnImageInterpolation = InterpolationMode.HighQualityBilinear;
      this._ShowToolbar = true;
      this._CurrentImageWidth = 0;
      this._CurrentImageHeight = 0;
      this._CurrentImageSize = (string)null;
      this._ButtonBackColor = SystemColors.Control;
      this._binglybongly = false;
      this.randomGenerator = new Random();
      this._RecursiveSearch = false;
      this._ButtonBorder = true;
      this.RightClickMenu = (object)new ContextMenuStrip();
      this.MenuItem1 = new ToolStripMenuItem();
      this.MenuItem2 = new ToolStripMenuItem();
      this.MenuItem3 = new ToolStripMenuItem();
      this.MenuItem4 = new ToolStripSeparator();
      this.MenuItem5 = new ToolStripMenuItem();
      this.MaxRightClickMenu = (object)new ContextMenuStrip();
      this.MaxMenuItem1 = new ToolStripMenuItem();
      this.MaxMenuItem2 = new ToolStripMenuItem();
      this.MaxMenuItem3 = new ToolStripSeparator();
      this.MaxMenuItem4 = new ToolStripMenuItem();
      this.AbortMaxLoadProcess = false;
      this._RenderThumbsize = 2;
      this._UseCustomBG = false;
      this._CustomBGColor = Color.White;
      this._Capture = false;
      this._SaveAlpha = true;
      this._RenderThumbsizeSmall = 50;
      this._RenderThumbsizeMedium = 90;
      this._RenderThumbsizeLarge = 150;
      this._ShowFileDataOnButton = false;
      this._CacheState = HitchHiker.CacheState.Realtime;
      this._PurgeCache = false;
      this._PopulateFilterPattern = (string)null;
      this._PopulateFilterLogic = HitchHiker.PopulateFilterLogic.All;
      this._PopulateFilterSearch = HitchHiker.PopulateFilterSearch.StartingWith;
      this.HHFont = new Font("Verdana", 7f, FontStyle.Bold);
      this.ScriptPath = PathSDK.GetDirectoryPath((PathSDK.DirectoryID)15) + "\\LoneRobot\\Assets\\HitchHiker";
      this._BypassCacheFolderWarning = false;
      this.InitializeComponent();
      this.Colorman = CuiUpdater.GetInstance();
      if (!MyProject.Computer.FileSystem.DirectoryExists(this.ScriptPath))
        MyProject.Computer.FileSystem.CreateDirectory(this.ScriptPath);
      this.ToolStripMenuBar.Renderer = (ToolStripRenderer)new BorderlessToolStripRenderer();
      this.ShowToolbar = false;
      this.Filetype = HitchHiker.filetypes.jpg;
      this.Thumbnails = HitchHiker.ThumbNailSize.Medium;
      try
      {
        Color controlColor = this.Colorman.GetControlColor();
        this.FileToolTip.BackColor = controlColor;
        this.ToolStripMenuBar.BackColor = controlColor;
        ((Control)this).BackColor = controlColor;
        Color textColor = this.Colorman.GetTextColor();
        ((Control)this).ForeColor = textColor;
        this.FileToolTip.ForeColor = textColor;
        this.ToolStripMenuBar.ForeColor = textColor;
        this.ThumbInterpMode = HitchHiker.Interpolation.Bilinear;
        this.EvaluateMaxImageIO();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.MenuItem1.Name = nameof(MenuItem1);
      ToolStripMenuItem menuItem1 = this.MenuItem1;
      Size size1 = new Size(100, 22);
      Size size2 = size1;
      menuItem1.Size = size2;
      this.MenuItem1.Text = "Render Thumbnail";
      this.MenuItem1.Image = (Image)LoneRobot.UI.My.Resources.Resources.pictures_thumbs16;
      this.MenuItem1.Click += new EventHandler(this.MenuHandler);
      this.MenuItem2.Name = nameof(MenuItem2);
      ToolStripMenuItem menuItem2 = this.MenuItem2;
      size1 = new Size(100, 22);
      Size size3 = size1;
      menuItem2.Size = size3;
      this.MenuItem2.Text = "Clear Thumbnail";
      this.MenuItem2.Image = (Image)LoneRobot.UI.My.Resources.Resources.cross;
      this.MenuItem2.Click += new EventHandler(this.MenuHandler);
      this.MenuItem3.Name = nameof(MenuItem3);
      ToolStripMenuItem menuItem3 = this.MenuItem3;
      size1 = new Size(100, 22);
      Size size4 = size1;
      menuItem3.Size = size4;
      this.MenuItem3.Text = "Options";
      this.MenuItem3.Image = (Image)LoneRobot.UI.My.Resources.Resources.options;
      this.MenuItem3.Click += new EventHandler(this.MenuHandler);
      this.MenuItem4.Name = nameof(MenuItem4);
      ToolStripSeparator menuItem4 = this.MenuItem4;
      size1 = new Size(100, 22);
      Size size5 = size1;
      menuItem4.Size = size5;
      this.MenuItem5.Name = nameof(MenuItem5);
      ToolStripMenuItem menuItem5 = this.MenuItem5;
      size1 = new Size(100, 22);
      Size size6 = size1;
      menuItem5.Size = size6;
      this.MenuItem5.Text = "Set Renderer to Thumbnail Width";
      this.MenuItem5.Click += new EventHandler(this.MenuHandler);
      NewLateBinding.LateCall(NewLateBinding.LateGet(this.RightClickMenu, (System.Type)null, "Items", new object[0], (string[])null, (System.Type[])null, (bool[])null), (System.Type)null, "AddRange", new object[1]
      {
        (object) new ToolStripItem[5]
        {
          (ToolStripItem) this.MenuItem1,
          (ToolStripItem) this.MenuItem2,
          (ToolStripItem) this.MenuItem3,
          (ToolStripItem) this.MenuItem4,
          (ToolStripItem) this.MenuItem5
        }
      }, (string[])null, (System.Type[])null, (bool[])null, true);
      NewLateBinding.LateSet(this.RightClickMenu, (System.Type)null, "Name", new object[1]
      {
        (object) nameof (RightClickMenu)
      }, (string[])null, (System.Type[])null);
      object rightClickMenu = this.RightClickMenu;
      object[] objArray1 = new object[1];
      object[] objArray2 = objArray1;
      size1 = new Size(100, 92);
      // ISSUE: variable of a boxed type
      __Boxed<Size> local1 = (ValueType)size1;
      objArray2[0] = (object)local1;
      object[] Arguments1 = objArray1;
      NewLateBinding.LateSet(rightClickMenu, (System.Type)null, "Size", Arguments1, (string[])null, (System.Type[])null);
      this.MaxMenuItem1.Name = nameof(MaxMenuItem1);
      ToolStripMenuItem maxMenuItem1 = this.MaxMenuItem1;
      size1 = new Size(100, 22);
      Size size7 = size1;
      maxMenuItem1.Size = size7;
      this.MaxMenuItem1.Text = "Load File (Hold Shift to load in new instance of max)";
      this.MaxMenuItem1.Image = (Image)LoneRobot.UI.My.Resources.Resources.folder;
      this.MaxMenuItem1.Click += new EventHandler(this.MenuHandler);
      this.MaxMenuItem2.Name = nameof(MaxMenuItem2);
      ToolStripMenuItem maxMenuItem2 = this.MaxMenuItem2;
      size1 = new Size(100, 22);
      Size size8 = size1;
      maxMenuItem2.Size = size8;
      this.MaxMenuItem2.Text = "Merge file (Hold Shift for Dialog)";
      this.MaxMenuItem2.Image = (Image)LoneRobot.UI.My.Resources.Resources.up_16;
      this.MaxMenuItem2.Click += new EventHandler(this.MenuHandler);
      this.MaxMenuItem3.Name = nameof(MaxMenuItem3);
      ToolStripSeparator maxMenuItem3 = this.MaxMenuItem3;
      size1 = new Size(100, 22);
      Size size9 = size1;
      maxMenuItem3.Size = size9;
      this.MaxMenuItem4.Name = nameof(MaxMenuItem4);
      ToolStripMenuItem maxMenuItem4 = this.MaxMenuItem4;
      size1 = new Size(100, 22);
      Size size10 = size1;
      maxMenuItem4.Size = size10;
      this.MaxMenuItem4.Text = "Browse To This File...";
      this.MaxMenuItem4.Click += new EventHandler(this.MenuHandler);
      NewLateBinding.LateCall(NewLateBinding.LateGet(this.MaxRightClickMenu, (System.Type)null, "Items", new object[0], (string[])null, (System.Type[])null, (bool[])null), (System.Type)null, "AddRange", new object[1]
      {
        (object) new ToolStripItem[4]
        {
          (ToolStripItem) this.MaxMenuItem1,
          (ToolStripItem) this.MaxMenuItem2,
          (ToolStripItem) this.MaxMenuItem3,
          (ToolStripItem) this.MaxMenuItem4
        }
      }, (string[])null, (System.Type[])null, (bool[])null, true);
      NewLateBinding.LateSet(this.MaxRightClickMenu, (System.Type)null, "Name", new object[1]
      {
        (object) nameof (MaxRightClickMenu)
      }, (string[])null, (System.Type[])null);
      object maxRightClickMenu = this.MaxRightClickMenu;
      object[] objArray3 = new object[1];
      object[] objArray4 = objArray3;
      size1 = new Size(100, 92);
      // ISSUE: variable of a boxed type
      __Boxed<Size> local2 = (ValueType)size1;
      objArray4[0] = (object)local2;
      object[] Arguments2 = objArray3;
      NewLateBinding.LateSet(maxRightClickMenu, (System.Type)null, "Size", Arguments2, (string[])null, (System.Type[])null);
      FileInfo fileInfo1 = new FileInfo(this.ScriptPath + "\\HitchHikerFavourites.xml");
      FileInfo fileInfo2 = new FileInfo(this.ScriptPath + "\\HitchHikerSettings.xml");
      if (fileInfo1.Exists)
        this.XML_LoadFavourites();
      else
        this.XML_BuildDefaultXMLFavourites();
      if (fileInfo2.Exists)
      {
        this.XML_LoadSettings();
      }
      else
      {
        this.XML_WriteSettings();
        this.XML_LoadSettings();
      }
      if (this.Favourites.Count <= 0)
        return;
      ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem(nameof(Favourites));
      toolStripMenuItem1.Name = nameof(Favourites);
      foreach (string favourite in this.Favourites)
      {
        if (MyProject.Computer.FileSystem.DirectoryExists(favourite))
        {
          ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(favourite);
          toolStripMenuItem2.Tag = (object)favourite;
          toolStripMenuItem1.DropDownItems.Add((ToolStripItem)toolStripMenuItem2);
          this.ToolStripButtonDirectory.DropDownItems.Add((ToolStripItem)toolStripMenuItem1);
          toolStripMenuItem2.Click += new EventHandler(this.FavouriteItemClicked);
        }
      }
    }

    public void FavouriteItemClicked(object sender, EventArgs e)
    {
      object[] objArray1 = new object[1];
      object[] objArray2 = objArray1;
      object Instance = sender;
      object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Instance, (System.Type)null, "tag", new object[0], (string[])null, (System.Type[])null, (bool[])null));
      objArray2[0] = objectValue;
      object[] objArray3 = objArray1;
      object[] Arguments = objArray3;
      bool[] flagArray = new bool[1] { true };
      bool[] CopyBack = flagArray;
      NewLateBinding.LateCall((object)this, (System.Type)null, "Populate", Arguments, (string[])null, (System.Type[])null, CopyBack, true);
      if (!flagArray[0])
        return;
      NewLateBinding.LateSetComplex(Instance, (System.Type)null, "tag", new object[1]
      {
        RuntimeHelpers.GetObjectValue(objArray3[0])
      }, (string[])null, (System.Type[])null, true, false);
    }

    private string Directory
    {
      get => this._directory;
      set
      {
        try
        {
          if (new DirectoryInfo(value).Exists)
          {
            this._directory = value;
          }
          else
          {
            int num = (int)MessageBox.Show("You have specified an invalid directory", nameof(HitchHiker), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }

    [Category("Data")]
    [Description("Gets the width of the current image")]
    public int CurrentImageWidth
    {
      get => this._CurrentImageWidth;
      set => this._CurrentImageWidth = value;
    }

    public StringCollection Favourites
    {
      get => this._Favourites;
      set => this._Favourites = value;
    }

    [Category("Appearance")]
    [Description("Sets the alignment of the image to text")]
    public TextImageRelation TextImageRelation
    {
      get => this._TextImageRelation;
      set => this._TextImageRelation = value;
    }

    [Category("Data")]
    [Description("Gets the width of the current image")]
    public int CurrentImageHeight
    {
      get => this._CurrentImageHeight;
      set => this._CurrentImageHeight = value;
    }

    [Category("Data")]
    [Description("Gets the filesize of the current image")]
    public string CurrentImageSize
    {
      get => this._CurrentImageSize;
      set => this._CurrentImageSize = value;
    }

    [Description("A property that stores the current directory")]
    [Category("Data")]
    public string CurrentMapFolder => new FileInfo(this.CurrentItem).DirectoryName;

    [Category("Data")]
    [Description("A property that stores the currently focused item")]
    public string CurrentItem
    {
      get => this._CurrentItem;
      set => this._CurrentItem = value;
    }

    public HitchHiker.PopulateFilterSearch PopulateSearchPart
    {
      get => this._PopulateFilterSearch;
      set
      {
        this._PopulateFilterSearch = value;
        switch (value)
        {
          case HitchHiker.PopulateFilterSearch.StartingWith:
            this.ToolStripButtonLogic.Image = (Image)LoneRobot.UI.My.Resources.Resources.text_starting;
            this.ToolStripButtonLogic.ToolTipText = "Files starting with";
            break;
          case HitchHiker.PopulateFilterSearch.EndingWith:
            this.ToolStripButtonLogic.Image = (Image)LoneRobot.UI.My.Resources.Resources.text_ending;
            this.ToolStripButtonLogic.ToolTipText = "Files ending with";
            break;
          case HitchHiker.PopulateFilterSearch.Contains:
            this.ToolStripButtonLogic.Image = (Image)LoneRobot.UI.My.Resources.Resources.star_gold;
            this.ToolStripButtonLogic.ToolTipText = "Files containing";
            break;
        }
      }
    }

    public string PopulateFilterPattern
    {
      get => this._PopulateFilterPattern;
      set => this._PopulateFilterPattern = value;
    }

    public HitchHiker.PopulateFilterLogic PopulateFilter
    {
      get => this._PopulateFilterLogic;
      set
      {
        this._PopulateFilterLogic = value;
        switch (value)
        {
          case HitchHiker.PopulateFilterLogic.Includes:
            this.ToolStripButtonIncExc.Image = (Image)LoneRobot.UI.My.Resources.Resources.plus;
            this.ToolStripButtonIncExc.ToolTipText = "Including";
            break;
          case HitchHiker.PopulateFilterLogic.Excludes:
            this.ToolStripButtonIncExc.Image = (Image)LoneRobot.UI.My.Resources.Resources.cross;
            this.ToolStripButtonIncExc.ToolTipText = "Excluding";
            break;
          case HitchHiker.PopulateFilterLogic.All:
            this.ToolStripButtonIncExc.Image = (Image)LoneRobot.UI.My.Resources.Resources.globe_16;
            this.ToolStripButtonIncExc.ToolTipText = "All";
            break;
        }
      }
    }

    [Description("A property that sets the thumb resize interpolation")]
    [Category("Data")]
    public HitchHiker.Interpolation ThumbInterpMode
    {
      get => (HitchHiker.Interpolation)this._ThumbInterpolation;
      set => this._ThumbInterpolation = (InterpolationMode)value;
    }

    [Category("Data")]
    [Description("A property that sets the return image resize interpolation")]
    public HitchHiker.Interpolation ReturnImageInterpMode
    {
      get => (HitchHiker.Interpolation)this._ReturnImageInterpolation;
      set => this._ReturnImageInterpolation = (InterpolationMode)value;
    }

    [Category("Layout")]
    [Description("Sets the distance in pixels between the control buttons")]
    public int Gap
    {
      get => this._padding;
      set
      {
        this._padding = value;
        this.UpdateDisplay();
      }
    }

    [Category("Layout")]
    [Description("Sets the filetype to display in the control")]
    public HitchHiker.filetypes Filetype
    {
      get => this._filetype;
      set
      {
        try
        {
          this._filetype = value;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num = (int)MessageBox.Show(ex.ToString());
          ProjectData.ClearProjectError();
        }
      }
    }

    [Description("Sets the size of the thumbnail")]
    [Category("Appearance")]
    public Size Thumbsize
    {
      get => this._Thumbsize;
      set
      {
        if (value.Height < 22)
          value.Height = 22;
        if (value.Width < 22)
          value.Width = 22;
        this._Thumbsize = value;
        this.UpdateDisplay();
      }
    }

    [Category("InterOp")]
    [Description("Sets the size of the render thumbnail")]
    public int Render_Thumbsize
    {
      get => this._RenderThumbsize;
      set => this._RenderThumbsize = value;
    }

    [Description("Sets the whether the control caches thumbs or generates them")]
    [Category("Data")]
    public HitchHiker.CacheState Cache
    {
      get => this._CacheState;
      set => this._CacheState = value;
    }

    [Category("InterOp")]
    [Description("Sets the size of the render thumbnail")]
    public int Render_ThumbsizeSmall
    {
      get => this._RenderThumbsizeSmall;
      set => this._RenderThumbsizeSmall = value;
    }

    [Description("Sets the size of the render thumbnail")]
    [Category("InterOp")]
    public int Render_ThumbsizeMedium
    {
      get => this._RenderThumbsizeMedium;
      set => this._RenderThumbsizeMedium = value;
    }

    [Description("Sets the size of the render thumbnail")]
    [Category("InterOp")]
    public int Render_ThumbsizeLarge
    {
      get => this._RenderThumbsizeLarge;
      set => this._RenderThumbsizeLarge = value;
    }

    [Category("InterOp")]
    [Description("Enables bg color in the thumbnail")]
    public bool Render_UseCustomBackground
    {
      get => this._UseCustomBG;
      set => this._UseCustomBG = value;
    }

    [Description("Enables bg color in the thumbnail")]
    [Category("InterOp")]
    public bool Render_SaveAlpha
    {
      get => this._SaveAlpha;
      set => this._SaveAlpha = value;
    }

    [Category("InterOp")]
    [Description("chooses whether to render or capture")]
    public bool Render_CaptureVpt
    {
      get => this._Capture;
      set => this._Capture = value;
    }

    [Category("InterOp")]
    [Description("the color of the render thumb custom background")]
    public Color Render_CustomBackgroundColor
    {
      get => this._CustomBGColor;
      set => this._CustomBGColor = value;
    }

    [Description("Overwrites the stored image cache")]
    [Category("Data")]
    public bool PurgeCache
    {
      get => this._PurgeCache;
      set => this._PurgeCache = value;
    }

    [Description("custom sizes for the thumbnail")]
    [Category("Appearance")]
    public HitchHiker.ThumbNailSize Thumbnails
    {
      get => this._ThumbNails;
      set
      {
        switch (value)
        {
          case HitchHiker.ThumbNailSize.Tiny:
            this.Thumbsize = new Size(24, 24);
            break;
          case HitchHiker.ThumbNailSize.Small:
            this.Thumbsize = new Size(50, 50);
            break;
          case HitchHiker.ThumbNailSize.Medium:
            this.Thumbsize = new Size(70, 70);
            break;
          case HitchHiker.ThumbNailSize.Large:
            this.Thumbsize = new Size(90, 90);
            break;
          case HitchHiker.ThumbNailSize.ExtraLarge:
            this.Thumbsize = new Size(150, 150);
            break;
        }
        this._ThumbNails = value;
        this.UpdateDisplay();
      }
    }

    [Description("Sets the size of the selected thumbnail border")]
    [Category("Appearance")]
    public int SelectedBorderWidth
    {
      get => this._SelectedBorderWidth;
      set
      {
        if (value > 15)
          value = 15;
        else if (value < 2)
          value = 2;
        this._SelectedBorderWidth = value;
      }
    }

    [Category("Appearance")]
    [Description("Sets how the thumbnail is displayed")]
    public HitchHiker.DisplayStyles DisplayStyle
    {
      get => this._DisplayStyle;
      set => this._DisplayStyle = value;
    }

    [Description("Shows the file search menu")]
    [Category("Appearance")]
    public bool ShowFileDataOnButton
    {
      get => this._ShowFileDataOnButton;
      set
      {
        this._ShowFileDataOnButton = value;
        if (value)
          this.ShowDataToolStripMenuItem.CheckState = CheckState.Checked;
        else
          this.ShowDataToolStripMenuItem.CheckState = CheckState.Unchecked;
      }
    }

    [Category("Appearance")]
    [Description("Shows the file search menu")]
    public bool ShowMenu
    {
      get => this._ShowMenu;
      set => this._ShowMenu = value;
    }

    public bool RecursiveSearch
    {
      get => this._RecursiveSearch;
      set => this._RecursiveSearch = value;
    }

    public bool BypassCacheFolderWarning
    {
      get => this._BypassCacheFolderWarning;
      set => this._BypassCacheFolderWarning = value;
    }

    [Description("Shows the top toolbar")]
    [Category("Appearance")]
    public bool ShowToolbar
    {
      get => this._ShowToolbar;
      set
      {
        this._ShowToolbar = value;
        if (value)
        {
          this.TableLayoutPanelUC.RowStyles[0].Height = 22f;
          this.ToolStripMenuBar.Visible = true;
        }
        else
        {
          this.TableLayoutPanelUC.RowStyles[0].Height = 0.0f;
          this.ToolStripMenuBar.Visible = false;
        }
      }
    }

    [Description("Enables showing the tooltip of the selected item")]
    [Category("Appearance")]
    public bool ShowTooltips
    {
      get => this._ShowTooltips;
      set
      {
        this._ShowTooltips = value;
        if (value)
          this.FileToolTip.Active = true;
        else
          this.FileToolTip.Active = false;
      }
    }

    public Button FocusedControl
    {
      get => this._FocusedControl;
      set => this._FocusedControl = value;
    }

    [Description("Positions the text on the thumbnail")]
    [Category("Layout")]
    public ContentAlignment TextAlign
    {
      get => this._TextAlign;
      set
      {
        this._TextAlign = value;
        this.UpdateDisplay();
      }
    }

    [Category("Layout")]
    [Description("Positions the image on the thumbnail")]
    public ContentAlignment ImageAlign
    {
      get => this._ImageAlign;
      set
      {
        this._ImageAlign = value;
        this.UpdateDisplay();
      }
    }

    [Category("Appearance")]
    [Description("Changes the selected thumbnail's border color")]
    public Color SelectedHighLight
    {
      get => this._SelectedHighLight;
      set
      {
        this._SelectedHighLight = value;
        this.UpdateDisplay();
      }
    }

    [Description("Changes the flow panel background color")]
    [Category("Appearance")]
    public Color ThumbPanelBackColor
    {
      get => this._ThumbPanelBackColor;
      set
      {
        this._ThumbPanelBackColor = value;
        this.ThumbBoard.BackColor = value;
        ((Control)this).Refresh();
      }
    }

    [Category("Appearance")]
    [Description("Allows you to set the buttons to have a different color to the rest of the control")]
    public Color ButtonBackColor
    {
      get => this._ButtonBackColor;
      set
      {
        this._ButtonBackColor = value;
        this.UpdateDisplay();
      }
    }

    [Category("Appearance")]
    [Description("Allows you to set the buttons to have no border when drawn on the control")]
    public bool ButtonBorder
    {
      get => this._ButtonBorder;
      set
      {
        this._ButtonBorder = value;
        this.UpdateDisplay();
      }
    }

    [Description("Allows you to set the buttons to have a random backcolor")]
    [Category("Appearance")]
    public bool BinglyBongly
    {
      get => this._binglybongly;
      set
      {
        this._binglybongly = value;
        this.UpdateDisplay();
      }
    }

    [Description("Changes the selected sort method - date/last written/name for display on the panel")]
    [Category("Appearance")]
    public HitchHiker.SortByOptions SortBy
    {
      get => this._sortby;
      set => this._sortby = value;
    }

    private string Filesize(long bytesize)
    {
      float num = (float)(bytesize / 1024L);
      return (double)num < 1024.0 ? Conversions.ToString(num) + " Kb" : Conversions.ToString(Math.Round((double)num / 1024.0, 2)) + " Mb";
    }

    private void Thumb_MouseOver(object sender, EventArgs e)
    {
      if (!this.ShowTooltips || !Conversions.ToBoolean(NewLateBinding.LateGet(sender, (System.Type)null, "focused", new object[0], (string[])null, (System.Type[])null, (bool[])null)))
        return;
      string str1 = new string(Conversions.ToCharArrayRankOne(""));
      FileInfo fileInfo = new FileInfo(Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type)null, "tag", new object[0], (string[])null, (System.Type[])null, (bool[])null)));
      switch (this.Filetype)
      {
        case HitchHiker.filetypes.max:
        case HitchHiker.filetypes.wav:
          this.CurrentImageSize = this.Filesize(fileInfo.Length);
          string caption1 = "Filename : " + fileInfo.Name + "\r\nPath : " + fileInfo.DirectoryName + "\r\nSize : " + this.Filesize(fileInfo.Length) + "\r\nModified : " + Conversions.ToString(fileInfo.LastWriteTime);
          this.FileToolTip.ToolTipTitle = this.Filetype != HitchHiker.filetypes.wav ? "3dsMax File" : "Wav Audio File";
          this.FileToolTip.SetToolTip((Control)sender, caption1);
          this.FileToolTip.Active = true;
          break;
        default:
          this.CurrentImageWidth = MaxscriptSDK.ExecuteIntMaxscriptQuery("LR_HitchHiker_BitmapInfo_Width @\"" + this.CurrentItem + "\"");
          this.CurrentImageHeight = MaxscriptSDK.ExecuteIntMaxscriptQuery("LR_HitchHiker_BitmapInfo_Height @\"" + this.CurrentItem + "\"");
          string str2 = MaxscriptSDK.ExecuteStringMaxscriptQuery("LR_HitchHiker_BitmapInfo_DeviceName @\"" + this.CurrentItem + "\"");
          bool flag = MaxscriptSDK.ExecuteBooleanMaxscriptQuery("LR_HitchHiker_BitmapInfo_HasAlpha @\"" + this.CurrentItem + "\"");
          this.CurrentImageSize = this.Filesize(fileInfo.Length);
          string str3 = flag ? "Yes" : "No";
          string caption2 = "Filename : " + fileInfo.Name + "\r\nPath : " + fileInfo.DirectoryName + "\r\nSize : " + this.Filesize(fileInfo.Length) + "\r\nModified : " + Conversions.ToString(fileInfo.LastWriteTime) + "\r\nWidth : " + this.CurrentImageWidth.ToString() + " px\r\nHeight : " + this.CurrentImageHeight.ToString() + " px\r\nAlpha : " + str3;
          this.FileToolTip.ToolTipTitle = str2;
          this.FileToolTip.SetToolTip((Control)sender, caption2);
          this.FileToolTip.Active = true;
          break;
      }
    }

    public Image CurrentImage(float multiplier)
    {
      Image image1;
      try
      {
        if ((double)multiplier > 1.0 | (double)multiplier < 0.1)
          throw new Exception("Enter a value between 0.1 and 1");
        Image image2 = Image.FromFile(this.CurrentItem);
        this.CurrentImageHeight = image2.Height;
        this.CurrentImageWidth = image2.Width;
        this.CurrentImageSize = this.Filesize(new FileInfo(this.CurrentItem).Length);
        if (image2.Width > 1000 | image2.Height > 1000)
          multiplier /= 2f;
        Bitmap bitmap = new Bitmap(checked((int)Math.Round((double)unchecked((float)image2.Width * multiplier))), checked((int)Math.Round((double)unchecked((float)image2.Height * multiplier))));
        Graphics graphics = Graphics.FromImage((Image)bitmap);
        graphics.InterpolationMode = (InterpolationMode)this.ReturnImageInterpMode;
        graphics.DrawImage(image2, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, image2.Width, image2.Height, GraphicsUnit.Pixel);
        graphics.Dispose();
        image2.Dispose();
        image1 = (Image)bitmap;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int)MessageBox.Show(ex.ToString());
        image1 = (Image)null;
        ProjectData.ClearProjectError();
      }
      return image1;
    }

    private void Thumb_DragDrop(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left || (Control.ModifierKeys & (Keys.KeyCode | Keys.Modifiers)) == 0)
        return;
      string[] data = new string[1]
      {
        Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "tag", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null))
      };
      this.Fdata = new DataObject(DataFormats.FileDrop, (object)data);
      int num = (int)((Control)this).DoDragDrop((object)this.Fdata, DragDropEffects.Copy);
    }

    private Color RandomColor() => Color.FromArgb(this.randomGenerator.Next(0, (int)byte.MaxValue), this.randomGenerator.Next(0, (int)byte.MaxValue), this.randomGenerator.Next(0, (int)byte.MaxValue));

    protected virtual void OnGotFocus(EventArgs e)
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual(((Control)this).OnGotFocus(e));
      this.FocusedControl.Focus();
      ((Control)this).Refresh();
      AppSDK.EnableAccelerators();
    }

    public void Populate(string directory)
    {
      this.ClearPanel();
      this.ThumbBoard.BackgroundImage = (Image)LoneRobot.UI.My.Resources.Resources.clock;
      this.Directory = directory;
      this.TableLayoutPanelUC.RowStyles[2].Height = 14f;
      this.ProgressUpdate.Visible = true;
      this.ButtonCancel.Visible = true;
      switch (this.Filetype)
      {
        case HitchHiker.filetypes.avi:
        case HitchHiker.filetypes.psd:
        case HitchHiker.filetypes.rpf:
        case HitchHiker.filetypes.tga:
        case HitchHiker.filetypes.wav:
          this.ProcessMaxBitmaps((string[])null);
          break;
        case HitchHiker.filetypes.bmp:
        case HitchHiker.filetypes.jpg:
        case HitchHiker.filetypes.max:
        case HitchHiker.filetypes.png:
        case HitchHiker.filetypes.tif:
          while (!((BackgroundWorker)this.MaxThreadWorker).IsBusy)
            ((BackgroundWorker)this.MaxThreadWorker).RunWorkerAsync();
          break;
      }
      AppSDK.EnableAccelerators();
    }

    public void Populate(string[] Files)
    {
      this.ClearPanel();
      this.ThumbBoard.BackgroundImage = (Image)LoneRobot.UI.My.Resources.Resources.clock;
      this.Directory = this.Directory;
      this.TableLayoutPanelUC.RowStyles[2].Height = 14f;
      this.ProgressUpdate.Visible = true;
      this.ButtonCancel.Visible = true;
      switch (this.Filetype)
      {
        case HitchHiker.filetypes.avi:
        case HitchHiker.filetypes.psd:
        case HitchHiker.filetypes.rpf:
        case HitchHiker.filetypes.tga:
        case HitchHiker.filetypes.wav:
          this.ProcessMaxBitmaps(Files);
          break;
        case HitchHiker.filetypes.bmp:
        case HitchHiker.filetypes.jpg:
        case HitchHiker.filetypes.max:
        case HitchHiker.filetypes.png:
        case HitchHiker.filetypes.tif:
          while (!((BackgroundWorker)this.MaxThreadWorker).IsBusy)
            ((BackgroundWorker)this.MaxThreadWorker).RunWorkerAsync((object)Files);
          break;
      }
      AppSDK.EnableAccelerators();
    }

    public void XML_BuildDefaultXMLFavourites()
    {
      XmlDocument xmlDocument = new XmlDocument();
      XmlElement element1 = xmlDocument.CreateElement("LoneRobot");
      xmlDocument.AppendChild((XmlNode)element1);
      XmlElement element2 = xmlDocument.CreateElement(nameof(HitchHiker));
      XmlNode xmlNode = element1.AppendChild((XmlNode)element2);
      XmlElement element3 = xmlDocument.CreateElement("Favourites");
      XmlElement element4 = xmlDocument.CreateElement("Path");
      element4.InnerText = PathSDK.GetDirectoryPath((PathSDK.DirectoryID)7);
      element3.AppendChild((XmlNode)element4);
      XmlElement element5 = xmlDocument.CreateElement("Path");
      element5.InnerText = PathSDK.GetDirectoryPath((PathSDK.DirectoryID)1);
      element3.AppendChild((XmlNode)element5);
      xmlNode.AppendChild((XmlNode)element3);
      xmlDocument.Save(this.ScriptPath + "\\HitchHikerFavourites.xml");
      this.XML_LoadFavourites();
    }

    public void XML_LoadFavourites()
    {
      try
      {
        StringCollection stringCollection = new StringCollection();
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(this.ScriptPath + "\\HitchHikerFavourites.xml");
        XmlElement firstChild = (XmlElement)xmlDocument.DocumentElement.FirstChild.FirstChild;
        int num = checked(firstChild.ChildNodes.Count - 1);
        int i = 0;
        while (i <= num)
        {
          stringCollection.Add(firstChild.ChildNodes[i].InnerText);
          checked { ++i; }
        }
        if (stringCollection.Count <= 0)
          return;
        this.Favourites = stringCollection;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public void XML_SaveFavourites()
    {
      // ISSUE: unable to decompile the method.
    }

    private void MenuHandler(object sender, EventArgs e)
    {
      ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
      Button tag = (Button)toolStripMenuItem.Tag;
      string name = toolStripMenuItem.Name;
      if (Operators.CompareString(name, "MenuItem1", false) == 0)
      {
        string fileName = Path.GetFileName(Conversions.ToString(tag.Tag));
        string path = Path.Combine(Path.GetDirectoryName(Conversions.ToString(tag.Tag)), "_assets\\");
        string str = Path.ChangeExtension(fileName, "png");
        DirectoryInfo directoryInfo = new DirectoryInfo(path);
        if (!directoryInfo.Exists)
        {
          if ((!this.BypassCacheFolderWarning ? MessageBox.Show("There is no asset folder present in this directory. Do you want me to create one?", "LoneRobot.HitchHiker", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) : DialogResult.Yes) != DialogResult.Yes)
            return;
          directoryInfo.Create();
        }
        if (this.RenderThumbnail() && Clipboard.ContainsImage())
        {
          Bitmap image = (Bitmap)Clipboard.GetImage();
          if (this.Render_SaveAlpha)
            image.MakeTransparent();
          image.Save(path + "\\" + str, ImageFormat.Png);
          tag.Image = (Image)image;
        }
      }
      else if (Operators.CompareString(name, "MenuItem2", false) == 0)
      {
        string fileName = Path.GetFileName(Conversions.ToString(tag.Tag));
        FileInfo fileInfo = new FileInfo(Path.Combine(Path.GetDirectoryName(Conversions.ToString(tag.Tag)), "_assets\\") + "\\" + Path.ChangeExtension(fileName, "png"));
        if (fileInfo.Exists)
        {
          if (MessageBox.Show("Are you sure you want to delete this thumbnail?", "LoneRobot.HitchHiker", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
          {
            try
            {
              fileInfo.Delete();
              tag.Image = this.DisplayStyle == HitchHiker.DisplayStyles.Text ? (Image)null : (Image)LoneRobot.UI.My.Resources.Resources.MaxL;
            }
            catch (IOException ex)
            {
              ProjectData.SetProjectError((Exception)ex);
              int num = (int)MessageBox.Show("It was not possible to delete this thumbnail as it is being used in another process. Check it is not open in another program.", "LoneRobot.HitchHiker");
              ProjectData.ClearProjectError();
            }
          }
        }
      }
      else if (Operators.CompareString(name, "MenuItem3", false) == 0)
      {
        HitchHiker HitchHikerControl = this;
        int num = (int)new RenderOptions(ref HitchHikerControl, this.Colorman.GetControlColor(), this.Colorman.GetTextColor(), this.Colorman.GetButtonPressedColor()).ShowDialog();
      }
      else if (Operators.CompareString(name, "MenuItem5", false) == 0)
      {
        try
        {
          MaxscriptSDK.ExecuteMaxscriptCommand("If renderSceneDialog.isOpen() Then renderSceneDialog.close()");
          Size thumbsize = this.Thumbsize;
          int num = thumbsize.Height;
          MaxscriptSDK.ExecuteMaxscriptCommand("RenderHeight = " + num.ToString());
          thumbsize = this.Thumbsize;
          num = thumbsize.Width;
          MaxscriptSDK.ExecuteMaxscriptCommand("RenderWidth = " + num.ToString());
          MaxscriptSDK.ExecuteMaxscriptCommand("renderSceneDialog.Open()");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      else if (Operators.CompareString(name, "MaxMenuItem1", false) == 0)
      {
        if ((Control.ModifierKeys & (Keys.KeyCode | Keys.Modifiers)) != 0)
        {
          string arguments = Conversions.ToString(tag.Tag);
          Process.Start(PathSDK.GetDirectoryPath((PathSDK.DirectoryID)20) + "3dsMax.exe", arguments);
        }
        else
          MaxscriptSDK.ExecuteMaxscriptCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"LoadMaxFile @\"", tag.Tag), (object)'"')));
      }
      else if (Operators.CompareString(name, "MaxMenuItem2", false) == 0)
      {
        if ((Control.ModifierKeys & (Keys.KeyCode | Keys.Modifiers)) != 0)
          MaxscriptSDK.ExecuteMaxscriptCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"MergeMaxFile @\"", tag.Tag), (object)'"'), (object)" #select #Prompt #promptDups #promptMtlDups #promptReparent")));
        else
          MaxscriptSDK.ExecuteMaxscriptCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"MergeMaxFile @\"", tag.Tag), (object)'"'), (object)" #select #promptDups #promptMtlDups #promptReparent")));
      }
      else if (Operators.CompareString(name, "MaxMenuItem4", false) == 0)
        Process.Start("explorer.exe", Conversions.ToString(Operators.ConcatenateObject((object)"/select,", tag.Tag)));
      AppSDK.EnableAccelerators();
    }

    private void FlowButton_MouseUp(object sender, MouseEventArgs e)
    {
      Button button = (Button)sender;
      if (e.Button == MouseButtons.Right & button.Focused)
      {
        if (this.Filetype == HitchHiker.filetypes.max)
        {
          if (e.Button == MouseButtons.Right & button.Focused)
          {
            if ((Control.ModifierKeys & (Keys.KeyCode | Keys.Modifiers)) != 0)
            {
              this.MenuItem1.Tag = (object)button;
              this.MenuItem2.Tag = (object)button;
              this.MenuItem3.Tag = (object)button;
              this.MenuItem5.Tag = (object)button;
              NewLateBinding.LateCall(this.RightClickMenu, (System.Type)null, "show", new object[1]
              {
                (object) ((Control) this).PointToScreen(e.Location + (Size) button.Location)
              }, (string[])null, (System.Type[])null, (bool[])null, true);
            }
            else
            {
              this.MaxMenuItem1.Tag = (object)button;
              this.MaxMenuItem2.Tag = (object)button;
              this.MaxMenuItem4.Tag = (object)button;
              NewLateBinding.LateCall(this.MaxRightClickMenu, (System.Type)null, "show", new object[1]
              {
                (object) ((Control) this).PointToScreen(e.Location + (Size) button.Location)
              }, (string[])null, (System.Type[])null, (bool[])null, true);
            }
          }
        }
        else
        {
          Point screen = ((Control)this).PointToScreen(e.Location + (Size)button.Location);
          HikerPickedEventArgs e1 = new HikerPickedEventArgs(button.Image, Conversions.ToString(button.Tag), this, screen, e.Button);
          HitchHiker.ThumbPickedEventHandler thumbPickedEvent = this.ThumbPickedEvent;
          if (thumbPickedEvent != null)
            thumbPickedEvent((object)this, e1);
        }
      }
      AppSDK.EnableAccelerators();
    }

    private void SendToMaxListener(string caption, string text) => MaxscriptSDK.ExecuteMaxscriptCommand("Print @\"" + caption + " - " + text + "\"\\N");

    public bool RenderThumbnail()
    {
      int num;
      switch (this.Render_Thumbsize)
      {
        case 1:
          num = this.Render_ThumbsizeSmall;
          break;
        case 2:
          num = this.Render_ThumbsizeMedium;
          break;
        default:
          num = this.Render_ThumbsizeLarge;
          break;
      }
      return MaxscriptSDK.ExecuteBooleanMaxscriptQuery("LR_RenderAssetThumbnail " + num.ToString() + " " + this.Render_CaptureVpt.ToString() + " " + this.Render_UseCustomBackground.ToString() + " " + this.Render_CustomBackgroundColor.R.ToString() + " " + this.Render_CustomBackgroundColor.G.ToString() + " " + this.Render_CustomBackgroundColor.B.ToString() + " " + this.Render_SaveAlpha.ToString());
    }

    private FileInfo[] ReturnFileInfoList(string[] files)
    {
      if (files == null)
      {
        if (Operators.CompareString(this.Directory, "", false) == 0)
          return (FileInfo[])null;
        this.images.Clear();
        SearchOption searchOption = !this.RecursiveSearch ? SearchOption.TopDirectoryOnly : SearchOption.AllDirectories;
        return new DirectoryInfo(this.Directory).GetFiles("*." + this.Filetype.ToString(), searchOption);
      }
      this.images.Clear();
      Collection collection = new Collection();
      string[] strArray = files;
      int index1 = 0;
      while (index1 < strArray.Length)
      {
        FileInfo fileInfo = new FileInfo(strArray[index1]);
        collection.Add((object)fileInfo, (string)null, (object)null, (object)null);
        checked { ++index1; }
      }
      FileInfo[] fileInfoArray = new FileInfo[checked(collection.Count - 1 + 1)];
      int index2 = 0;
      try
      {
        foreach (FileInfo fileInfo in collection)
        {
          fileInfoArray[index2] = fileInfo;
          checked { ++index2; }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return fileInfoArray;
    }

    private void ProcessMaxBitmaps(string[] Files)
    {
      FileInfo[] fileInfoArray1 = this.ReturnFileInfoList(Files);
      if (fileInfoArray1 != null)
      {
        Array.Sort((Array)fileInfoArray1, (IComparer)new HitchHiker.CompareFileInfoEntries(this.SortBy));
        int num1 = 0;
        FileInfo[] fileInfoArray2 = fileInfoArray1;
        int index = 0;
        while (index < fileInfoArray2.Length)
        {
          FileInfo file = fileInfoArray2[index];
          if (this.AbortMaxLoadProcess)
          {
            this.AbortMaxLoadProcess = false;
            return;
          }
          if (this.DetermineIfFileisParsed(file))
          {
            switch (this.DisplayStyle)
            {
              case HitchHiker.DisplayStyles.Images:
              case HitchHiker.DisplayStyles.ImageText:
                if (this.Cache == HitchHiker.CacheState.Realtime)
                {
                  this.images.Add(new NamedImage(this.ImageThumbnail(file.FullName), file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
                  break;
                }
                if (!file.DirectoryName.EndsWith("_assets"))
                {
                  string fullName = file.FullName;
                  string scriptPath = this.ScriptPath;
                  string str1 = Path.Combine(scriptPath, "_assets\\");
                  string text = Path.ChangeExtension(fullName, "png");
                  DirectoryInfo directoryInfo = new DirectoryInfo(str1);
                  int num2 = (int)MessageBox.Show(fullName, "cachefilename");
                  int num3 = (int)MessageBox.Show(scriptPath, "pngfilepath");
                  int num4 = (int)MessageBox.Show(str1, "assetpath");
                  int num5 = (int)MessageBox.Show(text, "pngfilename");
                  if (!directoryInfo.Exists)
                  {
                    if ((!this.BypassCacheFolderWarning ? MessageBox.Show("There is no cache folder present in this directory. Do you want me to create one?", "LoneRobot.HitchHiker", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) : DialogResult.Yes) != DialogResult.Yes)
                      return;
                    directoryInfo.Create();
                  }
                  string str2 = str1 + Path.GetFileNameWithoutExtension(file.FullName) + ".png";
                  int num6 = (int)MessageBox.Show(str2, "dedicatediconstring");
                  FileInfo fileInfo = new FileInfo(str2);
                  if (fileInfo.Exists)
                  {
                    if (this.PurgeCache)
                    {
                      this.images.Add(new NamedImage(this.ImageCacheSaveThumbnail(file.FullName, fileInfo.FullName), file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
                      break;
                    }
                    this.images.Add(new NamedImage(this.ImageCacheLoadThumbnail(fileInfo.FullName), file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
                    break;
                  }
                  this.images.Add(new NamedImage(this.ImageCacheSaveThumbnail(file.FullName, fileInfo.FullName), file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
                  break;
                }
                break;
              case HitchHiker.DisplayStyles.Icons:
              case HitchHiker.DisplayStyles.IconText:
                if (this.Thumbsize.Width < LoneRobot.UI.My.Resources.Resources.jpg.Width | this.Thumbsize.Height < LoneRobot.UI.My.Resources.Resources.jpg.Height)
                {
                  Image image;
                  switch (this.Filetype)
                  {
                    case HitchHiker.filetypes.avi:
                      image = (Image)LoneRobot.UI.My.Resources.Resources.avi;
                      break;
                    case HitchHiker.filetypes.bmp:
                      image = (Image)LoneRobot.UI.My.Resources.Resources.bmp;
                      break;
                    case HitchHiker.filetypes.jpg:
                      image = (Image)LoneRobot.UI.My.Resources.Resources.jpg;
                      break;
                    case HitchHiker.filetypes.max:
                      image = (Image)LoneRobot.UI.My.Resources.Resources.max;
                      break;
                    case HitchHiker.filetypes.png:
                      image = (Image)LoneRobot.UI.My.Resources.Resources.png;
                      break;
                    case HitchHiker.filetypes.psd:
                      image = (Image)LoneRobot.UI.My.Resources.Resources.psd;
                      break;
                    case HitchHiker.filetypes.tif:
                      image = (Image)LoneRobot.UI.My.Resources.Resources.tiff;
                      break;
                    case HitchHiker.filetypes.rpf:
                      image = (Image)LoneRobot.UI.My.Resources.Resources.rpf;
                      break;
                    case HitchHiker.filetypes.tga:
                      image = (Image)LoneRobot.UI.My.Resources.Resources.tga;
                      break;
                    case HitchHiker.filetypes.wav:
                      image = (Image)LoneRobot.UI.My.Resources.Resources.wav;
                      break;
                    default:
                      image = (Image)null;
                      break;
                  }
                  this.images.Add(new NamedImage(image, file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
                  break;
                }
                Image image1;
                switch (this.Filetype)
                {
                  case HitchHiker.filetypes.avi:
                    image1 = (Image)LoneRobot.UI.My.Resources.Resources.aviL;
                    break;
                  case HitchHiker.filetypes.bmp:
                    image1 = (Image)LoneRobot.UI.My.Resources.Resources.bmpL;
                    break;
                  case HitchHiker.filetypes.jpg:
                    image1 = (Image)LoneRobot.UI.My.Resources.Resources.jpgL;
                    break;
                  case HitchHiker.filetypes.max:
                    image1 = (Image)LoneRobot.UI.My.Resources.Resources.MaxL;
                    break;
                  case HitchHiker.filetypes.png:
                    image1 = (Image)LoneRobot.UI.My.Resources.Resources.PngL;
                    break;
                  case HitchHiker.filetypes.psd:
                    image1 = (Image)LoneRobot.UI.My.Resources.Resources.PsdL;
                    break;
                  case HitchHiker.filetypes.tif:
                    image1 = (Image)LoneRobot.UI.My.Resources.Resources.tiffL;
                    break;
                  case HitchHiker.filetypes.rpf:
                    image1 = (Image)LoneRobot.UI.My.Resources.Resources.RpfL;
                    break;
                  case HitchHiker.filetypes.tga:
                    image1 = (Image)LoneRobot.UI.My.Resources.Resources.tgaL;
                    break;
                  case HitchHiker.filetypes.wav:
                    image1 = (Image)LoneRobot.UI.My.Resources.Resources.wavL;
                    break;
                  default:
                    image1 = (Image)null;
                    break;
                }
                this.images.Add(new NamedImage(image1, file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
                break;
              default:
                this.images.Add(new NamedImage((Image)null, file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
                break;
            }
            checked { ++num1; }
            this.ProgressUpdate.Value = checked((int)Math.Round(unchecked((double)num1 / (double)fileInfoArray1.Length * 100.0)));
            this.ThumbBoard.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.ThumbBoard.Invalidate();
          }
          checked { ++index; }
        }
      }
      this.TableLayoutPanelUC.RowStyles[2].Height = 0.0f;
      MaxscriptSDK.ExecuteMaxscriptCommand("GC()");
      this.UpdateDisplay();
      this.PurgeCache = false;
    }

    private List<string> FileArray()
    {
      FileInfo[] files = new DirectoryInfo(this.Directory).GetFiles("*." + this.Filetype.ToString());
      Array.Sort((Array)files, (IComparer)new HitchHiker.CompareFileInfoEntries(this.SortBy));
      List<string> stringList = new List<string>();
      FileInfo[] fileInfoArray = files;
      int index = 0;
      while (index < fileInfoArray.Length)
      {
        FileInfo fileInfo = fileInfoArray[index];
        stringList.Add(fileInfo.FullName);
        checked { ++index; }
      }
      return stringList;
    }

    private void EvaluateMaxImageIO()
    {
      if (!MaxscriptSDK.ExecuteBooleanMaxscriptQuery("LR_HitchHiker_Bitmap == undefined"))
        return;
      MaxscriptSDK.ExecuteMaxscriptCommand("Fn LR_HitchHiker_Bitmap file  = ;(local LRBitmap = openBitMap file ;if LRBitmap.numframes > 1 then ;(LRBitmap.frame = (LRBitmap.numframes/2) as integer ;setclipboardbitmap LRBitmap) ;else(setclipboardbitmap LRBitmap ;close LRBitmap ;true))");
      MaxscriptSDK.ExecuteMaxscriptCommand("Fn LR_RenderAssetThumbnail thumbsize captureVpt usecustombg custombgcolor_R custombgcolor_G custombgcolor_B savealpha = ;(Local ViewCap=undefined;pngio.setAlpha savealpha;local cv = getViewSize();local ratio;case of ;( ;(cv.x > cv.y):(ratio = cv.y/cv.x);(cv.x = cv.y):(ratio = 1));if not captureVpt then;(if usecustombg then(local tempBGcol = backgroundColor;backgroundColor = color custombgcolor_R custombgcolor_G custombgcolor_B;viewcap  = render outputsize:[thumbsize,thumbsize] progressbar:on vfb:off;backgroundColor =tempBGcol);else viewcap = render outputsize:[thumbsize,thumbsize] progressbar:on vfb:off);else;(VptDib =gw.getViewportDib();ViewCap = bitmap renderwidth renderheight color:white;ViewportRatio = VptDib.width/VptDib.height as float;RenderRatio = renderwidth/renderheight as float;case of((ViewportRatio <= RenderRatio):(;CapturetoRenderHeightRatio =VptDib.width/RenderRatio as float;TopEdge = ((VptDib.Height-CapturetoRenderHeightRatio)/ 2) as integer;FullViewcap = bitmap vptdib.width CapturetoRenderHeightRatio color:white;pasteBitmap VptDib FullViewcap (box2 0 TopEdge VptDib.width VptDib.height) [0,0];Copy FullViewcap ViewCap);(ViewportRatio > RenderRatio):(CapturetoRenderHeightRatio =VptDib.height*RenderRatio as float;LeftEdge = ((VptDib.width-CapturetoRenderHeightRatio)/ 2) as integer;FullViewcap = bitmap CapturetoRenderHeightRatio VptDib.height color:white;pasteBitmap VptDib FullViewcap (box2 LeftEdge 0 VptDib.width VptDib.height) [0,0];Copy FullViewcap ViewCap);default:());close VptDib);if viewcap != undefined then (setclipboardbitmap viewcap;close ViewCap;return true)else(return false))");
      MaxscriptSDK.ExecuteMaxscriptCommand("Fn LR_HitchHiker_BitmapInfo_DeviceName file =(local BitmapInfoArray = (getBitmapInfo file);return BitmapInfoArray[2])");
      MaxscriptSDK.ExecuteMaxscriptCommand("Fn LR_HitchHiker_BitmapInfo_Width file =(local BitmapInfoArray = (getBitmapInfo file);return BitmapInfoArray[3])");
      MaxscriptSDK.ExecuteMaxscriptCommand("Fn LR_HitchHiker_BitmapInfo_Height file =(local BitmapInfoArray = (getBitmapInfo file);return BitmapInfoArray[4])");
      MaxscriptSDK.ExecuteMaxscriptCommand("Fn LR_HitchHiker_BitmapInfo_HasAlpha file =(local BitmapInfoArray = (getBitmapInfo file);return BitmapInfoArray[9])");
      MaxscriptSDK.ExecuteMaxscriptCommand("Fn LR_HitchHiker_BitmapInfo_FirstFrame file =(local BitmapInfoArray = (getBitmapInfo file);return BitmapInfoArray[10])");
      MaxscriptSDK.ExecuteMaxscriptCommand("Fn LR_HitchHiker_BitmapInfo_LastFrame file =(local BitmapInfoArray = (getBitmapInfo file);return BitmapInfoArray[11])");
    }

    private Image MaxBitmap(string file) => MaxscriptSDK.ExecuteBooleanMaxscriptQuery("LR_HitchHiker_Bitmap @\"" + file + "\"") ? Clipboard.GetImage() : (Image)null;

    public void Housekeeping()
    {
      MaxscriptSDK.ExecuteMaxscriptCommand("LR_HitchHiker_Bitmap = undefined");
      MaxscriptSDK.ExecuteMaxscriptCommand("LR_RenderAssetThumbnail = undefined");
      MaxscriptSDK.ExecuteMaxscriptCommand("LR_HitchHiker_BitmapInfo_Width = undefined");
      MaxscriptSDK.ExecuteMaxscriptCommand("LR_HitchHiker_BitmapInfo_Height = undefined");
      MaxscriptSDK.ExecuteMaxscriptCommand("LR_HitchHiker_BitmapInfo_HasAlpha = undefined");
      MaxscriptSDK.ExecuteMaxscriptCommand("LR_HitchHiker_BitmapInfo_FirstFrame = undefined");
      MaxscriptSDK.ExecuteMaxscriptCommand("LR_HitchHiker_BitmapInfo_LastFrame = undefined");
      MaxscriptSDK.ExecuteMaxscriptCommand("GC()");
      AppSDK.EnableAccelerators();
    }

    private Image ImageCacheLoadThumbnail(string file)
    {
      Image image1;
      try
      {
        Image image2 = Image.FromFile(file);
        int width = image2.Width;
        int height = image2.Height;
        Bitmap bitmap = new Bitmap(width, height);
        Graphics graphics = Graphics.FromImage((Image)bitmap);
        graphics.InterpolationMode = (InterpolationMode)this.ThumbInterpMode;
        graphics.DrawImage(image2, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, width, height, GraphicsUnit.Pixel);
        graphics.Dispose();
        image2.Dispose();
        image1 = (Image)bitmap;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int)MessageBox.Show("the problem is here", "imagecacheloadthumbnail FN");
        image1 = (Image)null;
        ProjectData.ClearProjectError();
      }
      return image1;
    }

    private Image ImageCacheSaveThumbnail(string file, string CacheFilename)
    {
      Image image1;
      try
      {
        Image thumbimg;
        switch (this.Filetype)
        {
          case HitchHiker.filetypes.avi:
          case HitchHiker.filetypes.psd:
          case HitchHiker.filetypes.rpf:
          case HitchHiker.filetypes.tga:
            thumbimg = this.MaxBitmap(file);
            break;
          case HitchHiker.filetypes.wav:
            image1 = !(this.Thumbsize.Width < LoneRobot.UI.My.Resources.Resources.wav.Width | this.Thumbsize.Height < LoneRobot.UI.My.Resources.Resources.wav.Height) ? (Image)LoneRobot.UI.My.Resources.Resources.wavL : (Image)LoneRobot.UI.My.Resources.Resources.wav;
            goto label_6;
          default:
            thumbimg = Image.FromFile(file);
            break;
        }
        Image image2 = this.ImageThumbnail(thumbimg);
        image2.Save(CacheFilename);
        thumbimg.Dispose();
        image1 = image2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int)MessageBox.Show(ex.ToString(), "imagecacheSaveThumbnail exception");
        image1 = (Image)null;
        ProjectData.ClearProjectError();
      }
    label_6:
      return image1;
    }

    private Image ImageThumbnail(string file)
    {
      Image image1;
      try
      {
        int height1 = 0;
        int width1 = 0;
        Image image2;
        int width2;
        int height2;
        switch (this.Filetype)
        {
          case HitchHiker.filetypes.avi:
          case HitchHiker.filetypes.psd:
          case HitchHiker.filetypes.rpf:
          case HitchHiker.filetypes.tga:
          case HitchHiker.filetypes.wav:
            image2 = this.MaxBitmap(file);
            width2 = image2.Width;
            height2 = image2.Height;
            break;
          default:
            image2 = Image.FromFile(file);
            width2 = image2.Width;
            height2 = image2.Height;
            break;
        }
        int num1 = width2 < this.Thumbsize.Width ? 1 : 0;
        int num2 = height2;
        Size thumbsize = this.Thumbsize;
        int height3 = thumbsize.Height;
        int num3 = num2 < height3 ? 1 : 0;
        if ((num1 & num3) != 0)
        {
          Bitmap bitmap = new Bitmap(width1, height1);
          Graphics graphics = Graphics.FromImage((Image)bitmap);
          graphics.InterpolationMode = (InterpolationMode)this.ThumbInterpMode;
          graphics.DrawImage(image2, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, width2, height2, GraphicsUnit.Pixel);
          graphics.Dispose();
          image2.Dispose();
          image1 = (Image)bitmap;
        }
        else
        {
          float num4 = (float)width2 / (float)height2;
          thumbsize = this.Thumbsize;
          double num5 = (double)thumbsize.Width / (double)this.Thumbsize.Height;
          if (num5 < 1.0)
          {
            float num6 = num4;
            if ((double)num6 < 1.0)
            {
              thumbsize = this.Thumbsize;
              height1 = thumbsize.Height;
              width1 = checked((int)Math.Round((double)unchecked((float)height1 * num4)));
            }
            else if ((double)num6 > 1.0)
            {
              thumbsize = this.Thumbsize;
              width1 = thumbsize.Width;
              height1 = checked((int)Math.Round((double)unchecked((float)width1 / num4)));
            }
            else if ((double)num6 == 1.0)
            {
              thumbsize = this.Thumbsize;
              width1 = thumbsize.Width;
              height1 = checked((int)Math.Round((double)unchecked((float)width1 * num4)));
            }
          }
          else if (num5 > 1.0)
          {
            float num7 = num4;
            if ((double)num7 < 1.0)
            {
              thumbsize = this.Thumbsize;
              height1 = thumbsize.Height;
              width1 = checked((int)Math.Round((double)unchecked((float)height1 * num4)));
            }
            else if ((double)num7 > 1.0)
            {
              thumbsize = this.Thumbsize;
              width1 = thumbsize.Width;
              height1 = checked((int)Math.Round((double)unchecked((float)width1 / num4)));
            }
            else if ((double)num7 == 1.0)
            {
              thumbsize = this.Thumbsize;
              width1 = thumbsize.Width;
              height1 = checked((int)Math.Round((double)unchecked((float)width1 * num4)));
            }
          }
          else if (num5 == 1.0)
          {
            float num8 = num4;
            if ((double)num8 < 1.0)
            {
              thumbsize = this.Thumbsize;
              height1 = thumbsize.Height;
              width1 = checked((int)Math.Round((double)unchecked((float)height1 * num4)));
            }
            else if ((double)num8 > 1.0)
            {
              thumbsize = this.Thumbsize;
              width1 = thumbsize.Width;
              height1 = checked((int)Math.Round((double)unchecked((float)width1 / num4)));
            }
            else if ((double)num8 == 1.0)
            {
              thumbsize = this.Thumbsize;
              width1 = thumbsize.Width;
              height1 = checked((int)Math.Round((double)unchecked((float)width1 * num4)));
            }
          }
          Bitmap bitmap1 = new Bitmap(width1, height1);
          Graphics graphics = Graphics.FromImage((Image)bitmap1);
          graphics.InterpolationMode = (InterpolationMode)this.ThumbInterpMode;
          graphics.DrawImage(image2, new Rectangle(0, 0, bitmap1.Width, bitmap1.Height), 0, 0, width2, height2, GraphicsUnit.Pixel);
          if (this.Filetype == HitchHiker.filetypes.avi)
          {
            Image filmStrip = (Image)LoneRobot.UI.My.Resources.Resources.FilmStrip;
            Bitmap bitmap2 = new Bitmap(bitmap1.Width, bitmap1.Height);
            graphics.DrawImage(filmStrip, 0, 0, bitmap1.Width, bitmap1.Height);
          }
          graphics.Dispose();
          image2.Dispose();
          image1 = (Image)bitmap1;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        image1 = (Image)LoneRobot.UI.My.Resources.Resources.cross;
        ProjectData.ClearProjectError();
      }
      return image1;
    }

    private Image ImageThumbnail(Image thumbimg)
    {
      Image image;
      try
      {
        int height1 = 0;
        int width1 = 0;
        int width2 = thumbimg.Width;
        int height2 = thumbimg.Height;
        if (width2 < this.Thumbsize.Width & height2 < this.Thumbsize.Height)
        {
          Bitmap bitmap = new Bitmap(width2, height2);
          Graphics graphics = Graphics.FromImage((Image)bitmap);
          graphics.InterpolationMode = (InterpolationMode)this.ThumbInterpMode;
          graphics.DrawImage(thumbimg, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, width2, height2, GraphicsUnit.Pixel);
          graphics.Dispose();
          image = (Image)bitmap;
        }
        else
        {
          float num1 = 1f;
          float num2 = (float)width2 / (float)height2;
          double num3 = (double)this.Thumbsize.Width / (double)this.Thumbsize.Height;
          if (num3 < 1.0)
          {
            float num4 = num2;
            if ((double)num4 < 1.0)
            {
              height1 = checked((int)Math.Round((double)unchecked((float)this.Thumbsize.Height * num1)));
              width1 = checked((int)Math.Round((double)unchecked((float)height1 * num2)));
            }
            else if ((double)num4 > 1.0)
            {
              width1 = checked((int)Math.Round((double)unchecked((float)this.Thumbsize.Width * num1)));
              height1 = checked((int)Math.Round((double)unchecked((float)width1 / num2)));
            }
            else if ((double)num4 == 1.0)
            {
              width1 = checked((int)Math.Round((double)unchecked((float)this.Thumbsize.Width * num1)));
              height1 = checked((int)Math.Round((double)unchecked((float)width1 * num2)));
            }
          }
          else if (num3 > 1.0)
          {
            float num5 = num2;
            if ((double)num5 < 1.0)
            {
              height1 = checked((int)Math.Round((double)unchecked((float)this.Thumbsize.Height * num1)));
              width1 = checked((int)Math.Round((double)unchecked((float)height1 * num2)));
            }
            else if ((double)num5 > 1.0)
            {
              width1 = checked((int)Math.Round((double)unchecked((float)this.Thumbsize.Width * num1)));
              height1 = checked((int)Math.Round((double)unchecked((float)width1 / num2)));
            }
            else if ((double)num5 == 1.0)
            {
              width1 = checked((int)Math.Round((double)unchecked((float)this.Thumbsize.Width * num1)));
              height1 = checked((int)Math.Round((double)unchecked((float)width1 * num2)));
            }
          }
          else if (num3 == 1.0)
          {
            float num6 = num2;
            if ((double)num6 < 1.0)
            {
              height1 = checked((int)Math.Round((double)unchecked((float)this.Thumbsize.Height * num1)));
              width1 = checked((int)Math.Round((double)unchecked((float)height1 * num2)));
            }
            else if ((double)num6 > 1.0)
            {
              width1 = checked((int)Math.Round((double)unchecked((float)this.Thumbsize.Width * num1)));
              height1 = checked((int)Math.Round((double)unchecked((float)width1 / num2)));
            }
            else if ((double)num6 == 1.0)
            {
              width1 = checked((int)Math.Round((double)unchecked((float)this.Thumbsize.Width * num1)));
              height1 = checked((int)Math.Round((double)unchecked((float)width1 * num2)));
            }
          }
          Bitmap bitmap1 = new Bitmap(width1, height1);
          Graphics graphics = Graphics.FromImage((Image)bitmap1);
          graphics.InterpolationMode = (InterpolationMode)this.ThumbInterpMode;
          graphics.DrawImage(thumbimg, new Rectangle(0, 0, bitmap1.Width, bitmap1.Height), 0, 0, width2, height2, GraphicsUnit.Pixel);
          if (this.Filetype == HitchHiker.filetypes.avi)
          {
            Image filmStrip = (Image)LoneRobot.UI.My.Resources.Resources.FilmStrip;
            Bitmap bitmap2 = new Bitmap(bitmap1.Width, bitmap1.Height);
            graphics.DrawImage(filmStrip, 0, 0, bitmap1.Width, bitmap1.Height);
          }
          graphics.Dispose();
          thumbimg.Dispose();
          image = (Image)bitmap1;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        if (this.Filetype == HitchHiker.filetypes.wav)
        {
          image = (Image)LoneRobot.UI.My.Resources.Resources.wav;
          ProjectData.ClearProjectError();
        }
        else
        {
          MaxscriptSDK.ExecuteMaxscriptCommand("Print \"Problem Loading Image Thumbnail\"");
          image = (Image)LoneRobot.UI.My.Resources.Resources.cross;
          ProjectData.ClearProjectError();
        }
      }
      return image;
    }

    private void ClearPanel()
    {
      this.ThumbBoard.SuspendLayout();
      try
      {
        foreach (Component control in this.ThumbBoard.Controls)
          control.Dispose();
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.ThumbBoard.Controls.Clear();
      this.ThumbBoard.ResumeLayout();
    }

    private void UpdateDisplay()
    {
      bool showMenu = this.ShowMenu;
      if (showMenu)
        this.ShowMenu = false;
      this.ThumbBoard.SuspendLayout();
      try
      {
        try
        {
          foreach (Component control in this.ThumbBoard.Controls)
            control.Dispose();
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        this.ThumbBoard.Controls.Clear();
        try
        {
          foreach (NamedImage image in this.images)
          {
            Button button1 = new Button();
            if (this.BinglyBongly)
              button1.BackColor = this.RandomColor();
            else
              button1.BackColor = this.ButtonBackColor;
            button1.FlatStyle = FlatStyle.Flat;
            if (!this.ButtonBorder)
              button1.FlatAppearance.BorderSize = 0;
            button1.AllowDrop = false;
            Button button2 = button1;
            Padding padding1 = new Padding(0);
            Padding padding2 = padding1;
            button2.Padding = padding2;
            Button button3 = button1;
            padding1 = new Padding(this.Gap);
            Padding padding3 = padding1;
            button3.Margin = padding3;
            button1.Font = this.HHFont;
            button1.TextImageRelation = this.TextImageRelation;
            if (this.DisplayStyle != HitchHiker.DisplayStyles.Text)
            {
              button1.Image = image.Image;
              button1.ImageAlign = this.ImageAlign;
            }
            button1.Tag = (object)image.FullPath;
            button1.Size = this.Thumbsize;
            string str;
            if (this.ShowFileDataOnButton)
            {
              FileInfo fileInfo = new FileInfo(Conversions.ToString(button1.Tag));
              this.CurrentImageSize = this.Filesize(fileInfo.Length);
              str = "Filename : " + image.FileName + "\r\nPath : " + fileInfo.DirectoryName + "\r\nSize : " + this.Filesize(fileInfo.Length) + "\r\nModified : " + Conversions.ToString(fileInfo.LastWriteTime);
            }
            else
              str = image.FileName;
            switch (this.DisplayStyle)
            {
              case HitchHiker.DisplayStyles.Text:
                button1.Text = str;
                break;
              case HitchHiker.DisplayStyles.IconText:
                button1.Text = str;
                break;
              case HitchHiker.DisplayStyles.ImageText:
                button1.Text = str;
                break;
              default:
                button1.Text = "";
                break;
            }
            button1.TextAlign = this.TextAlign;
            button1.Click += new EventHandler(this.DashButton_Click);
            button1.Paint += new PaintEventHandler(this.borderpaint);
            button1.MouseMove += new MouseEventHandler(this.Thumb_DragDrop);
            button1.MouseHover += new EventHandler(this.Thumb_MouseOver);
            button1.MouseUp += new MouseEventHandler(this.FlowButton_MouseUp);
            this.ThumbBoard.Controls.Add((Control)button1);
          }
        }
        finally
        {
          List<NamedImage>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.ThumbBoard.ResumeLayout();
        this.ShowMenu = showMenu;
      }
      this.ThumbBoard.ResumeLayout();
      this.ShowMenu = showMenu;
      if (this.images.Count == 0)
        this.ThumbBoard.BackgroundImage = (Image)LoneRobot.UI.My.Resources.Resources.directory;
      else
        this.ThumbBoard.BackgroundImage = (Image)null;
      AppSDK.EnableAccelerators();
    }

    private void DashButton_Click(object sender, EventArgs e)
    {
      Button button = (Button)sender;
      HikerPickedEventArgs e1 = new HikerPickedEventArgs(button.Image, Conversions.ToString(button.Tag), this);
      this.FocusedControl = button;
      HitchHiker.ThumbPickedEventHandler thumbPickedEvent = this.ThumbPickedEvent;
      if (thumbPickedEvent != null)
        thumbPickedEvent((object)this, e1);
      AppSDK.EnableAccelerators();
    }

    private void borderpaint(object sender, PaintEventArgs e)
    {
      if (!Conversions.ToBoolean(NewLateBinding.LateGet(sender, (System.Type)null, "focused", new object[0], (string[])null, (System.Type[])null, (bool[])null)))
        return;
      Graphics graphics = e.Graphics;
      Pen pen = new Pen(this.SelectedHighLight, (float)this.SelectedBorderWidth);
      pen.Alignment = PenAlignment.Inset;
      Rectangle rect = new Rectangle(0, 0, Conversions.ToInteger(NewLateBinding.LateGet(sender, (System.Type)null, "width", new object[0], (string[])null, (System.Type[])null, (bool[])null)), Conversions.ToInteger(NewLateBinding.LateGet(sender, (System.Type)null, "height", new object[0], (string[])null, (System.Type[])null, (bool[])null)));
      graphics.DrawRectangle(pen, rect);
      pen.Dispose();
    }

    private void JpgToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Filetype = HitchHiker.filetypes.jpg;
      this.ClearPanel();
      this.ThumbBoard.BackgroundImage = (Image)LoneRobot.UI.My.Resources.Resources.clock;
      this.ThumbBoard.Refresh();
      this.Populate(this.Directory);
      AppSDK.EnableAccelerators();
    }

    private void BmpToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Filetype = HitchHiker.filetypes.bmp;
      this.ClearPanel();
      this.ThumbBoard.BackgroundImage = (Image)LoneRobot.UI.My.Resources.Resources.clock;
      this.ThumbBoard.Refresh();
      this.Populate(this.Directory);
      AppSDK.EnableAccelerators();
    }

    private void TifToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Filetype = HitchHiker.filetypes.tif;
      this.ClearPanel();
      this.ThumbBoard.BackgroundImage = (Image)LoneRobot.UI.My.Resources.Resources.clock;
      this.ThumbBoard.Refresh();
      this.Populate(this.Directory);
      AppSDK.EnableAccelerators();
    }

    private void PngToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Filetype = HitchHiker.filetypes.png;
      this.ClearPanel();
      this.ThumbBoard.BackgroundImage = (Image)LoneRobot.UI.My.Resources.Resources.clock;
      this.ThumbBoard.Refresh();
      this.Populate(this.Directory);
      AppSDK.EnableAccelerators();
    }

    private void RpfMenuItem_Click(object sender, EventArgs e)
    {
      this.Filetype = HitchHiker.filetypes.rpf;
      this.ClearPanel();
      this.ThumbBoard.BackgroundImage = (Image)LoneRobot.UI.My.Resources.Resources.clock;
      this.ThumbBoard.Refresh();
      this.Populate(this.Directory);
      AppSDK.EnableAccelerators();
    }

    private void TgaMenuItem_Click(object sender, EventArgs e)
    {
      this.Filetype = HitchHiker.filetypes.tga;
      this.ClearPanel();
      this.ThumbBoard.BackgroundImage = (Image)LoneRobot.UI.My.Resources.Resources.clock;
      this.ThumbBoard.Refresh();
      this.Populate(this.Directory);
      AppSDK.EnableAccelerators();
    }

    private void AviMenuItem_Click(object sender, EventArgs e)
    {
      this.Filetype = HitchHiker.filetypes.avi;
      this.ClearPanel();
      this.ThumbBoard.BackgroundImage = (Image)LoneRobot.UI.My.Resources.Resources.clock;
      this.ThumbBoard.Refresh();
      this.Populate(this.Directory);
      AppSDK.EnableAccelerators();
    }

    private void WavMenuItem_Click(object sender, EventArgs e)
    {
      this.Filetype = HitchHiker.filetypes.wav;
      this.ClearPanel();
      this.ThumbBoard.BackgroundImage = (Image)LoneRobot.UI.My.Resources.Resources.clock;
      this.ThumbBoard.Refresh();
      this.Populate(this.Directory);
      AppSDK.EnableAccelerators();
    }

    private void PSDMenuItem_Click(object sender, EventArgs e)
    {
      this.Filetype = HitchHiker.filetypes.psd;
      this.ClearPanel();
      this.ThumbBoard.BackgroundImage = (Image)LoneRobot.UI.My.Resources.Resources.clock;
      this.ThumbBoard.Refresh();
      this.Populate(this.Directory);
      AppSDK.EnableAccelerators();
    }

    private void MaxMenuItem_Click(object sender, EventArgs e)
    {
      this.Filetype = HitchHiker.filetypes.max;
      this.ClearPanel();
      this.ThumbBoard.BackgroundImage = (Image)LoneRobot.UI.My.Resources.Resources.clock;
      this.ThumbBoard.Refresh();
      this.Populate(this.Directory);
      AppSDK.EnableAccelerators();
    }

    public Array GetFiles()
    {
      string[] files = new string[checked(this.images.Count - 1 + 1)];
      int num = checked(this.images.Count - 1);
      int index = 0;
      while (index <= num)
      {
        files[index] = this.images[index].FullPath;
        checked { ++index; }
      }
      return (Array)files;
    }

    private bool DetermineIfFileisParsed(FileInfo file)
    {
      if (file != null)
      {
        switch (this.PopulateFilter)
        {
          case HitchHiker.PopulateFilterLogic.Includes:
            if (this.PopulateSearchPart == HitchHiker.PopulateFilterSearch.EndingWith)
              return Path.GetFileNameWithoutExtension(file.Name).EndsWith(this.PopulateFilterPattern, true, (CultureInfo)null);
            return this.PopulateSearchPart == HitchHiker.PopulateFilterSearch.StartingWith ? Path.GetFileNameWithoutExtension(file.Name).StartsWith(this.PopulateFilterPattern, true, (CultureInfo)null) : Path.GetFileNameWithoutExtension(file.Name).Contains(this.PopulateFilterPattern);
          case HitchHiker.PopulateFilterLogic.Excludes:
            if (this.PopulateSearchPart == HitchHiker.PopulateFilterSearch.EndingWith)
              return !Path.GetFileNameWithoutExtension(file.Name).EndsWith(this.PopulateFilterPattern, true, (CultureInfo)null);
            return this.PopulateSearchPart == HitchHiker.PopulateFilterSearch.StartingWith ? !Path.GetFileNameWithoutExtension(file.Name).StartsWith(this.PopulateFilterPattern, true, (CultureInfo)null) : !Path.GetFileNameWithoutExtension(file.Name).Contains(this.PopulateFilterPattern);
          case HitchHiker.PopulateFilterLogic.All:
            return true;
        }
      }
      bool ifFileisParsed;
      return ifFileisParsed;
    }

    private void MaxThreadWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      SynchronizingBackgroundWorker backgroundWorker = (SynchronizingBackgroundWorker)sender;
      FileInfo[] fileInfoArray1 = this.ReturnFileInfoList((string[])e.Argument);
      if (fileInfoArray1 == null)
        return;
      Array.Sort((Array)fileInfoArray1, (IComparer)new HitchHiker.CompareFileInfoEntries(this.SortBy));
      int num = 0;
      FileInfo[] fileInfoArray2 = fileInfoArray1;
      int index = 0;
      while (index < fileInfoArray2.Length)
      {
        FileInfo file = fileInfoArray2[index];
        if (this.DetermineIfFileisParsed(file))
        {
          switch (this.DisplayStyle)
          {
            case HitchHiker.DisplayStyles.Images:
            case HitchHiker.DisplayStyles.ImageText:
              if (!((BackgroundWorker)backgroundWorker).CancellationPending)
              {
                if (this.Filetype == HitchHiker.filetypes.max)
                {
                  FileInfo fileInfo1 = new FileInfo(file.DirectoryName + "\\_assets\\" + Path.GetFileNameWithoutExtension(file.FullName) + ".png");
                  if (fileInfo1.Exists)
                  {
                    this.images.Add(new NamedImage(this.ImageCacheLoadThumbnail(fileInfo1.FullName), file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
                    break;
                  }
                  FileInfo fileInfo2 = new FileInfo(file.DirectoryName + "\\_assets\\maxasset.png");
                  if (fileInfo2.Exists)
                  {
                    this.images.Add(new NamedImage(this.ImageCacheLoadThumbnail(fileInfo2.FullName), file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
                    break;
                  }
                  if (this.Thumbsize.Width < LoneRobot.UI.My.Resources.Resources.MaxL.Width)
                  {
                    this.images.Add(new NamedImage((Image)LoneRobot.UI.My.Resources.Resources.max, file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
                    break;
                  }
                  if (this.Thumbsize.Height < LoneRobot.UI.My.Resources.Resources.MaxL.Height)
                  {
                    this.images.Add(new NamedImage((Image)LoneRobot.UI.My.Resources.Resources.max, file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
                    break;
                  }
                  this.images.Add(new NamedImage((Image)LoneRobot.UI.My.Resources.Resources.MaxL, file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
                  break;
                }
                if (this.Cache == HitchHiker.CacheState.Realtime)
                {
                  this.images.Add(new NamedImage(this.ImageThumbnail(file.FullName), file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
                  break;
                }
                if (!file.DirectoryName.EndsWith("_assets"))
                {
                  string fullName = file.FullName;
                  string path = Path.Combine(this.ScriptPath, "_assets\\");
                  Path.ChangeExtension(fullName, "png");
                  DirectoryInfo directoryInfo = new DirectoryInfo(path);
                  if (!directoryInfo.Exists)
                  {
                    if ((!this.BypassCacheFolderWarning ? MessageBox.Show("Thumbnail Caching is enabled. This will create a folder containing the resized thumbnails on your local drive. Do you want me to do this?", "LoneRobot.HitchHiker", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) : DialogResult.Yes) != DialogResult.Yes)
                      return;
                    directoryInfo.Create();
                  }
                  FileInfo fileInfo = new FileInfo(path + Path.GetFileNameWithoutExtension(file.FullName) + ".png");
                  if (fileInfo.Exists)
                  {
                    if (this.PurgeCache)
                    {
                      this.images.Add(new NamedImage(this.ImageCacheSaveThumbnail(file.FullName, fileInfo.FullName), file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
                      break;
                    }
                    this.images.Add(new NamedImage(this.ImageCacheLoadThumbnail(fileInfo.FullName), file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
                    break;
                  }
                  this.images.Add(new NamedImage(this.ImageCacheSaveThumbnail(file.FullName, fileInfo.FullName), file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
                  break;
                }
                break;
              }
              break;
            case HitchHiker.DisplayStyles.Icons:
            case HitchHiker.DisplayStyles.IconText:
              if (this.Thumbsize.Width < LoneRobot.UI.My.Resources.Resources.jpg.Width | this.Thumbsize.Height < LoneRobot.UI.My.Resources.Resources.jpg.Height)
              {
                Image image;
                switch (this.Filetype)
                {
                  case HitchHiker.filetypes.bmp:
                    image = (Image)LoneRobot.UI.My.Resources.Resources.bmp;
                    break;
                  case HitchHiker.filetypes.jpg:
                    image = (Image)LoneRobot.UI.My.Resources.Resources.jpg;
                    break;
                  case HitchHiker.filetypes.max:
                    image = (Image)LoneRobot.UI.My.Resources.Resources.max;
                    break;
                  case HitchHiker.filetypes.png:
                    image = (Image)LoneRobot.UI.My.Resources.Resources.png;
                    break;
                  case HitchHiker.filetypes.tif:
                    image = (Image)LoneRobot.UI.My.Resources.Resources.tiff;
                    break;
                  case HitchHiker.filetypes.tga:
                    image = (Image)LoneRobot.UI.My.Resources.Resources.tga;
                    break;
                  default:
                    image = (Image)null;
                    break;
                }
                this.images.Add(new NamedImage(image, file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
                break;
              }
              Image image1;
              switch (this.Filetype)
              {
                case HitchHiker.filetypes.bmp:
                  image1 = (Image)LoneRobot.UI.My.Resources.Resources.bmpL;
                  break;
                case HitchHiker.filetypes.jpg:
                  image1 = (Image)LoneRobot.UI.My.Resources.Resources.jpgL;
                  break;
                case HitchHiker.filetypes.max:
                  image1 = (Image)LoneRobot.UI.My.Resources.Resources.MaxL;
                  break;
                case HitchHiker.filetypes.png:
                  image1 = (Image)LoneRobot.UI.My.Resources.Resources.PngL;
                  break;
                case HitchHiker.filetypes.tif:
                  image1 = (Image)LoneRobot.UI.My.Resources.Resources.tiffL;
                  break;
                case HitchHiker.filetypes.tga:
                  image1 = (Image)LoneRobot.UI.My.Resources.Resources.tgaL;
                  break;
                default:
                  image1 = (Image)null;
                  break;
              }
              this.images.Add(new NamedImage(image1, file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
              break;
            default:
              this.images.Add(new NamedImage((Image)null, file.FullName, Path.GetFileNameWithoutExtension(file.FullName)));
              break;
          }
          try
          {
            ((BackgroundWorker)backgroundWorker).ReportProgress(checked((int)Math.Round(unchecked((double)num / (double)fileInfoArray1.Length * 100.0))));
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        checked { ++num; }
        checked { ++index; }
      }
    }

    private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.TableLayoutPanelUC.RowStyles[2].Height = 0.0f;
      this.PurgeCache = false;
      this.UpdateDisplay();
    }

    private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      try
      {
        this.ThumbBoard.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
        this.ThumbBoard.Invalidate();
        this.ProgressUpdate.Value = e.ProgressPercentage;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void ButtonCancel_Click(object sender, EventArgs e)
    {
      if (((BackgroundWorker)this.MaxThreadWorker).IsBusy)
        ((BackgroundWorker)this.MaxThreadWorker).CancelAsync();
      else
        this.AbortMaxLoadProcess = true;
      AppSDK.EnableAccelerators();
    }

    private void RefreshMenuItem_Click(object sender, EventArgs e)
    {
      if ((Control.ModifierKeys & (Keys.KeyCode | Keys.Modifiers) & (Keys) - (this.Cache == HitchHiker.CacheState.Cache ? 1 : 0)) != 0 && MessageBox.Show("Shift Clicking the Refresh Icon will overwrite the thumbnail cache for these images. Are you sure?", "LoneRobot.HitchHiker", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
        this.PurgeCache = true;
      this.ClearPanel();
      this.ThumbBoard.BackgroundImage = (Image)LoneRobot.UI.My.Resources.Resources.clock;
      this.ThumbBoard.Refresh();
      this.Populate(this.Directory);
    }

    private void Dashboard_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right & this.ShowMenu & !((BackgroundWorker)this.MaxThreadWorker).IsBusy)
        this.SearchForMenu.Show((Control)sender, new Point(e.X, e.Y));
      AppSDK.EnableAccelerators();
    }

    private void TinyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Thumbnails = HitchHiker.ThumbNailSize.Tiny;
      this.Populate(this.Directory);
    }

    private void SmallToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Thumbnails = HitchHiker.ThumbNailSize.Small;
      this.Populate(this.Directory);
    }

    private void MediumToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Thumbnails = HitchHiker.ThumbNailSize.Medium;
      this.Populate(this.Directory);
    }

    private void LargeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Thumbnails = HitchHiker.ThumbNailSize.Large;
      this.Populate(this.Directory);
    }

    private void ExtraLargeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Thumbnails = HitchHiker.ThumbNailSize.ExtraLarge;
      this.Populate(this.Directory);
    }

    private void ImagesOnlyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.DisplayStyle = HitchHiker.DisplayStyles.Images;
      this.Populate(this.Directory);
    }

    private void ImagesAndTextToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.DisplayStyle = HitchHiker.DisplayStyles.ImageText;
      this.Populate(this.Directory);
    }

    private void IconsOnlyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.DisplayStyle = HitchHiker.DisplayStyles.Icons;
      this.Populate(this.Directory);
    }

    private void IconsTextToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.DisplayStyle = HitchHiker.DisplayStyles.IconText;
      this.Populate(this.Directory);
    }

    private void TextOnlyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.DisplayStyle = HitchHiker.DisplayStyles.Text;
      this.UpdateDisplay();
    }

    private void ButtonPickDirectory_Click(object sender, EventArgs e)
    {
      if (this.PickDirectory.ShowDialog() != DialogResult.OK)
        return;
      this.Populate(this.PickDirectory.SelectedPath);
    }

    private void FileToolTip_Draw(object sender, DrawToolTipEventArgs e)
    {
      e.DrawBackground();
      e.DrawBorder();
      Brush brush1 = (Brush)new SolidBrush(this.Colorman.GetTextColor());
      Pen pen1 = new Pen(brush1, 2f);
      Brush brush2 = (Brush)new SolidBrush(Color.FromArgb(51, 83, 102));
      Image image;
      switch (this.Filetype)
      {
        case HitchHiker.filetypes.avi:
          image = (Image)LoneRobot.UI.My.Resources.Resources.aviL;
          break;
        case HitchHiker.filetypes.bmp:
          image = (Image)LoneRobot.UI.My.Resources.Resources.bmpL;
          break;
        case HitchHiker.filetypes.jpg:
          image = (Image)LoneRobot.UI.My.Resources.Resources.jpgL;
          break;
        case HitchHiker.filetypes.max:
          image = (Image)LoneRobot.UI.My.Resources.Resources.MaxL;
          break;
        case HitchHiker.filetypes.png:
          image = (Image)LoneRobot.UI.My.Resources.Resources.PngL;
          break;
        case HitchHiker.filetypes.psd:
          image = (Image)LoneRobot.UI.My.Resources.Resources.psd;
          break;
        case HitchHiker.filetypes.tif:
          image = (Image)LoneRobot.UI.My.Resources.Resources.tiffL;
          break;
        case HitchHiker.filetypes.rpf:
          image = (Image)LoneRobot.UI.My.Resources.Resources.RpfL;
          break;
        case HitchHiker.filetypes.tga:
          image = (Image)LoneRobot.UI.My.Resources.Resources.tgaL;
          break;
        case HitchHiker.filetypes.wav:
          image = (Image)LoneRobot.UI.My.Resources.Resources.wavL;
          break;
        default:
          image = (Image)null;
          break;
      }
      Graphics graphics1 = e.Graphics;
      Pen pen2 = pen1;
      Rectangle bounds1 = e.Bounds;
      int width1 = bounds1.Width;
      int height1 = e.Bounds.Height;
      graphics1.DrawRectangle(pen2, 0, 0, width1, height1);
      Graphics graphics2 = e.Graphics;
      Brush brush3 = brush2;
      int width2 = checked(image.Width + 6);
      Rectangle bounds2 = e.Bounds;
      int height2 = checked(bounds2.Height - 6);
      graphics2.FillRectangle(brush3, 3, 3, width2, height2);
      e.Graphics.DrawImage(image, 5, 5, image.Width, image.Height);
      using (StringFormat format = new StringFormat())
      {
        format.Alignment = StringAlignment.Far;
        format.LineAlignment = StringAlignment.Far;
        Rectangle layoutRectangle;
        ref Rectangle local = ref layoutRectangle;
        bounds2 = e.Bounds;
        int width3 = checked(bounds2.Width - 39);
        bounds1 = e.Bounds;
        int height3 = checked(bounds1.Height - 10);
        local = new Rectangle(34, 5, width3, height3);
        e.Graphics.DrawString(e.ToolTipText, this.HHFont, brush1, (RectangleF)layoutRectangle, format);
      }
    }

    private void SortbyFilenameToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.ThumbBoard.BackgroundImage = (Image)LoneRobot.UI.My.Resources.Resources.clock;
      this.SortBy = this.SortBy != HitchHiker.SortByOptions.FileNameAscending ? HitchHiker.SortByOptions.FileNameAscending : HitchHiker.SortByOptions.FileNameDescending;
      switch (this.Filetype)
      {
        case HitchHiker.filetypes.avi:
        case HitchHiker.filetypes.rpf:
        case HitchHiker.filetypes.tga:
        case HitchHiker.filetypes.wav:
          this.ProcessMaxBitmaps((string[])null);
          break;
        default:
          while (!((BackgroundWorker)this.MaxThreadWorker).IsBusy)
            ((BackgroundWorker)this.MaxThreadWorker).RunWorkerAsync();
          break;
      }
    }

    private void SortByFilesizeAscendingToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.ThumbBoard.BackgroundImage = (Image)LoneRobot.UI.My.Resources.Resources.clock;
      this.SortBy = this.SortBy != HitchHiker.SortByOptions.FilesizeAscending ? HitchHiker.SortByOptions.FilesizeAscending : HitchHiker.SortByOptions.FilesizeDescending;
      switch (this.Filetype)
      {
        case HitchHiker.filetypes.avi:
        case HitchHiker.filetypes.rpf:
        case HitchHiker.filetypes.tga:
        case HitchHiker.filetypes.wav:
          this.ProcessMaxBitmaps((string[])null);
          break;
        default:
          while (!((BackgroundWorker)this.MaxThreadWorker).IsBusy)
            ((BackgroundWorker)this.MaxThreadWorker).RunWorkerAsync();
          break;
      }
    }

    private void SortByFilesizeDecendingToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.ThumbBoard.BackgroundImage = (Image)LoneRobot.UI.My.Resources.Resources.clock;
      this.SortBy = HitchHiker.SortByOptions.FilesizeDescending;
      switch (this.Filetype)
      {
        case HitchHiker.filetypes.avi:
        case HitchHiker.filetypes.rpf:
        case HitchHiker.filetypes.tga:
        case HitchHiker.filetypes.wav:
          this.ProcessMaxBitmaps((string[])null);
          break;
        default:
          while (!((BackgroundWorker)this.MaxThreadWorker).IsBusy)
            ((BackgroundWorker)this.MaxThreadWorker).RunWorkerAsync();
          break;
      }
    }

    private void SortByDateToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.ThumbBoard.BackgroundImage = (Image)LoneRobot.UI.My.Resources.Resources.clock;
      this.SortBy = this.SortBy != HitchHiker.SortByOptions.DateAscending ? HitchHiker.SortByOptions.DateAscending : HitchHiker.SortByOptions.DateDescending;
      switch (this.Filetype)
      {
        case HitchHiker.filetypes.avi:
        case HitchHiker.filetypes.rpf:
        case HitchHiker.filetypes.tga:
        case HitchHiker.filetypes.wav:
          this.ProcessMaxBitmaps((string[])null);
          break;
        default:
          while (!((BackgroundWorker)this.MaxThreadWorker).IsBusy)
            ((BackgroundWorker)this.MaxThreadWorker).RunWorkerAsync();
          break;
      }
    }

    private void ToolStripButtonIncExc_CheckedChanged(object sender, EventArgs e)
    {
      switch (this.PopulateFilter)
      {
        case HitchHiker.PopulateFilterLogic.Includes:
          this.PopulateFilter = HitchHiker.PopulateFilterLogic.Excludes;
          this.ToolStripSearchLabel.ForeColor = Color.Red;
          this.Populate(this.Directory);
          break;
        case HitchHiker.PopulateFilterLogic.Excludes:
          this.PopulateFilter = HitchHiker.PopulateFilterLogic.All;
          this.ToolStripSearchLabel.ForeColor = Color.Navy;
          this.Populate(this.Directory);
          break;
        case HitchHiker.PopulateFilterLogic.All:
          this.PopulateFilter = HitchHiker.PopulateFilterLogic.Includes;
          this.ToolStripSearchLabel.ForeColor = Color.GreenYellow;
          this.Populate(this.Directory);
          break;
      }
      AppSDK.EnableAccelerators();
    }

    private void ToolStripButtonLogic_CheckedChanged(object sender, EventArgs e)
    {
      switch (this.PopulateSearchPart)
      {
        case HitchHiker.PopulateFilterSearch.StartingWith:
          this.PopulateSearchPart = HitchHiker.PopulateFilterSearch.EndingWith;
          this.Populate(this.Directory);
          break;
        case HitchHiker.PopulateFilterSearch.EndingWith:
          this.PopulateSearchPart = HitchHiker.PopulateFilterSearch.Contains;
          this.Populate(this.Directory);
          break;
        case HitchHiker.PopulateFilterSearch.Contains:
          this.PopulateSearchPart = HitchHiker.PopulateFilterSearch.StartingWith;
          this.Populate(this.Directory);
          break;
      }
      AppSDK.EnableAccelerators();
    }

    private void TextString_Focus(object sender, EventArgs e) => AppSDK.DisableAccelerators();

    private void TextString_FocusLost(object sender, EventArgs e) => AppSDK.EnableAccelerators();

    private void TextBoxSearchString_TextChanged(object sender, EventArgs e)
    {
      this.PopulateFilterPattern = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type)null, "text", new object[0], (string[])null, (System.Type[])null, (bool[])null));
      if (this.PopulateFilter == HitchHiker.PopulateFilterLogic.All)
        return;
      this.Populate(this.Directory);
    }

    private void ToolStripAbout_Click(object sender, EventArgs e)
    {
      int num = (int)new LoneRobotInfo("HitchHiker V4.3").ShowDialog();
    }

    private void ShowDataToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
      this.ShowFileDataOnButton = this.ShowDataToolStripMenuItem.Checked;
      this.Populate(this.Directory);
    }

    public void XML_LoadSettings()
    {
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(this.ScriptPath + "\\HitchHikerSettings.xml");
        XmlElement firstChild = (XmlElement)xmlDocument.DocumentElement.FirstChild;
        this.Render_CaptureVpt = Conversions.ToBoolean(firstChild.ChildNodes.Item(0).InnerText);
        this.Render_UseCustomBackground = Conversions.ToBoolean(firstChild.ChildNodes.Item(1).InnerText);
        this.Render_SaveAlpha = Conversions.ToBoolean(firstChild.ChildNodes.Item(2).InnerText);
        this.Render_Thumbsize = -(Conversions.ToBoolean(firstChild.ChildNodes.Item(3).InnerText) ? 1 : 0);
        this.Render_CustomBackgroundColor = Color.FromArgb(Conversions.ToInteger(firstChild.ChildNodes.Item(4).Attributes[0].Value), Conversions.ToInteger(firstChild.ChildNodes.Item(4).Attributes[1].Value), Conversions.ToInteger(firstChild.ChildNodes.Item(4).Attributes[2].Value));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public void XML_WriteSettings()
    {
      XmlDocument xmlDocument = new XmlDocument();
      XmlElement element1 = xmlDocument.CreateElement("LoneRobot");
      xmlDocument.AppendChild((XmlNode)element1);
      XmlElement element2 = xmlDocument.CreateElement(nameof(HitchHiker));
      XmlNode xmlNode = element1.AppendChild((XmlNode)element2);
      XmlElement element3 = xmlDocument.CreateElement("Render_Capture");
      element3.InnerText = this.Render_CaptureVpt.ToString();
      xmlNode.AppendChild((XmlNode)element3);
      XmlElement element4 = xmlDocument.CreateElement("UseCustomBackground");
      element4.InnerText = this.Render_UseCustomBackground.ToString();
      xmlNode.AppendChild((XmlNode)element4);
      XmlElement element5 = xmlDocument.CreateElement("SaveAlpha");
      element5.InnerText = this.Render_SaveAlpha.ToString();
      xmlNode.AppendChild((XmlNode)element5);
      XmlElement element6 = xmlDocument.CreateElement("Thumbsize");
      element6.InnerText = this.Render_Thumbsize.ToString();
      xmlNode.AppendChild((XmlNode)element6);
      XmlElement element7 = xmlDocument.CreateElement("CustomBackgroundColor");
      element7.SetAttribute("R", this.Render_CustomBackgroundColor.R.ToString());
      element7.SetAttribute("G", this.Render_CustomBackgroundColor.G.ToString());
      element7.SetAttribute("B", this.Render_CustomBackgroundColor.B.ToString());
      xmlNode.AppendChild((XmlNode)element7);
      xmlDocument.Save(this.ScriptPath + "\\HitchHikerSettings.xml");
    }

    private void AddFavouriteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      StringCollection favourites = this.Favourites;
      if (!favourites.Contains(this.Directory))
      {
        favourites.Add(this.Directory);
        this.XML_SaveFavourites();
        this.ToolStripButtonDirectory.DropDownItems.RemoveByKey("Favourites");
        if (favourites.Count <= 0)
          return;
        ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem("Favourites");
        toolStripMenuItem1.Name = "Favourites";
        foreach (string str in favourites)
        {
          if (MyProject.Computer.FileSystem.DirectoryExists(str))
          {
            ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(str);
            toolStripMenuItem2.Tag = (object)str;
            toolStripMenuItem1.DropDownItems.Add((ToolStripItem)toolStripMenuItem2);
            toolStripMenuItem2.Click += new EventHandler(this.FavouriteItemClicked);
          }
        }
        this.ToolStripButtonDirectory.DropDownItems.Add((ToolStripItem)toolStripMenuItem1);
      }
      else
      {
        int num = (int)MessageBox.Show("This directory is already stored as one of your favourites", nameof(HitchHiker), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void ManageToolStripMenuItem_Click(object sender, EventArgs e)
    {
      HitchHiker HitchHikerRef = this;
      int num = (int)new HitchHikerFavouritesDialog(ref HitchHikerRef).ShowDialog();
    }

    private void CacheThumbnailsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
      if (this.CacheThumbnailsToolStripMenuItem.Checked)
        this.Cache = HitchHiker.CacheState.Cache;
      else
        this.Cache = HitchHiker.CacheState.Realtime;
    }

    public enum filetypes
    {
      avi,
      bmp,
      jpg,
      max,
      png,
      psd,
      tif,
      rpf,
      tga,
      wav,
    }

    public enum ThumbNailSize
    {
      Tiny = 24, // 0x00000018
      Small = 50, // 0x00000032
      Medium = 70, // 0x00000046
      Large = 90, // 0x0000005A
      ExtraLarge = 150, // 0x00000096
    }

    public enum DisplayStyles
    {
      Images,
      Icons,
      Text,
      IconText,
      ImageText,
    }

    public enum SortByOptions
    {
      FileNameAscending,
      FileNameDescending,
      DateAscending,
      DateDescending,
      FilesizeAscending,
      FilesizeDescending,
    }

    public enum Interpolation
    {
      Def,
      Low,
      High,
      Bilinear,
      Bicubic,
      Nearest,
      HQBilinear,
      HQBicubic,
    }

    public enum CacheState
    {
      Realtime,
      Cache,
    }

    public enum PopulateFilterSearch
    {
      StartingWith,
      EndingWith,
      Contains,
    }

    public enum PopulateFilterLogic
    {
      Includes,
      Excludes,
      All,
    }

    public delegate void ThumbPickedEventHandler(object sender, HikerPickedEventArgs e);

    public class CompareFileInfoEntries : IComparer
    {
      private HitchHiker.SortByOptions compareBy;

      public CompareFileInfoEntries(HitchHiker.SortByOptions cBy)
      {
        this.compareBy = HitchHiker.SortByOptions.FileNameAscending;
        this.compareBy = cBy;
      }

      public virtual int Compare(object file1, object file2)
      {
        FileInfo fileInfo1 = (FileInfo)file1;
        FileInfo fileInfo2 = (FileInfo)file2;
        switch (this.compareBy)
        {
          case HitchHiker.SortByOptions.FileNameAscending:
            return string.Compare(fileInfo1.Name, fileInfo2.Name);
          case HitchHiker.SortByOptions.FileNameDescending:
            return string.Compare(fileInfo2.Name, fileInfo1.Name);
          case HitchHiker.SortByOptions.DateAscending:
            return DateTime.Compare(fileInfo1.LastWriteTime, fileInfo2.LastWriteTime);
          case HitchHiker.SortByOptions.DateDescending:
            return DateTime.Compare(fileInfo2.LastWriteTime, fileInfo1.LastWriteTime);
          case HitchHiker.SortByOptions.FilesizeAscending:
            return checked((int)(fileInfo1.Length - fileInfo2.Length));
          case HitchHiker.SortByOptions.FilesizeDescending:
            return checked((int)(fileInfo2.Length - fileInfo1.Length));
          default:
            int num;
            return num;
        }
      }
    }
  }
}
