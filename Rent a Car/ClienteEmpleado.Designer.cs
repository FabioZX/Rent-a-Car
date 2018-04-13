namespace Inutil
{
    partial class ClienteEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteEmpleado));
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.zXDataSet = new Inutil.ZXDataSet();
            this.vehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculosTableAdapter = new Inutil.ZXDataSetTableAdapters.VehiculosTableAdapter();
            this.tableAdapterManager = new Inutil.ZXDataSetTableAdapters.TableAdapterManager();
            this.clienteNombreTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.limiteTextBox = new System.Windows.Forms.TextBox();
            this.personaFisicaMetroRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.personaJuridicaMetroRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.cedulaClienteMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.noTarjetaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.empleadoNombreTextBox = new System.Windows.Forms.TextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cedulaEmpleadoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tandaComboBox = new System.Windows.Forms.ComboBox();
            this.comisionTextBox = new System.Windows.Forms.TextBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.idclienteTextBox = new System.Windows.Forms.TextBox();
            this.idempleadoTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.zXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 351);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Anterior";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(578, 351);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Siguente";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nombre Cliente";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Correo ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 154);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Cedula";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 191);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "No.Tarjeta";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 227);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(92, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Limite Credito";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 261);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(90, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Persona Fisica";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 298);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(103, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Persona Juridica";
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
            // clienteNombreTextBox
            // 
            this.clienteNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "ClienteNombre", true));
            this.clienteNombreTextBox.Location = new System.Drawing.Point(132, 80);
            this.clienteNombreTextBox.Name = "clienteNombreTextBox";
            this.clienteNombreTextBox.Size = new System.Drawing.Size(187, 20);
            this.clienteNombreTextBox.TabIndex = 13;
            this.clienteNombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clienteNombreTextBox_KeyPress);
            this.clienteNombreTextBox.Validated += new System.EventHandler(this.clienteNombreTextBox_Validated);
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(132, 120);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(187, 20);
            this.correoTextBox.TabIndex = 15;
            this.correoTextBox.Validated += new System.EventHandler(this.correoTextBox_Validated);
            // 
            // limiteTextBox
            // 
            this.limiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "Limite", true));
            this.limiteTextBox.Location = new System.Drawing.Point(132, 228);
            this.limiteTextBox.Name = "limiteTextBox";
            this.limiteTextBox.Size = new System.Drawing.Size(187, 20);
            this.limiteTextBox.TabIndex = 17;
            this.limiteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limiteTextBox_KeyPress);
            this.limiteTextBox.Validated += new System.EventHandler(this.limiteTextBox_Validated);
            // 
            // personaFisicaMetroRadioButton
            // 
            this.personaFisicaMetroRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.vehiculosBindingSource, "PersonaFisica", true));
            this.personaFisicaMetroRadioButton.Location = new System.Drawing.Point(132, 262);
            this.personaFisicaMetroRadioButton.Name = "personaFisicaMetroRadioButton";
            this.personaFisicaMetroRadioButton.Size = new System.Drawing.Size(104, 24);
            this.personaFisicaMetroRadioButton.TabIndex = 18;
            this.personaFisicaMetroRadioButton.TabStop = true;
            this.personaFisicaMetroRadioButton.UseVisualStyleBackColor = true;
            // 
            // personaJuridicaMetroRadioButton
            // 
            this.personaJuridicaMetroRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.vehiculosBindingSource, "PersonaJuridica", true));
            this.personaJuridicaMetroRadioButton.Location = new System.Drawing.Point(132, 292);
            this.personaJuridicaMetroRadioButton.Name = "personaJuridicaMetroRadioButton";
            this.personaJuridicaMetroRadioButton.Size = new System.Drawing.Size(104, 24);
            this.personaJuridicaMetroRadioButton.TabIndex = 19;
            this.personaJuridicaMetroRadioButton.TabStop = true;
            this.personaJuridicaMetroRadioButton.UseVisualStyleBackColor = true;
            // 
            // cedulaClienteMaskedTextBox
            // 
            this.cedulaClienteMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "CedulaCliente", true));
            this.cedulaClienteMaskedTextBox.Location = new System.Drawing.Point(132, 155);
            this.cedulaClienteMaskedTextBox.Mask = "000-0000000-0";
            this.cedulaClienteMaskedTextBox.Name = "cedulaClienteMaskedTextBox";
            this.cedulaClienteMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cedulaClienteMaskedTextBox.TabIndex = 20;
            this.cedulaClienteMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedulaClienteMaskedTextBox_KeyPress);
            this.cedulaClienteMaskedTextBox.Validated += new System.EventHandler(this.cedulaClienteMaskedTextBox_Validated);
            // 
            // noTarjetaMaskedTextBox
            // 
            this.noTarjetaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "NoTarjeta", true));
            this.noTarjetaMaskedTextBox.Location = new System.Drawing.Point(132, 192);
            this.noTarjetaMaskedTextBox.Mask = "0000 0000 0000 0000";
            this.noTarjetaMaskedTextBox.Name = "noTarjetaMaskedTextBox";
            this.noTarjetaMaskedTextBox.Size = new System.Drawing.Size(112, 20);
            this.noTarjetaMaskedTextBox.TabIndex = 21;
            this.noTarjetaMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noTarjetaMaskedTextBox_KeyPress);
            this.noTarjetaMaskedTextBox.Validated += new System.EventHandler(this.noTarjetaMaskedTextBox_Validated);
            // 
            // empleadoNombreTextBox
            // 
            this.empleadoNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "EmpleadoNombre", true));
            this.empleadoNombreTextBox.Location = new System.Drawing.Point(484, 80);
            this.empleadoNombreTextBox.Name = "empleadoNombreTextBox";
            this.empleadoNombreTextBox.Size = new System.Drawing.Size(187, 20);
            this.empleadoNombreTextBox.TabIndex = 22;
            this.empleadoNombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empleadoNombreTextBox_KeyPress);
            this.empleadoNombreTextBox.Validated += new System.EventHandler(this.empleadoNombreTextBox_Validated);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(355, 80);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(123, 19);
            this.metroLabel8.TabIndex = 23;
            this.metroLabel8.Text = "Nombre Empleado";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(355, 120);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(50, 19);
            this.metroLabel9.TabIndex = 24;
            this.metroLabel9.Text = "Cedula";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(355, 155);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(43, 19);
            this.metroLabel10.TabIndex = 25;
            this.metroLabel10.Text = "Tanda";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(355, 192);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(64, 19);
            this.metroLabel11.TabIndex = 26;
            this.metroLabel11.Text = "Comision";
            // 
            // cedulaEmpleadoMaskedTextBox
            // 
            this.cedulaEmpleadoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "CedulaEmpleado", true));
            this.cedulaEmpleadoMaskedTextBox.Location = new System.Drawing.Point(484, 120);
            this.cedulaEmpleadoMaskedTextBox.Mask = "000-0000000-0";
            this.cedulaEmpleadoMaskedTextBox.Name = "cedulaEmpleadoMaskedTextBox";
            this.cedulaEmpleadoMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cedulaEmpleadoMaskedTextBox.TabIndex = 27;
            this.cedulaEmpleadoMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cedulaEmpleadoMaskedTextBox_KeyPress);
            this.cedulaEmpleadoMaskedTextBox.Validated += new System.EventHandler(this.cedulaEmpleadoMaskedTextBox_Validated);
            // 
            // tandaComboBox
            // 
            this.tandaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "Tanda", true));
            this.tandaComboBox.FormattingEnabled = true;
            this.tandaComboBox.Items.AddRange(new object[] {
            "DIURNA",
            "NOCTURNA"});
            this.tandaComboBox.Location = new System.Drawing.Point(484, 155);
            this.tandaComboBox.Name = "tandaComboBox";
            this.tandaComboBox.Size = new System.Drawing.Size(121, 21);
            this.tandaComboBox.TabIndex = 28;
            this.tandaComboBox.SelectedIndexChanged += new System.EventHandler(this.tandaComboBox_SelectedIndexChanged);
            this.tandaComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tandaComboBox_KeyPress);
            this.tandaComboBox.Validated += new System.EventHandler(this.tandaComboBox_Validated);
            // 
            // comisionTextBox
            // 
            this.comisionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "Comision", true));
            this.comisionTextBox.Location = new System.Drawing.Point(484, 192);
            this.comisionTextBox.Name = "comisionTextBox";
            this.comisionTextBox.ReadOnly = true;
            this.comisionTextBox.Size = new System.Drawing.Size(34, 20);
            this.comisionTextBox.TabIndex = 29;
            this.comisionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comisionTextBox_KeyPress);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            this.Error.Icon = ((System.Drawing.Icon)(resources.GetObject("Error.Icon")));
            // 
            // idclienteTextBox
            // 
            this.idclienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "idcliente", true));
            this.idclienteTextBox.Location = new System.Drawing.Point(484, 228);
            this.idclienteTextBox.Name = "idclienteTextBox";
            this.idclienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.idclienteTextBox.TabIndex = 30;
            this.idclienteTextBox.Visible = false;
            // 
            // idempleadoTextBox
            // 
            this.idempleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "idempleado", true));
            this.idempleadoTextBox.Location = new System.Drawing.Point(484, 266);
            this.idempleadoTextBox.Name = "idempleadoTextBox";
            this.idempleadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idempleadoTextBox.TabIndex = 31;
            this.idempleadoTextBox.Visible = false;
            // 
            // ClienteEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 394);
            this.Controls.Add(this.idempleadoTextBox);
            this.Controls.Add(this.idclienteTextBox);
            this.Controls.Add(this.comisionTextBox);
            this.Controls.Add(this.tandaComboBox);
            this.Controls.Add(this.cedulaEmpleadoMaskedTextBox);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.empleadoNombreTextBox);
            this.Controls.Add(this.noTarjetaMaskedTextBox);
            this.Controls.Add(this.cedulaClienteMaskedTextBox);
            this.Controls.Add(this.personaJuridicaMetroRadioButton);
            this.Controls.Add(this.personaFisicaMetroRadioButton);
            this.Controls.Add(this.limiteTextBox);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(this.clienteNombreTextBox);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "ClienteEmpleado";
            this.Text = "Cliente                                     Empleado";
            this.Load += new System.EventHandler(this.ClienteEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnNext;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private ZXDataSet zXDataSet;
        private System.Windows.Forms.BindingSource vehiculosBindingSource;
        private ZXDataSetTableAdapters.VehiculosTableAdapter vehiculosTableAdapter;
        private ZXDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.ErrorProvider Error;
        public System.Windows.Forms.TextBox clienteNombreTextBox;
        public System.Windows.Forms.MaskedTextBox cedulaClienteMaskedTextBox;
        public System.Windows.Forms.TextBox correoTextBox;
        public System.Windows.Forms.TextBox limiteTextBox;
        public MetroFramework.Controls.MetroRadioButton personaFisicaMetroRadioButton;
        public MetroFramework.Controls.MetroRadioButton personaJuridicaMetroRadioButton;
        public System.Windows.Forms.MaskedTextBox noTarjetaMaskedTextBox;
        public System.Windows.Forms.TextBox empleadoNombreTextBox;
        public System.Windows.Forms.MaskedTextBox cedulaEmpleadoMaskedTextBox;
        public System.Windows.Forms.ComboBox tandaComboBox;
        public System.Windows.Forms.TextBox comisionTextBox;
        public System.Windows.Forms.TextBox idempleadoTextBox;
        public System.Windows.Forms.TextBox idclienteTextBox;
    }
}