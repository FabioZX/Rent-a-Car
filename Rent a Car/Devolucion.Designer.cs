namespace Inutil
{
    partial class Devolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucion));
            this.vehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zXDataSet = new Inutil.ZXDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.vehiculosTableAdapter = new Inutil.ZXDataSetTableAdapters.VehiculosTableAdapter();
            this.vehiculosTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idvehiculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noChasisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noMotorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noPlacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipovehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmarcasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmodelosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcombustibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combustibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTarjetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaFisicaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.personaJuridicaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtransaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ralladurasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cCombustible1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cCombustible2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cCombustible3DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cCombustible4DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gomasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gatoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.roturasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eGomas1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eGomas2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eGomas3DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eGomas4DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaInspeccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDiasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(365, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cedula",
            "Placa"});
            this.comboBox1.Location = new System.Drawing.Point(238, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(632, 430);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Devolver";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // vehiculosTableAdapter
            // 
            this.vehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // vehiculosTableAdapterBindingSource
            // 
            this.vehiculosTableAdapterBindingSource.DataSource = typeof(Inutil.ZXDataSetTableAdapters.VehiculosTableAdapter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvehiculosDataGridViewTextBoxColumn,
            this.noChasisDataGridViewTextBoxColumn,
            this.noMotorDataGridViewTextBoxColumn,
            this.noPlacaDataGridViewTextBoxColumn,
            this.idtipovehiculoDataGridViewTextBoxColumn,
            this.tipoVehiculoDataGridViewTextBoxColumn,
            this.idmarcasDataGridViewTextBoxColumn,
            this.marcasDataGridViewTextBoxColumn,
            this.idmodelosDataGridViewTextBoxColumn,
            this.modelosDataGridViewTextBoxColumn,
            this.idcombustibleDataGridViewTextBoxColumn,
            this.combustibleDataGridViewTextBoxColumn,
            this.idclienteDataGridViewTextBoxColumn,
            this.clienteNombreDataGridViewTextBoxColumn,
            this.cedulaClienteDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.noTarjetaDataGridViewTextBoxColumn,
            this.limiteDataGridViewTextBoxColumn,
            this.personaFisicaDataGridViewCheckBoxColumn,
            this.personaJuridicaDataGridViewCheckBoxColumn,
            this.idempleadoDataGridViewTextBoxColumn,
            this.empleadoNombreDataGridViewTextBoxColumn,
            this.cedulaEmpleadoDataGridViewTextBoxColumn,
            this.tandaDataGridViewTextBoxColumn,
            this.comisionDataGridViewTextBoxColumn,
            this.fechaIngresoDataGridViewTextBoxColumn,
            this.idtransaccionDataGridViewTextBoxColumn,
            this.ralladurasDataGridViewCheckBoxColumn,
            this.cCombustible1DataGridViewCheckBoxColumn,
            this.cCombustible2DataGridViewCheckBoxColumn,
            this.cCombustible3DataGridViewCheckBoxColumn,
            this.cCombustible4DataGridViewCheckBoxColumn,
            this.gomasDataGridViewCheckBoxColumn,
            this.gatoDataGridViewCheckBoxColumn,
            this.roturasDataGridViewCheckBoxColumn,
            this.eGomas1DataGridViewCheckBoxColumn,
            this.eGomas2DataGridViewCheckBoxColumn,
            this.eGomas3DataGridViewCheckBoxColumn,
            this.eGomas4DataGridViewCheckBoxColumn,
            this.fechaInspeccionDataGridViewTextBoxColumn,
            this.noRentaDataGridViewTextBoxColumn,
            this.fechaRentaDataGridViewTextBoxColumn,
            this.fechaDevolucionDataGridViewTextBoxColumn,
            this.costoDiaDataGridViewTextBoxColumn,
            this.cantidadDiasDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehiculosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(696, 319);
            this.dataGridView1.TabIndex = 5;
            // 
            // idvehiculosDataGridViewTextBoxColumn
            // 
            this.idvehiculosDataGridViewTextBoxColumn.DataPropertyName = "idvehiculos";
            this.idvehiculosDataGridViewTextBoxColumn.HeaderText = "idvehiculos";
            this.idvehiculosDataGridViewTextBoxColumn.Name = "idvehiculosDataGridViewTextBoxColumn";
            this.idvehiculosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noChasisDataGridViewTextBoxColumn
            // 
            this.noChasisDataGridViewTextBoxColumn.DataPropertyName = "NoChasis";
            this.noChasisDataGridViewTextBoxColumn.HeaderText = "NoChasis";
            this.noChasisDataGridViewTextBoxColumn.Name = "noChasisDataGridViewTextBoxColumn";
            // 
            // noMotorDataGridViewTextBoxColumn
            // 
            this.noMotorDataGridViewTextBoxColumn.DataPropertyName = "NoMotor";
            this.noMotorDataGridViewTextBoxColumn.HeaderText = "NoMotor";
            this.noMotorDataGridViewTextBoxColumn.Name = "noMotorDataGridViewTextBoxColumn";
            // 
            // noPlacaDataGridViewTextBoxColumn
            // 
            this.noPlacaDataGridViewTextBoxColumn.DataPropertyName = "NoPlaca";
            this.noPlacaDataGridViewTextBoxColumn.HeaderText = "NoPlaca";
            this.noPlacaDataGridViewTextBoxColumn.Name = "noPlacaDataGridViewTextBoxColumn";
            // 
            // idtipovehiculoDataGridViewTextBoxColumn
            // 
            this.idtipovehiculoDataGridViewTextBoxColumn.DataPropertyName = "idtipovehiculo";
            this.idtipovehiculoDataGridViewTextBoxColumn.HeaderText = "idtipovehiculo";
            this.idtipovehiculoDataGridViewTextBoxColumn.Name = "idtipovehiculoDataGridViewTextBoxColumn";
            // 
            // tipoVehiculoDataGridViewTextBoxColumn
            // 
            this.tipoVehiculoDataGridViewTextBoxColumn.DataPropertyName = "TipoVehiculo";
            this.tipoVehiculoDataGridViewTextBoxColumn.HeaderText = "TipoVehiculo";
            this.tipoVehiculoDataGridViewTextBoxColumn.Name = "tipoVehiculoDataGridViewTextBoxColumn";
            // 
            // idmarcasDataGridViewTextBoxColumn
            // 
            this.idmarcasDataGridViewTextBoxColumn.DataPropertyName = "idmarcas";
            this.idmarcasDataGridViewTextBoxColumn.HeaderText = "idmarcas";
            this.idmarcasDataGridViewTextBoxColumn.Name = "idmarcasDataGridViewTextBoxColumn";
            // 
            // marcasDataGridViewTextBoxColumn
            // 
            this.marcasDataGridViewTextBoxColumn.DataPropertyName = "Marcas";
            this.marcasDataGridViewTextBoxColumn.HeaderText = "Marcas";
            this.marcasDataGridViewTextBoxColumn.Name = "marcasDataGridViewTextBoxColumn";
            // 
            // idmodelosDataGridViewTextBoxColumn
            // 
            this.idmodelosDataGridViewTextBoxColumn.DataPropertyName = "idmodelos";
            this.idmodelosDataGridViewTextBoxColumn.HeaderText = "idmodelos";
            this.idmodelosDataGridViewTextBoxColumn.Name = "idmodelosDataGridViewTextBoxColumn";
            // 
            // modelosDataGridViewTextBoxColumn
            // 
            this.modelosDataGridViewTextBoxColumn.DataPropertyName = "Modelos";
            this.modelosDataGridViewTextBoxColumn.HeaderText = "Modelos";
            this.modelosDataGridViewTextBoxColumn.Name = "modelosDataGridViewTextBoxColumn";
            // 
            // idcombustibleDataGridViewTextBoxColumn
            // 
            this.idcombustibleDataGridViewTextBoxColumn.DataPropertyName = "idcombustible";
            this.idcombustibleDataGridViewTextBoxColumn.HeaderText = "idcombustible";
            this.idcombustibleDataGridViewTextBoxColumn.Name = "idcombustibleDataGridViewTextBoxColumn";
            // 
            // combustibleDataGridViewTextBoxColumn
            // 
            this.combustibleDataGridViewTextBoxColumn.DataPropertyName = "Combustible";
            this.combustibleDataGridViewTextBoxColumn.HeaderText = "Combustible";
            this.combustibleDataGridViewTextBoxColumn.Name = "combustibleDataGridViewTextBoxColumn";
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "idcliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "idcliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            // 
            // clienteNombreDataGridViewTextBoxColumn
            // 
            this.clienteNombreDataGridViewTextBoxColumn.DataPropertyName = "ClienteNombre";
            this.clienteNombreDataGridViewTextBoxColumn.HeaderText = "ClienteNombre";
            this.clienteNombreDataGridViewTextBoxColumn.Name = "clienteNombreDataGridViewTextBoxColumn";
            // 
            // cedulaClienteDataGridViewTextBoxColumn
            // 
            this.cedulaClienteDataGridViewTextBoxColumn.DataPropertyName = "CedulaCliente";
            this.cedulaClienteDataGridViewTextBoxColumn.HeaderText = "CedulaCliente";
            this.cedulaClienteDataGridViewTextBoxColumn.Name = "cedulaClienteDataGridViewTextBoxColumn";
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            // 
            // noTarjetaDataGridViewTextBoxColumn
            // 
            this.noTarjetaDataGridViewTextBoxColumn.DataPropertyName = "NoTarjeta";
            this.noTarjetaDataGridViewTextBoxColumn.HeaderText = "NoTarjeta";
            this.noTarjetaDataGridViewTextBoxColumn.Name = "noTarjetaDataGridViewTextBoxColumn";
            // 
            // limiteDataGridViewTextBoxColumn
            // 
            this.limiteDataGridViewTextBoxColumn.DataPropertyName = "Limite";
            this.limiteDataGridViewTextBoxColumn.HeaderText = "Limite";
            this.limiteDataGridViewTextBoxColumn.Name = "limiteDataGridViewTextBoxColumn";
            // 
            // personaFisicaDataGridViewCheckBoxColumn
            // 
            this.personaFisicaDataGridViewCheckBoxColumn.DataPropertyName = "PersonaFisica";
            this.personaFisicaDataGridViewCheckBoxColumn.HeaderText = "PersonaFisica";
            this.personaFisicaDataGridViewCheckBoxColumn.Name = "personaFisicaDataGridViewCheckBoxColumn";
            // 
            // personaJuridicaDataGridViewCheckBoxColumn
            // 
            this.personaJuridicaDataGridViewCheckBoxColumn.DataPropertyName = "PersonaJuridica";
            this.personaJuridicaDataGridViewCheckBoxColumn.HeaderText = "PersonaJuridica";
            this.personaJuridicaDataGridViewCheckBoxColumn.Name = "personaJuridicaDataGridViewCheckBoxColumn";
            // 
            // idempleadoDataGridViewTextBoxColumn
            // 
            this.idempleadoDataGridViewTextBoxColumn.DataPropertyName = "idempleado";
            this.idempleadoDataGridViewTextBoxColumn.HeaderText = "idempleado";
            this.idempleadoDataGridViewTextBoxColumn.Name = "idempleadoDataGridViewTextBoxColumn";
            // 
            // empleadoNombreDataGridViewTextBoxColumn
            // 
            this.empleadoNombreDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoNombre";
            this.empleadoNombreDataGridViewTextBoxColumn.HeaderText = "EmpleadoNombre";
            this.empleadoNombreDataGridViewTextBoxColumn.Name = "empleadoNombreDataGridViewTextBoxColumn";
            // 
            // cedulaEmpleadoDataGridViewTextBoxColumn
            // 
            this.cedulaEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "CedulaEmpleado";
            this.cedulaEmpleadoDataGridViewTextBoxColumn.HeaderText = "CedulaEmpleado";
            this.cedulaEmpleadoDataGridViewTextBoxColumn.Name = "cedulaEmpleadoDataGridViewTextBoxColumn";
            // 
            // tandaDataGridViewTextBoxColumn
            // 
            this.tandaDataGridViewTextBoxColumn.DataPropertyName = "Tanda";
            this.tandaDataGridViewTextBoxColumn.HeaderText = "Tanda";
            this.tandaDataGridViewTextBoxColumn.Name = "tandaDataGridViewTextBoxColumn";
            // 
            // comisionDataGridViewTextBoxColumn
            // 
            this.comisionDataGridViewTextBoxColumn.DataPropertyName = "Comision";
            this.comisionDataGridViewTextBoxColumn.HeaderText = "Comision";
            this.comisionDataGridViewTextBoxColumn.Name = "comisionDataGridViewTextBoxColumn";
            // 
            // fechaIngresoDataGridViewTextBoxColumn
            // 
            this.fechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "FechaIngreso";
            this.fechaIngresoDataGridViewTextBoxColumn.HeaderText = "FechaIngreso";
            this.fechaIngresoDataGridViewTextBoxColumn.Name = "fechaIngresoDataGridViewTextBoxColumn";
            // 
            // idtransaccionDataGridViewTextBoxColumn
            // 
            this.idtransaccionDataGridViewTextBoxColumn.DataPropertyName = "idtransaccion";
            this.idtransaccionDataGridViewTextBoxColumn.HeaderText = "idtransaccion";
            this.idtransaccionDataGridViewTextBoxColumn.Name = "idtransaccionDataGridViewTextBoxColumn";
            // 
            // ralladurasDataGridViewCheckBoxColumn
            // 
            this.ralladurasDataGridViewCheckBoxColumn.DataPropertyName = "Ralladuras";
            this.ralladurasDataGridViewCheckBoxColumn.HeaderText = "Ralladuras";
            this.ralladurasDataGridViewCheckBoxColumn.Name = "ralladurasDataGridViewCheckBoxColumn";
            // 
            // cCombustible1DataGridViewCheckBoxColumn
            // 
            this.cCombustible1DataGridViewCheckBoxColumn.DataPropertyName = "CCombustible1";
            this.cCombustible1DataGridViewCheckBoxColumn.HeaderText = "CCombustible1";
            this.cCombustible1DataGridViewCheckBoxColumn.Name = "cCombustible1DataGridViewCheckBoxColumn";
            // 
            // cCombustible2DataGridViewCheckBoxColumn
            // 
            this.cCombustible2DataGridViewCheckBoxColumn.DataPropertyName = "CCombustible2";
            this.cCombustible2DataGridViewCheckBoxColumn.HeaderText = "CCombustible2";
            this.cCombustible2DataGridViewCheckBoxColumn.Name = "cCombustible2DataGridViewCheckBoxColumn";
            // 
            // cCombustible3DataGridViewCheckBoxColumn
            // 
            this.cCombustible3DataGridViewCheckBoxColumn.DataPropertyName = "CCombustible3";
            this.cCombustible3DataGridViewCheckBoxColumn.HeaderText = "CCombustible3";
            this.cCombustible3DataGridViewCheckBoxColumn.Name = "cCombustible3DataGridViewCheckBoxColumn";
            // 
            // cCombustible4DataGridViewCheckBoxColumn
            // 
            this.cCombustible4DataGridViewCheckBoxColumn.DataPropertyName = "CCombustible4";
            this.cCombustible4DataGridViewCheckBoxColumn.HeaderText = "CCombustible4";
            this.cCombustible4DataGridViewCheckBoxColumn.Name = "cCombustible4DataGridViewCheckBoxColumn";
            // 
            // gomasDataGridViewCheckBoxColumn
            // 
            this.gomasDataGridViewCheckBoxColumn.DataPropertyName = "Gomas";
            this.gomasDataGridViewCheckBoxColumn.HeaderText = "Gomas";
            this.gomasDataGridViewCheckBoxColumn.Name = "gomasDataGridViewCheckBoxColumn";
            // 
            // gatoDataGridViewCheckBoxColumn
            // 
            this.gatoDataGridViewCheckBoxColumn.DataPropertyName = "Gato";
            this.gatoDataGridViewCheckBoxColumn.HeaderText = "Gato";
            this.gatoDataGridViewCheckBoxColumn.Name = "gatoDataGridViewCheckBoxColumn";
            // 
            // roturasDataGridViewCheckBoxColumn
            // 
            this.roturasDataGridViewCheckBoxColumn.DataPropertyName = "Roturas";
            this.roturasDataGridViewCheckBoxColumn.HeaderText = "Roturas";
            this.roturasDataGridViewCheckBoxColumn.Name = "roturasDataGridViewCheckBoxColumn";
            // 
            // eGomas1DataGridViewCheckBoxColumn
            // 
            this.eGomas1DataGridViewCheckBoxColumn.DataPropertyName = "EGomas1";
            this.eGomas1DataGridViewCheckBoxColumn.HeaderText = "EGomas1";
            this.eGomas1DataGridViewCheckBoxColumn.Name = "eGomas1DataGridViewCheckBoxColumn";
            // 
            // eGomas2DataGridViewCheckBoxColumn
            // 
            this.eGomas2DataGridViewCheckBoxColumn.DataPropertyName = "EGomas2";
            this.eGomas2DataGridViewCheckBoxColumn.HeaderText = "EGomas2";
            this.eGomas2DataGridViewCheckBoxColumn.Name = "eGomas2DataGridViewCheckBoxColumn";
            // 
            // eGomas3DataGridViewCheckBoxColumn
            // 
            this.eGomas3DataGridViewCheckBoxColumn.DataPropertyName = "EGomas3";
            this.eGomas3DataGridViewCheckBoxColumn.HeaderText = "EGomas3";
            this.eGomas3DataGridViewCheckBoxColumn.Name = "eGomas3DataGridViewCheckBoxColumn";
            // 
            // eGomas4DataGridViewCheckBoxColumn
            // 
            this.eGomas4DataGridViewCheckBoxColumn.DataPropertyName = "EGomas4";
            this.eGomas4DataGridViewCheckBoxColumn.HeaderText = "EGomas4";
            this.eGomas4DataGridViewCheckBoxColumn.Name = "eGomas4DataGridViewCheckBoxColumn";
            // 
            // fechaInspeccionDataGridViewTextBoxColumn
            // 
            this.fechaInspeccionDataGridViewTextBoxColumn.DataPropertyName = "FechaInspeccion";
            this.fechaInspeccionDataGridViewTextBoxColumn.HeaderText = "FechaInspeccion";
            this.fechaInspeccionDataGridViewTextBoxColumn.Name = "fechaInspeccionDataGridViewTextBoxColumn";
            // 
            // noRentaDataGridViewTextBoxColumn
            // 
            this.noRentaDataGridViewTextBoxColumn.DataPropertyName = "NoRenta";
            this.noRentaDataGridViewTextBoxColumn.HeaderText = "NoRenta";
            this.noRentaDataGridViewTextBoxColumn.Name = "noRentaDataGridViewTextBoxColumn";
            // 
            // fechaRentaDataGridViewTextBoxColumn
            // 
            this.fechaRentaDataGridViewTextBoxColumn.DataPropertyName = "FechaRenta";
            this.fechaRentaDataGridViewTextBoxColumn.HeaderText = "FechaRenta";
            this.fechaRentaDataGridViewTextBoxColumn.Name = "fechaRentaDataGridViewTextBoxColumn";
            // 
            // fechaDevolucionDataGridViewTextBoxColumn
            // 
            this.fechaDevolucionDataGridViewTextBoxColumn.DataPropertyName = "FechaDevolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.HeaderText = "FechaDevolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.Name = "fechaDevolucionDataGridViewTextBoxColumn";
            // 
            // costoDiaDataGridViewTextBoxColumn
            // 
            this.costoDiaDataGridViewTextBoxColumn.DataPropertyName = "CostoDia";
            this.costoDiaDataGridViewTextBoxColumn.HeaderText = "CostoDia";
            this.costoDiaDataGridViewTextBoxColumn.Name = "costoDiaDataGridViewTextBoxColumn";
            // 
            // cantidadDiasDataGridViewTextBoxColumn
            // 
            this.cantidadDiasDataGridViewTextBoxColumn.DataPropertyName = "CantidadDias";
            this.cantidadDiasDataGridViewTextBoxColumn.HeaderText = "CantidadDias";
            this.cantidadDiasDataGridViewTextBoxColumn.Name = "cantidadDiasDataGridViewTextBoxColumn";
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(551, 430);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Inicio";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(137, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Busqueda por:";
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 469);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Devolucion";
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.Devolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosTableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ZXDataSet zXDataSet;
        private ZXDataSetTableAdapters.VehiculosTableAdapter vehiculosTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.BindingSource vehiculosBindingSource;
        private System.Windows.Forms.BindingSource vehiculosTableAdapterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvehiculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChasisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noMotorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPlacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipovehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmarcasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmodelosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcombustibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn combustibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTarjetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn personaFisicaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn personaJuridicaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtransaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ralladurasDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cCombustible1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cCombustible2DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cCombustible3DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cCombustible4DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gomasDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gatoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn roturasDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eGomas1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eGomas2DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eGomas3DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eGomas4DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInspeccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDiasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public MetroFramework.Controls.MetroButton metroButton1;
        public MetroFramework.Controls.MetroButton btnBack;
    }
}