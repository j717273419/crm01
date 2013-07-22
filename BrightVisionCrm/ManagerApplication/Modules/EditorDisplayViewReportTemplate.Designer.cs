﻿namespace ManagerApplication.Modules
{
    partial class EditorDisplayViewReportTemplate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.reportTemplatePropertyGrid = new ManagerApplication.Modules.ReportTemplatePropertyGrid();
            this.simpleButtonClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveToView = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddLayoutSetting = new DevExpress.XtraEditors.SimpleButton();
            this.cboLayoutElement = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnEditReportDesigner = new DevExpress.XtraEditors.SimpleButton();
            this.gcReportTemplate = new DevExpress.XtraGrid.GridControl();
            this.gvReportTemplate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbxDefaultTemplate = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.simpleButtonReOrder = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblCampaignInformation = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLayoutElement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReportTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReportTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDefaultTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCampaignInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.reportTemplatePropertyGrid);
            this.layoutControl1.Controls.Add(this.simpleButtonClear);
            this.layoutControl1.Controls.Add(this.btnShowReport);
            this.layoutControl1.Controls.Add(this.btnSaveToView);
            this.layoutControl1.Controls.Add(this.btnAddLayoutSetting);
            this.layoutControl1.Controls.Add(this.cboLayoutElement);
            this.layoutControl1.Controls.Add(this.btnEditReportDesigner);
            this.layoutControl1.Controls.Add(this.gcReportTemplate);
            this.layoutControl1.Controls.Add(this.simpleButtonReOrder);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(335, 215, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1105, 623);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // reportTemplatePropertyGrid
            // 
            this.reportTemplatePropertyGrid.ColumnList = null;
            this.reportTemplatePropertyGrid.Location = new System.Drawing.Point(409, 41);
            this.reportTemplatePropertyGrid.Name = "reportTemplatePropertyGrid";
            this.reportTemplatePropertyGrid.Size = new System.Drawing.Size(689, 549);
            this.reportTemplatePropertyGrid.TabIndex = 27;
            this.reportTemplatePropertyGrid.TemplateP = null;
            // 
            // simpleButtonClear
            // 
            this.simpleButtonClear.Location = new System.Drawing.Point(646, 594);
            this.simpleButtonClear.Name = "simpleButtonClear";
            this.simpleButtonClear.Size = new System.Drawing.Size(41, 22);
            this.simpleButtonClear.StyleController = this.layoutControl1;
            this.simpleButtonClear.TabIndex = 26;
            this.simpleButtonClear.Text = "Clear";
            this.simpleButtonClear.Click += new System.EventHandler(this.simpleButtonClear_Click);
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(1025, 594);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(73, 22);
            this.btnShowReport.StyleController = this.layoutControl1;
            this.btnShowReport.TabIndex = 25;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // btnSaveToView
            // 
            this.btnSaveToView.Location = new System.Drawing.Point(948, 594);
            this.btnSaveToView.Name = "btnSaveToView";
            this.btnSaveToView.Size = new System.Drawing.Size(73, 22);
            this.btnSaveToView.StyleController = this.layoutControl1;
            this.btnSaveToView.TabIndex = 24;
            this.btnSaveToView.Text = "Save to View";
            this.btnSaveToView.Click += new System.EventHandler(this.btnSaveToView_Click);
            // 
            // btnAddLayoutSetting
            // 
            this.btnAddLayoutSetting.Location = new System.Drawing.Point(612, 594);
            this.btnAddLayoutSetting.Name = "btnAddLayoutSetting";
            this.btnAddLayoutSetting.Size = new System.Drawing.Size(30, 22);
            this.btnAddLayoutSetting.StyleController = this.layoutControl1;
            this.btnAddLayoutSetting.TabIndex = 22;
            this.btnAddLayoutSetting.Text = "Add";
            this.btnAddLayoutSetting.Click += new System.EventHandler(this.simpleButtonAddLayoutSetting_Click);
            // 
            // cboLayoutElement
            // 
            this.cboLayoutElement.EditValue = "Page Break";
            this.cboLayoutElement.Location = new System.Drawing.Point(409, 594);
            this.cboLayoutElement.Name = "cboLayoutElement";
            this.cboLayoutElement.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLayoutElement.Properties.Items.AddRange(new object[] {
            "Page Break",
            "Text Field",
            "Statistical Component"});
            this.cboLayoutElement.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboLayoutElement.Size = new System.Drawing.Size(199, 20);
            this.cboLayoutElement.StyleController = this.layoutControl1;
            this.cboLayoutElement.TabIndex = 21;
            // 
            // btnEditReportDesigner
            // 
            this.btnEditReportDesigner.Location = new System.Drawing.Point(7, 594);
            this.btnEditReportDesigner.Name = "btnEditReportDesigner";
            this.btnEditReportDesigner.Size = new System.Drawing.Size(126, 22);
            this.btnEditReportDesigner.StyleController = this.layoutControl1;
            this.btnEditReportDesigner.TabIndex = 20;
            this.btnEditReportDesigner.Text = "Edit Report Designer";
            this.btnEditReportDesigner.Click += new System.EventHandler(this.simpleButtonEditReportDesigner_Click);
            // 
            // gcReportTemplate
            // 
            this.gcReportTemplate.Location = new System.Drawing.Point(7, 41);
            this.gcReportTemplate.MainView = this.gvReportTemplate;
            this.gcReportTemplate.Name = "gcReportTemplate";
            this.gcReportTemplate.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbxDefaultTemplate});
            this.gcReportTemplate.Size = new System.Drawing.Size(398, 549);
            this.gcReportTemplate.TabIndex = 7;
            this.gcReportTemplate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReportTemplate});
            // 
            // gvReportTemplate
            // 
            this.gvReportTemplate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.gridColumn5,
            this.gridColumn6});
            this.gvReportTemplate.GridControl = this.gcReportTemplate;
            this.gvReportTemplate.Name = "gvReportTemplate";
            this.gvReportTemplate.OptionsView.ColumnAutoWidth = false;
            this.gvReportTemplate.OptionsView.ShowGroupPanel = false;
            this.gvReportTemplate.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvReportTemplate_RowStyle);
            this.gvReportTemplate.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvReportTemplate_FocusedRowChanged);
            // 
            // id
            // 
            this.id.Caption = "gridColumn2";
            this.id.FieldName = "id";
            this.id.Name = "id";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Template Name";
            this.gridColumn5.FieldName = "template_name";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 300;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Default";
            this.gridColumn6.ColumnEdit = this.cbxDefaultTemplate;
            this.gridColumn6.FieldName = "is_default";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 43;
            // 
            // cbxDefaultTemplate
            // 
            this.cbxDefaultTemplate.AutoHeight = false;
            this.cbxDefaultTemplate.Name = "cbxDefaultTemplate";
            this.cbxDefaultTemplate.EditValueChanged += new System.EventHandler(this.cbxDefaultTemplate_EditValueChanged);
            this.cbxDefaultTemplate.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cbxDefaultTemplate_EditValueChanging);
            // 
            // simpleButtonReOrder
            // 
            this.simpleButtonReOrder.Location = new System.Drawing.Point(859, 594);
            this.simpleButtonReOrder.Name = "simpleButtonReOrder";
            this.simpleButtonReOrder.Size = new System.Drawing.Size(85, 22);
            this.simpleButtonReOrder.StyleController = this.layoutControl1;
            this.simpleButtonReOrder.TabIndex = 23;
            this.simpleButtonReOrder.Text = "Re Order Items";
            this.simpleButtonReOrder.Click += new System.EventHandler(this.simpleButtonReOrder_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.lblCampaignInformation,
            this.layoutControlItem6,
            this.layoutControlItem9,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1105, 623);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.gcReportTemplate;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 18);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(402, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(402, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(402, 569);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Report Templates";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(219, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnEditReportDesigner;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 587);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(130, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(130, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(130, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cboLayoutElement;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(402, 587);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(203, 24);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(203, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(203, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnAddLayoutSetting;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(605, 587);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(34, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(34, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(34, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(130, 587);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(272, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(684, 587);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(168, 26);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnSaveToView;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(941, 587);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(77, 26);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(77, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(77, 26);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "layoutControlItem7";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnShowReport;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(1018, 587);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(77, 26);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(77, 26);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(77, 26);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            // 
            // lblCampaignInformation
            // 
            this.lblCampaignInformation.AllowHotTrack = false;
            this.lblCampaignInformation.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampaignInformation.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCampaignInformation.AppearanceItemCaption.Options.UseFont = true;
            this.lblCampaignInformation.AppearanceItemCaption.Options.UseForeColor = true;
            this.lblCampaignInformation.CustomizationFormText = "Current Campaign:     Current View:";
            this.lblCampaignInformation.Location = new System.Drawing.Point(0, 0);
            this.lblCampaignInformation.Name = "lblCampaignInformation";
            this.lblCampaignInformation.Size = new System.Drawing.Size(1095, 18);
            this.lblCampaignInformation.Text = "Current Campaign:     Current View:";
            this.lblCampaignInformation.TextSize = new System.Drawing.Size(219, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButtonReOrder;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(852, 587);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(89, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(89, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(89, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.simpleButtonClear;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem9";
            this.layoutControlItem9.Location = new System.Drawing.Point(639, 587);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(45, 26);
            this.layoutControlItem9.Text = "layoutControlItem9";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextToControlDistance = 0;
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.reportTemplatePropertyGrid;
            this.layoutControlItem2.CustomizationFormText = "Report Layout Settings";
            this.layoutControlItem2.Location = new System.Drawing.Point(402, 18);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(693, 569);
            this.layoutControlItem2.Text = "Report Layout Settings";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(219, 13);
            // 
            // EditorDisplayViewReportTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "EditorDisplayViewReportTemplate";
            this.Size = new System.Drawing.Size(1105, 623);
            this.Load += new System.EventHandler(this.EditorDisplayViewReportTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboLayoutElement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReportTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReportTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDefaultTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCampaignInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcReportTemplate;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReportTemplate;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit cbxDefaultTemplate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnEditReportDesigner;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.ComboBoxEdit cboLayoutElement;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnAddLayoutSetting;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnShowReport;
        private DevExpress.XtraEditors.SimpleButton btnSaveToView;
        private DevExpress.XtraEditors.SimpleButton simpleButtonReOrder;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.SimpleLabelItem lblCampaignInformation;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClear;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private ReportTemplatePropertyGrid reportTemplatePropertyGrid;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
