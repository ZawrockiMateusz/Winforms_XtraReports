namespace GridView_On_WindowsForms
{
    partial class Form1
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
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.zamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devExpressReportTestDataSet = new GridView_On_WindowsForms.DevExpressReportTestDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnumer_zamowienia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colopis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnazwa_klienta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnReport = new System.Windows.Forms.Button();
            this.zamowieniaTableAdapter = new GridView_On_WindowsForms.DevExpressReportTestDataSetTableAdapters.zamowieniaTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devExpressReportTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // colid
            // 
            this.colid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.zamowieniaBindingSource;
            this.gridControl1.EmbeddedNavigator.TextStringFormat = "Record {1} of {1}";
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(776, 397);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // zamowieniaBindingSource
            // 
            this.zamowieniaBindingSource.DataMember = "zamowienia";
            this.zamowieniaBindingSource.DataSource = this.devExpressReportTestDataSet;
            // 
            // devExpressReportTestDataSet
            // 
            this.devExpressReportTestDataSet.DataSetName = "DevExpressReportTestDataSet";
            this.devExpressReportTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnumer_zamowienia,
            this.colopis,
            this.colnazwa_klienta});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // colnumer_zamowienia
            // 
            this.colnumer_zamowienia.FieldName = "numer_zamowienia";
            this.colnumer_zamowienia.Name = "colnumer_zamowienia";
            this.colnumer_zamowienia.Visible = true;
            this.colnumer_zamowienia.VisibleIndex = 2;
            // 
            // colopis
            // 
            this.colopis.FieldName = "opis";
            this.colopis.Name = "colopis";
            this.colopis.Visible = true;
            this.colopis.VisibleIndex = 3;
            // 
            // colnazwa_klienta
            // 
            this.colnazwa_klienta.FieldName = "nazwa_klienta";
            this.colnazwa_klienta.Name = "colnazwa_klienta";
            this.colnazwa_klienta.Visible = true;
            this.colnazwa_klienta.VisibleIndex = 4;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(12, 415);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(121, 23);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Raportuj";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // zamowieniaTableAdapter
            // 
            this.zamowieniaTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devExpressReportTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnReport;
        private DevExpressReportTestDataSet devExpressReportTestDataSet;
        private System.Windows.Forms.BindingSource zamowieniaBindingSource;
        private DevExpressReportTestDataSetTableAdapters.zamowieniaTableAdapter zamowieniaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnumer_zamowienia;
        private DevExpress.XtraGrid.Columns.GridColumn colopis;
        private DevExpress.XtraGrid.Columns.GridColumn colnazwa_klienta;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}

