namespace QuanLyVatTuChuyenDeCNPM
{
    partial class frmVatTu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label sOLUONGTONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVatTu));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.buttonThem = new DevExpress.XtraBars.BarButtonItem();
            this.buttonXoa = new DevExpress.XtraBars.BarButtonItem();
            this.buttonSua = new DevExpress.XtraBars.BarButtonItem();
            this.buttonGhi = new DevExpress.XtraBars.BarButtonItem();
            this.buttonRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.buttonHuy = new DevExpress.XtraBars.BarButtonItem();
            this.buttonThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.dS = new QuanLyVatTuChuyenDeCNPM.DS();
            this.bds_VatTu = new System.Windows.Forms.BindingSource(this.components);
            this.vatTuTableAdapter = new QuanLyVatTuChuyenDeCNPM.DSTableAdapters.VatTuTableAdapter();
            this.tableAdapterManager = new QuanLyVatTuChuyenDeCNPM.DSTableAdapters.TableAdapterManager();
            this.gc_VatTu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxVatTu = new System.Windows.Forms.GroupBox();
            this.textEditSoLuongTon = new DevExpress.XtraEditors.TextEdit();
            this.textEditDVT = new DevExpress.XtraEditors.TextEdit();
            this.textEditTenVT = new DevExpress.XtraEditors.TextEdit();
            this.textEditMaVT = new DevExpress.XtraEditors.TextEdit();
            this.bds_CTPhatSinh = new System.Windows.Forms.BindingSource(this.components);
            this.cT_PhatSinhTableAdapter = new QuanLyVatTuChuyenDeCNPM.DSTableAdapters.CT_PhatSinhTableAdapter();
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_VatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_VatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBoxVatTu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLuongTon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTPhatSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(40, 63);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(70, 17);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã vật tư:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(40, 127);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(76, 17);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Tên vật tư:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(560, 127);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(79, 17);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "Đơn vị tính:";
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Location = new System.Drawing.Point(560, 63);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(92, 17);
            sOLUONGTONLabel.TabIndex = 6;
            sOLUONGTONLabel.Text = "Số lượng tồn:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.buttonThem,
            this.buttonXoa,
            this.buttonSua,
            this.buttonGhi,
            this.buttonHuy,
            this.buttonThoat,
            this.buttonRefresh});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // buttonThem
            // 
            this.buttonThem.Caption = "Thêm";
            this.buttonThem.Id = 1;
            this.buttonThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonThem.ImageOptions.Image")));
            this.buttonThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonThem.ImageOptions.LargeImage")));
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonThem_ItemClick);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Caption = "Xoá";
            this.buttonXoa.Id = 2;
            this.buttonXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonXoa.ImageOptions.Image")));
            this.buttonXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonXoa.ImageOptions.LargeImage")));
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonXoa_ItemClick);
            // 
            // buttonSua
            // 
            this.buttonSua.Caption = "Sửa";
            this.buttonSua.Id = 3;
            this.buttonSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonSua.ImageOptions.Image")));
            this.buttonSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonSua.ImageOptions.LargeImage")));
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonSua_ItemClick);
            // 
            // buttonGhi
            // 
            this.buttonGhi.Caption = "Ghi";
            this.buttonGhi.Id = 4;
            this.buttonGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonGhi.ImageOptions.Image")));
            this.buttonGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonGhi.ImageOptions.LargeImage")));
            this.buttonGhi.Name = "buttonGhi";
            this.buttonGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonGhi_ItemClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Caption = "Refresh";
            this.buttonRefresh.Id = 7;
            this.buttonRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.ImageOptions.Image")));
            this.buttonRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.ImageOptions.LargeImage")));
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonRefresh_ItemClick);
            // 
            // buttonHuy
            // 
            this.buttonHuy.Caption = "Huỷ";
            this.buttonHuy.Id = 5;
            this.buttonHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonHuy.ImageOptions.Image")));
            this.buttonHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonHuy.ImageOptions.LargeImage")));
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonHuy_ItemClick);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Caption = "Thoát";
            this.buttonThoat.Id = 6;
            this.buttonThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonThoat.ImageOptions.Image")));
            this.buttonThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("buttonThoat.ImageOptions.LargeImage")));
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1097, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 527);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1097, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 476);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1097, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 476);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.buttonSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_VatTu
            // 
            this.bds_VatTu.DataMember = "VatTu";
            this.bds_VatTu.DataSource = this.dS;
            // 
            // vatTuTableAdapter
            // 
            this.vatTuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_PhatSinhTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhatSinhTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyVatTuChuyenDeCNPM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VatTuTableAdapter = this.vatTuTableAdapter;
            // 
            // gc_VatTu
            // 
            this.gc_VatTu.DataSource = this.bds_VatTu;
            this.gc_VatTu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_VatTu.Location = new System.Drawing.Point(0, 51);
            this.gc_VatTu.MainView = this.gridView1;
            this.gc_VatTu.MenuManager = this.barManager1;
            this.gc_VatTu.Name = "gc_VatTu";
            this.gc_VatTu.Size = new System.Drawing.Size(1097, 274);
            this.gc_VatTu.TabIndex = 5;
            this.gc_VatTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView1.GridControl = this.gc_VatTu;
            this.gridView1.GroupPanelText = "Vật tư";
            this.gridView1.Name = "gridView1";
            // 
            // colMAVT
            // 
            this.colMAVT.AppearanceCell.Options.UseTextOptions = true;
            this.colMAVT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAVT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMAVT.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAVT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 94;
            // 
            // colTENVT
            // 
            this.colTENVT.AppearanceCell.Options.UseTextOptions = true;
            this.colTENVT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENVT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTENVT.AppearanceHeader.Options.UseTextOptions = true;
            this.colTENVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENVT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTENVT.Caption = "Tên vật tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.MinWidth = 25;
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.OptionsColumn.AllowEdit = false;
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 94;
            // 
            // colDVT
            // 
            this.colDVT.AppearanceCell.Options.UseTextOptions = true;
            this.colDVT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDVT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDVT.AppearanceHeader.Options.UseTextOptions = true;
            this.colDVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDVT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDVT.Caption = "Đơn vị tính";
            this.colDVT.FieldName = "DVT";
            this.colDVT.MinWidth = 25;
            this.colDVT.Name = "colDVT";
            this.colDVT.OptionsColumn.AllowEdit = false;
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 94;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.AppearanceCell.Options.UseTextOptions = true;
            this.colSOLUONGTON.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOLUONGTON.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSOLUONGTON.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOLUONGTON.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOLUONGTON.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSOLUONGTON.Caption = "Số lượng tồn";
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.MinWidth = 25;
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.OptionsColumn.AllowEdit = false;
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            this.colSOLUONGTON.Width = 94;
            // 
            // groupBoxVatTu
            // 
            this.groupBoxVatTu.Controls.Add(sOLUONGTONLabel);
            this.groupBoxVatTu.Controls.Add(this.textEditSoLuongTon);
            this.groupBoxVatTu.Controls.Add(dVTLabel);
            this.groupBoxVatTu.Controls.Add(this.textEditDVT);
            this.groupBoxVatTu.Controls.Add(tENVTLabel);
            this.groupBoxVatTu.Controls.Add(this.textEditTenVT);
            this.groupBoxVatTu.Controls.Add(mAVTLabel);
            this.groupBoxVatTu.Controls.Add(this.textEditMaVT);
            this.groupBoxVatTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxVatTu.Location = new System.Drawing.Point(0, 325);
            this.groupBoxVatTu.Name = "groupBoxVatTu";
            this.groupBoxVatTu.Size = new System.Drawing.Size(1097, 202);
            this.groupBoxVatTu.TabIndex = 6;
            this.groupBoxVatTu.TabStop = false;
            this.groupBoxVatTu.Enter += new System.EventHandler(this.groupBoxVatTu_Enter);
            // 
            // textEditSoLuongTon
            // 
            this.textEditSoLuongTon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_VatTu, "SOLUONGTON", true));
            this.textEditSoLuongTon.Location = new System.Drawing.Point(690, 60);
            this.textEditSoLuongTon.MenuManager = this.barManager1;
            this.textEditSoLuongTon.Name = "textEditSoLuongTon";
            this.textEditSoLuongTon.Size = new System.Drawing.Size(146, 22);
            this.textEditSoLuongTon.TabIndex = 7;
            // 
            // textEditDVT
            // 
            this.textEditDVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_VatTu, "DVT", true));
            this.textEditDVT.Location = new System.Drawing.Point(690, 124);
            this.textEditDVT.MenuManager = this.barManager1;
            this.textEditDVT.Name = "textEditDVT";
            this.textEditDVT.Size = new System.Drawing.Size(146, 22);
            this.textEditDVT.TabIndex = 5;
            // 
            // textEditTenVT
            // 
            this.textEditTenVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_VatTu, "TENVT", true));
            this.textEditTenVT.Location = new System.Drawing.Point(151, 124);
            this.textEditTenVT.MenuManager = this.barManager1;
            this.textEditTenVT.Name = "textEditTenVT";
            this.textEditTenVT.Size = new System.Drawing.Size(154, 22);
            this.textEditTenVT.TabIndex = 3;
            // 
            // textEditMaVT
            // 
            this.textEditMaVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_VatTu, "MAVT", true));
            this.textEditMaVT.Location = new System.Drawing.Point(151, 60);
            this.textEditMaVT.MenuManager = this.barManager1;
            this.textEditMaVT.Name = "textEditMaVT";
            this.textEditMaVT.Size = new System.Drawing.Size(154, 22);
            this.textEditMaVT.TabIndex = 1;
            // 
            // bds_CTPhatSinh
            // 
            this.bds_CTPhatSinh.DataMember = "FK_CT_PhatSinh_VatTu";
            this.bds_CTPhatSinh.DataSource = this.bds_VatTu;
            // 
            // cT_PhatSinhTableAdapter
            // 
            this.cT_PhatSinhTableAdapter.ClearBeforeFill = true;
            // 
            // frmVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 547);
            this.Controls.Add(this.groupBoxVatTu);
            this.Controls.Add(this.gc_VatTu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmVatTu";
            this.Text = "frmVatTu";
            this.Load += new System.EventHandler(this.frmVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_VatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_VatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBoxVatTu.ResumeLayout(false);
            this.groupBoxVatTu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLuongTon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTPhatSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem buttonThem;
        private DevExpress.XtraBars.BarButtonItem buttonXoa;
        private DevExpress.XtraBars.BarButtonItem buttonSua;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem buttonGhi;
        private DevExpress.XtraBars.BarButtonItem buttonHuy;
        private DevExpress.XtraBars.BarButtonItem buttonThoat;
        private DevExpress.XtraBars.Bar bar4;
        private System.Windows.Forms.BindingSource bds_VatTu;
        private DS dS;
        private DSTableAdapters.VatTuTableAdapter vatTuTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gc_VatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBoxVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraEditors.TextEdit textEditDVT;
        private DevExpress.XtraEditors.TextEdit textEditTenVT;
        private DevExpress.XtraEditors.TextEdit textEditMaVT;
        private System.Windows.Forms.BindingSource bds_CTPhatSinh;
        private DSTableAdapters.CT_PhatSinhTableAdapter cT_PhatSinhTableAdapter;
        private DevExpress.XtraBars.BarButtonItem buttonRefresh;
        private DevExpress.XtraEditors.TextEdit textEditSoLuongTon;
    }
}