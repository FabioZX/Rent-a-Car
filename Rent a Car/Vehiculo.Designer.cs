namespace Inutil
{
    partial class Vehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehiculo));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tipoVehiculoComboBox = new System.Windows.Forms.ComboBox();
            this.vehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zXDataSet = new Inutil.ZXDataSet();
            this.marcasComboBox = new System.Windows.Forms.ComboBox();
            this.modelosComboBox = new System.Windows.Forms.ComboBox();
            this.combustibleComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.Next = new MetroFramework.Controls.MetroButton();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.vehiculosTableAdapter = new Inutil.ZXDataSetTableAdapters.VehiculosTableAdapter();
            this.tableAdapterManager = new Inutil.ZXDataSetTableAdapters.TableAdapterManager();
            this.noChasisTextBox = new System.Windows.Forms.TextBox();
            this.noMotorTextBox = new System.Windows.Forms.TextBox();
            this.noPlacaTextBox = new System.Windows.Forms.TextBox();
            this.idtipovehiculoTextBox = new System.Windows.Forms.TextBox();
            this.idmarcasTextBox = new System.Windows.Forms.TextBox();
            this.idmodelosTextBox = new System.Windows.Forms.TextBox();
            this.idcombustibleTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 101);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tipo Vehiculo";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 170);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Marca";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(280, 101);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Modelo";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(280, 170);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Combustible";
            // 
            // tipoVehiculoComboBox
            // 
            this.tipoVehiculoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "TipoVehiculo", true));
            this.tipoVehiculoComboBox.FormattingEnabled = true;
            this.tipoVehiculoComboBox.Items.AddRange(new object[] {
            "ECONOMY",
            "COMPACT",
            "MID SIZE",
            "STANDARD",
            "FULL SIZE",
            "LUXURY CAR",
            "MID SIZE SUV",
            "STANDARD SUV",
            "FULL SIZE SUV",
            "MINI VAN"});
            this.tipoVehiculoComboBox.Location = new System.Drawing.Point(116, 99);
            this.tipoVehiculoComboBox.Name = "tipoVehiculoComboBox";
            this.tipoVehiculoComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipoVehiculoComboBox.TabIndex = 9;
            this.tipoVehiculoComboBox.SelectedIndexChanged += new System.EventHandler(this.tipoVehiculoComboBox_SelectedIndexChanged);
            this.tipoVehiculoComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipoVehiculoComboBox_KeyPress);
            this.tipoVehiculoComboBox.Validated += new System.EventHandler(this.tipoVehiculoComboBox_Validated);
            // 
            // vehiculosBindingSource
            // 
            this.vehiculosBindingSource.DataMember = "Vehiculos";
            this.vehiculosBindingSource.DataSource = this.zXDataSet;
            // 
            // zXDataSet
            // 
            this.zXDataSet.DataSetName = "ZXDataSet";
            this.zXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasComboBox
            // 
            this.marcasComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "Marcas", true));
            this.marcasComboBox.FormattingEnabled = true;
            this.marcasComboBox.Items.AddRange(new object[] {
            "HONDA",
            "FORD",
            "HYUNDAI",
            "TOYOTA",
            "VOLKSWAGAN",
            "CHEVROLET",
            "SUBARU",
            "DODGE",
            "CHRYSLER",
            "LINCOLN",
            "ACURA",
            "NISSAN",
            "MERCEDEZ BENZ"});
            this.marcasComboBox.Location = new System.Drawing.Point(116, 170);
            this.marcasComboBox.Name = "marcasComboBox";
            this.marcasComboBox.Size = new System.Drawing.Size(121, 21);
            this.marcasComboBox.TabIndex = 10;
            this.marcasComboBox.SelectedIndexChanged += new System.EventHandler(this.marcasComboBox_SelectedIndexChanged);
            this.marcasComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.marcasComboBox_KeyPress);
            this.marcasComboBox.Validated += new System.EventHandler(this.marcasComboBox_Validated);
            // 
            // modelosComboBox
            // 
            this.modelosComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "Modelos", true));
            this.modelosComboBox.FormattingEnabled = true;
            this.modelosComboBox.Location = new System.Drawing.Point(369, 99);
            this.modelosComboBox.Name = "modelosComboBox";
            this.modelosComboBox.Size = new System.Drawing.Size(121, 21);
            this.modelosComboBox.TabIndex = 11;
            this.modelosComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.modelosComboBox_KeyPress);
            // 
            // combustibleComboBox
            // 
            this.combustibleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "Combustible", true));
            this.combustibleComboBox.FormattingEnabled = true;
            this.combustibleComboBox.Items.AddRange(new object[] {
            "GASOLINA",
            "DIESEL",
            "GLP"});
            this.combustibleComboBox.Location = new System.Drawing.Point(369, 170);
            this.combustibleComboBox.Name = "combustibleComboBox";
            this.combustibleComboBox.Size = new System.Drawing.Size(121, 21);
            this.combustibleComboBox.TabIndex = 12;
            this.combustibleComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combustibleComboBox_KeyPress);
            this.combustibleComboBox.Validated += new System.EventHandler(this.combustibleComboBox_Validated);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(186, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2914699_249px.jpg");
            this.imageList1.Images.SetKeyName(1, "2914694_249px.jpg");
            this.imageList1.Images.SetKeyName(2, "2914703_249px.jpg");
            this.imageList1.Images.SetKeyName(3, "2914821_249px.jpg");
            this.imageList1.Images.SetKeyName(4, "2914825_249px.jpg");
            this.imageList1.Images.SetKeyName(5, "2914678_249px.jpg");
            this.imageList1.Images.SetKeyName(6, "2914815_249px.jpg");
            this.imageList1.Images.SetKeyName(7, "2914687_249px.jpg");
            this.imageList1.Images.SetKeyName(8, "2914680_249px.jpg");
            this.imageList1.Images.SetKeyName(9, "2914719_249px.jpg");
            this.imageList1.Images.SetKeyName(10, "2914667_249px.jpg");
            this.imageList1.Images.SetKeyName(11, "2914733_249px.jpg");
            this.imageList1.Images.SetKeyName(12, "2914727_249px.jpg");
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(36, 343);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Anterior";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(427, 343);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 15;
            this.Next.Text = "Siguente";
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            this.Error.Icon = ((System.Drawing.Icon)(resources.GetObject("Error.Icon")));
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
            // noChasisTextBox
            // 
            this.noChasisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "NoChasis", true));
            this.noChasisTextBox.Location = new System.Drawing.Point(23, 227);
            this.noChasisTextBox.Name = "noChasisTextBox";
            this.noChasisTextBox.Size = new System.Drawing.Size(121, 20);
            this.noChasisTextBox.TabIndex = 16;
            this.noChasisTextBox.Visible = false;
            // 
            // noMotorTextBox
            // 
            this.noMotorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "NoMotor", true));
            this.noMotorTextBox.Location = new System.Drawing.Point(23, 253);
            this.noMotorTextBox.Name = "noMotorTextBox";
            this.noMotorTextBox.Size = new System.Drawing.Size(121, 20);
            this.noMotorTextBox.TabIndex = 17;
            this.noMotorTextBox.Visible = false;
            // 
            // noPlacaTextBox
            // 
            this.noPlacaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "NoPlaca", true));
            this.noPlacaTextBox.Location = new System.Drawing.Point(23, 279);
            this.noPlacaTextBox.Name = "noPlacaTextBox";
            this.noPlacaTextBox.Size = new System.Drawing.Size(121, 20);
            this.noPlacaTextBox.TabIndex = 18;
            this.noPlacaTextBox.Visible = false;
            // 
            // idtipovehiculoTextBox
            // 
            this.idtipovehiculoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "idtipovehiculo", true));
            this.idtipovehiculoTextBox.Location = new System.Drawing.Point(23, 305);
            this.idtipovehiculoTextBox.Name = "idtipovehiculoTextBox";
            this.idtipovehiculoTextBox.Size = new System.Drawing.Size(121, 20);
            this.idtipovehiculoTextBox.TabIndex = 19;
            this.idtipovehiculoTextBox.Visible = false;
            // 
            // idmarcasTextBox
            // 
            this.idmarcasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "idmarcas", true));
            this.idmarcasTextBox.Location = new System.Drawing.Point(369, 216);
            this.idmarcasTextBox.Name = "idmarcasTextBox";
            this.idmarcasTextBox.Size = new System.Drawing.Size(121, 20);
            this.idmarcasTextBox.TabIndex = 20;
            this.idmarcasTextBox.Visible = false;
            // 
            // idmodelosTextBox
            // 
            this.idmodelosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "idmodelos", true));
            this.idmodelosTextBox.Location = new System.Drawing.Point(369, 242);
            this.idmodelosTextBox.Name = "idmodelosTextBox";
            this.idmodelosTextBox.Size = new System.Drawing.Size(121, 20);
            this.idmodelosTextBox.TabIndex = 21;
            this.idmodelosTextBox.Visible = false;
            // 
            // idcombustibleTextBox
            // 
            this.idcombustibleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "idcombustible", true));
            this.idcombustibleTextBox.Location = new System.Drawing.Point(369, 268);
            this.idcombustibleTextBox.Name = "idcombustibleTextBox";
            this.idcombustibleTextBox.Size = new System.Drawing.Size(121, 20);
            this.idcombustibleTextBox.TabIndex = 22;
            this.idcombustibleTextBox.Visible = false;
            // 
            // Vehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 399);
            this.Controls.Add(this.idcombustibleTextBox);
            this.Controls.Add(this.idmodelosTextBox);
            this.Controls.Add(this.idmarcasTextBox);
            this.Controls.Add(this.idtipovehiculoTextBox);
            this.Controls.Add(this.noPlacaTextBox);
            this.Controls.Add(this.noMotorTextBox);
            this.Controls.Add(this.noChasisTextBox);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.combustibleComboBox);
            this.Controls.Add(this.modelosComboBox);
            this.Controls.Add(this.marcasComboBox);
            this.Controls.Add(this.tipoVehiculoComboBox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Vehiculo";
            this.Text = "Vehiculo";
            this.Load += new System.EventHandler(this.Vehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private ZXDataSet zXDataSet;
        private System.Windows.Forms.BindingSource vehiculosBindingSource;
        private ZXDataSetTableAdapters.VehiculosTableAdapter vehiculosTableAdapter;
        private ZXDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton Next;
        private System.Windows.Forms.ErrorProvider Error;
        public System.Windows.Forms.ComboBox tipoVehiculoComboBox;
        public System.Windows.Forms.ComboBox marcasComboBox;
        public System.Windows.Forms.ComboBox modelosComboBox;
        public System.Windows.Forms.ComboBox combustibleComboBox;
        public System.Windows.Forms.TextBox noChasisTextBox;
        public System.Windows.Forms.TextBox idcombustibleTextBox;
        public System.Windows.Forms.TextBox idmodelosTextBox;
        public System.Windows.Forms.TextBox idmarcasTextBox;
        public System.Windows.Forms.TextBox idtipovehiculoTextBox;
        public System.Windows.Forms.TextBox noPlacaTextBox;
        public System.Windows.Forms.TextBox noMotorTextBox;
    }
}