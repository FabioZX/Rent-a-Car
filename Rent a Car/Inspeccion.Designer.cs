namespace Inutil
{
    partial class Inspeccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inspeccion));
            this.zXDataSet = new Inutil.ZXDataSet();
            this.vehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculosTableAdapter = new Inutil.ZXDataSetTableAdapters.VehiculosTableAdapter();
            this.tableAdapterManager = new Inutil.ZXDataSetTableAdapters.TableAdapterManager();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.fechaInspeccionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ralladurasMetroCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.gomasMetroCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.gatoMetroCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.roturasMetroCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.eGomas1MetroCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.eGomas2MetroCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.eGomas3MetroCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.eGomas4MetroCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.cCombustible1MetroRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.cCombustible2MetroRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.cCombustible3MetroRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.cCombustible4MetroRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.idtransaccionTextBox = new System.Windows.Forms.TextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.zXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // zXDataSet
            // 
            this.zXDataSet.DataSetName = "ZXDataSet";
            this.zXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculosBindingSource
            // 
            this.vehiculosBindingSource.DataMember = "Vehiculos";
            this.vehiculosBindingSource.DataSource = this.zXDataSet;
            // 
            // vehiculosTableAdapter
            // 
            this.vehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Inutil.ZXDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiculosTableAdapter = this.vehiculosTableAdapter;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Tiene Ralladuras";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(140, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Cantidad Combustible";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 139);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(143, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Tiene Gomas Repuesto";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 177);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Tiene Gato";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 215);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(128, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Tiene Roturas Cristal";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(26, 255);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(93, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Estado Goma1";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(26, 285);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(95, 19);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Estado Goma2";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(26, 317);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(95, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Estado Goma3";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(26, 353);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(95, 19);
            this.metroLabel9.TabIndex = 18;
            this.metroLabel9.Text = "Estado Goma4";
            // 
            // fechaInspeccionDateTimePicker
            // 
            this.fechaInspeccionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vehiculosBindingSource, "FechaInspeccion", true));
            this.fechaInspeccionDateTimePicker.Enabled = false;
            this.fechaInspeccionDateTimePicker.Location = new System.Drawing.Point(188, 391);
            this.fechaInspeccionDateTimePicker.MinDate = new System.DateTime(2015, 2, 1, 0, 0, 0, 0);
            this.fechaInspeccionDateTimePicker.Name = "fechaInspeccionDateTimePicker";
            this.fechaInspeccionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaInspeccionDateTimePicker.TabIndex = 20;
            // 
            // ralladurasMetroCheckBox
            // 
            this.ralladurasMetroCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.vehiculosBindingSource, "Ralladuras", true));
            this.ralladurasMetroCheckBox.Location = new System.Drawing.Point(189, 65);
            this.ralladurasMetroCheckBox.Name = "ralladurasMetroCheckBox";
            this.ralladurasMetroCheckBox.Size = new System.Drawing.Size(104, 24);
            this.ralladurasMetroCheckBox.TabIndex = 21;
            this.ralladurasMetroCheckBox.Text = "NO";
            this.ralladurasMetroCheckBox.UseVisualStyleBackColor = true;
            this.ralladurasMetroCheckBox.CheckedChanged += new System.EventHandler(this.ralladurasMetroCheckBox_CheckedChanged);
            // 
            // gomasMetroCheckBox
            // 
            this.gomasMetroCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.vehiculosBindingSource, "Gomas", true));
            this.gomasMetroCheckBox.Location = new System.Drawing.Point(188, 139);
            this.gomasMetroCheckBox.Name = "gomasMetroCheckBox";
            this.gomasMetroCheckBox.Size = new System.Drawing.Size(104, 24);
            this.gomasMetroCheckBox.TabIndex = 22;
            this.gomasMetroCheckBox.Text = "SI";
            this.gomasMetroCheckBox.UseVisualStyleBackColor = true;
            // 
            // gatoMetroCheckBox
            // 
            this.gatoMetroCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.vehiculosBindingSource, "Gato", true));
            this.gatoMetroCheckBox.Location = new System.Drawing.Point(188, 172);
            this.gatoMetroCheckBox.Name = "gatoMetroCheckBox";
            this.gatoMetroCheckBox.Size = new System.Drawing.Size(104, 24);
            this.gatoMetroCheckBox.TabIndex = 23;
            this.gatoMetroCheckBox.Text = "SI";
            this.gatoMetroCheckBox.UseVisualStyleBackColor = true;
            // 
            // roturasMetroCheckBox
            // 
            this.roturasMetroCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.vehiculosBindingSource, "idtransaccion", true));
            this.roturasMetroCheckBox.Location = new System.Drawing.Point(188, 215);
            this.roturasMetroCheckBox.Name = "roturasMetroCheckBox";
            this.roturasMetroCheckBox.Size = new System.Drawing.Size(104, 24);
            this.roturasMetroCheckBox.TabIndex = 24;
            this.roturasMetroCheckBox.Text = "NO";
            this.roturasMetroCheckBox.UseVisualStyleBackColor = true;
            // 
            // eGomas1MetroCheckBox
            // 
            this.eGomas1MetroCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.vehiculosBindingSource, "EGomas1", true));
            this.eGomas1MetroCheckBox.Location = new System.Drawing.Point(189, 250);
            this.eGomas1MetroCheckBox.Name = "eGomas1MetroCheckBox";
            this.eGomas1MetroCheckBox.Size = new System.Drawing.Size(104, 24);
            this.eGomas1MetroCheckBox.TabIndex = 25;
            this.eGomas1MetroCheckBox.Text = "BUENO";
            this.eGomas1MetroCheckBox.UseVisualStyleBackColor = true;
            // 
            // eGomas2MetroCheckBox
            // 
            this.eGomas2MetroCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.vehiculosBindingSource, "EGomas2", true));
            this.eGomas2MetroCheckBox.Location = new System.Drawing.Point(189, 280);
            this.eGomas2MetroCheckBox.Name = "eGomas2MetroCheckBox";
            this.eGomas2MetroCheckBox.Size = new System.Drawing.Size(104, 24);
            this.eGomas2MetroCheckBox.TabIndex = 26;
            this.eGomas2MetroCheckBox.Text = "BUENO";
            this.eGomas2MetroCheckBox.UseVisualStyleBackColor = true;
            // 
            // eGomas3MetroCheckBox
            // 
            this.eGomas3MetroCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.vehiculosBindingSource, "EGomas3", true));
            this.eGomas3MetroCheckBox.Location = new System.Drawing.Point(189, 310);
            this.eGomas3MetroCheckBox.Name = "eGomas3MetroCheckBox";
            this.eGomas3MetroCheckBox.Size = new System.Drawing.Size(104, 24);
            this.eGomas3MetroCheckBox.TabIndex = 27;
            this.eGomas3MetroCheckBox.Text = "BUENO";
            this.eGomas3MetroCheckBox.UseVisualStyleBackColor = true;
            this.eGomas3MetroCheckBox.CheckedChanged += new System.EventHandler(this.eGomas3MetroCheckBox_CheckedChanged);
            // 
            // eGomas4MetroCheckBox
            // 
            this.eGomas4MetroCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.vehiculosBindingSource, "EGomas4", true));
            this.eGomas4MetroCheckBox.Location = new System.Drawing.Point(189, 346);
            this.eGomas4MetroCheckBox.Name = "eGomas4MetroCheckBox";
            this.eGomas4MetroCheckBox.Size = new System.Drawing.Size(104, 24);
            this.eGomas4MetroCheckBox.TabIndex = 28;
            this.eGomas4MetroCheckBox.Text = "BUENO";
            this.eGomas4MetroCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(24, 434);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Anterior";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(339, 434);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 30;
            this.btnNext.Text = "Siguente";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cCombustible1MetroRadioButton
            // 
            this.cCombustible1MetroRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.vehiculosBindingSource, "CCombustible1", true));
            this.cCombustible1MetroRadioButton.Location = new System.Drawing.Point(189, 99);
            this.cCombustible1MetroRadioButton.Name = "cCombustible1MetroRadioButton";
            this.cCombustible1MetroRadioButton.Size = new System.Drawing.Size(49, 24);
            this.cCombustible1MetroRadioButton.TabIndex = 31;
            this.cCombustible1MetroRadioButton.TabStop = true;
            this.cCombustible1MetroRadioButton.Text = "1/4";
            this.cCombustible1MetroRadioButton.UseVisualStyleBackColor = true;
            // 
            // cCombustible2MetroRadioButton
            // 
            this.cCombustible2MetroRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.vehiculosBindingSource, "CCombustible2", true));
            this.cCombustible2MetroRadioButton.Location = new System.Drawing.Point(233, 99);
            this.cCombustible2MetroRadioButton.Name = "cCombustible2MetroRadioButton";
            this.cCombustible2MetroRadioButton.Size = new System.Drawing.Size(49, 24);
            this.cCombustible2MetroRadioButton.TabIndex = 32;
            this.cCombustible2MetroRadioButton.TabStop = true;
            this.cCombustible2MetroRadioButton.Text = "1/2";
            this.cCombustible2MetroRadioButton.UseVisualStyleBackColor = true;
            // 
            // cCombustible3MetroRadioButton
            // 
            this.cCombustible3MetroRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.vehiculosBindingSource, "CCombustible3", true));
            this.cCombustible3MetroRadioButton.Location = new System.Drawing.Point(288, 99);
            this.cCombustible3MetroRadioButton.Name = "cCombustible3MetroRadioButton";
            this.cCombustible3MetroRadioButton.Size = new System.Drawing.Size(47, 24);
            this.cCombustible3MetroRadioButton.TabIndex = 33;
            this.cCombustible3MetroRadioButton.TabStop = true;
            this.cCombustible3MetroRadioButton.Text = "3/4";
            this.cCombustible3MetroRadioButton.UseVisualStyleBackColor = true;
            // 
            // cCombustible4MetroRadioButton
            // 
            this.cCombustible4MetroRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.vehiculosBindingSource, "CCombustible4", true));
            this.cCombustible4MetroRadioButton.Location = new System.Drawing.Point(335, 99);
            this.cCombustible4MetroRadioButton.Name = "cCombustible4MetroRadioButton";
            this.cCombustible4MetroRadioButton.Size = new System.Drawing.Size(58, 24);
            this.cCombustible4MetroRadioButton.TabIndex = 34;
            this.cCombustible4MetroRadioButton.TabStop = true;
            this.cCombustible4MetroRadioButton.Text = "Lleno";
            this.cCombustible4MetroRadioButton.UseVisualStyleBackColor = true;
            // 
            // idtransaccionTextBox
            // 
            this.idtransaccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "idtransaccion", true));
            this.idtransaccionTextBox.Location = new System.Drawing.Point(288, 156);
            this.idtransaccionTextBox.Name = "idtransaccionTextBox";
            this.idtransaccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.idtransaccionTextBox.TabIndex = 35;
            this.idtransaccionTextBox.Visible = false;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(26, 391);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(107, 19);
            this.metroLabel10.TabIndex = 19;
            this.metroLabel10.Text = "Fecha Inspeccion";
            // 
            // Inspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 477);
            this.Controls.Add(this.idtransaccionTextBox);
            this.Controls.Add(this.cCombustible4MetroRadioButton);
            this.Controls.Add(this.cCombustible3MetroRadioButton);
            this.Controls.Add(this.cCombustible2MetroRadioButton);
            this.Controls.Add(this.cCombustible1MetroRadioButton);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.eGomas4MetroCheckBox);
            this.Controls.Add(this.eGomas3MetroCheckBox);
            this.Controls.Add(this.eGomas2MetroCheckBox);
            this.Controls.Add(this.eGomas1MetroCheckBox);
            this.Controls.Add(this.roturasMetroCheckBox);
            this.Controls.Add(this.gatoMetroCheckBox);
            this.Controls.Add(this.gomasMetroCheckBox);
            this.Controls.Add(this.ralladurasMetroCheckBox);
            this.Controls.Add(this.fechaInspeccionDateTimePicker);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Inspeccion";
            this.Text = "Inspeccion";
            this.Load += new System.EventHandler(this.Inspeccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZXDataSet zXDataSet;
        private System.Windows.Forms.BindingSource vehiculosBindingSource;
        private ZXDataSetTableAdapters.VehiculosTableAdapter vehiculosTableAdapter;
        private ZXDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnNext;
        public System.Windows.Forms.DateTimePicker fechaInspeccionDateTimePicker;
        public MetroFramework.Controls.MetroCheckBox ralladurasMetroCheckBox;
        public MetroFramework.Controls.MetroCheckBox gomasMetroCheckBox;
        public MetroFramework.Controls.MetroCheckBox gatoMetroCheckBox;
        public MetroFramework.Controls.MetroCheckBox roturasMetroCheckBox;
        public MetroFramework.Controls.MetroCheckBox eGomas1MetroCheckBox;
        public MetroFramework.Controls.MetroCheckBox eGomas2MetroCheckBox;
        public MetroFramework.Controls.MetroCheckBox eGomas3MetroCheckBox;
        public MetroFramework.Controls.MetroCheckBox eGomas4MetroCheckBox;
        public MetroFramework.Controls.MetroRadioButton cCombustible1MetroRadioButton;
        public MetroFramework.Controls.MetroRadioButton cCombustible2MetroRadioButton;
        public MetroFramework.Controls.MetroRadioButton cCombustible3MetroRadioButton;
        public MetroFramework.Controls.MetroRadioButton cCombustible4MetroRadioButton;
        public System.Windows.Forms.TextBox idtransaccionTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}