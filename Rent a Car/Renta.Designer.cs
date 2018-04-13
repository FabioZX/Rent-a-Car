namespace Inutil
{
    partial class Renta
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
            System.Windows.Forms.Label fechaDevolucionLabel;
            System.Windows.Forms.Label costoDiaLabel;
            System.Windows.Forms.Label cantidadDiasLabel;
            System.Windows.Forms.Label comentarioLabel;
            System.Windows.Forms.Label comisionLabel;
            System.Windows.Forms.Label fechaRentaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renta));
            this.fechaRentaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zXDataSet = new Inutil.ZXDataSet();
            this.fechaDevolucionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.costoDiaTextBox = new System.Windows.Forms.TextBox();
            this.cantidadDiasTextBox = new System.Windows.Forms.TextBox();
            this.comentarioTextBox = new System.Windows.Forms.TextBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtResultado = new MetroFramework.Controls.MetroTextBox();
            this.txtPor = new MetroFramework.Controls.MetroTextBox();
            this.comisionTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRecibo = new System.Windows.Forms.TextBox();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnReturn = new MetroFramework.Controls.MetroButton();
            this.metroButton = new MetroFramework.Controls.MetroButton();
            this.noRentaTextBox = new System.Windows.Forms.TextBox();
            this.vehiculosTableAdapter = new Inutil.ZXDataSetTableAdapters.VehiculosTableAdapter();
            this.tableAdapterManager = new Inutil.ZXDataSetTableAdapters.TableAdapterManager();
            fechaDevolucionLabel = new System.Windows.Forms.Label();
            costoDiaLabel = new System.Windows.Forms.Label();
            cantidadDiasLabel = new System.Windows.Forms.Label();
            comentarioLabel = new System.Windows.Forms.Label();
            comisionLabel = new System.Windows.Forms.Label();
            fechaRentaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fechaDevolucionLabel
            // 
            fechaDevolucionLabel.AutoSize = true;
            fechaDevolucionLabel.Location = new System.Drawing.Point(22, 129);
            fechaDevolucionLabel.Name = "fechaDevolucionLabel";
            fechaDevolucionLabel.Size = new System.Drawing.Size(97, 13);
            fechaDevolucionLabel.TabIndex = 2;
            fechaDevolucionLabel.Text = "Fecha Devolucion:";
            // 
            // costoDiaLabel
            // 
            costoDiaLabel.AutoSize = true;
            costoDiaLabel.Location = new System.Drawing.Point(63, 163);
            costoDiaLabel.Name = "costoDiaLabel";
            costoDiaLabel.Size = new System.Drawing.Size(56, 13);
            costoDiaLabel.TabIndex = 4;
            costoDiaLabel.Text = "Costo Dia:";
            // 
            // cantidadDiasLabel
            // 
            cantidadDiasLabel.AutoSize = true;
            cantidadDiasLabel.Location = new System.Drawing.Point(43, 199);
            cantidadDiasLabel.Name = "cantidadDiasLabel";
            cantidadDiasLabel.Size = new System.Drawing.Size(76, 13);
            cantidadDiasLabel.TabIndex = 6;
            cantidadDiasLabel.Text = "Cantidad Dias:";
            // 
            // comentarioLabel
            // 
            comentarioLabel.AutoSize = true;
            comentarioLabel.Location = new System.Drawing.Point(56, 234);
            comentarioLabel.Name = "comentarioLabel";
            comentarioLabel.Size = new System.Drawing.Size(63, 13);
            comentarioLabel.TabIndex = 8;
            comentarioLabel.Text = "Comentario:";
            // 
            // comisionLabel
            // 
            comisionLabel.AutoSize = true;
            comisionLabel.Location = new System.Drawing.Point(35, 378);
            comisionLabel.Name = "comisionLabel";
            comisionLabel.Size = new System.Drawing.Size(0, 13);
            comisionLabel.TabIndex = 12;
            // 
            // fechaRentaLabel
            // 
            fechaRentaLabel.AutoSize = true;
            fechaRentaLabel.Location = new System.Drawing.Point(23, 97);
            fechaRentaLabel.Name = "fechaRentaLabel";
            fechaRentaLabel.Size = new System.Drawing.Size(72, 13);
            fechaRentaLabel.TabIndex = 1;
            fechaRentaLabel.Text = "Fecha Renta:";
            // 
            // fechaRentaDateTimePicker
            // 
            this.fechaRentaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vehiculosBindingSource, "FechaRenta", true));
            this.fechaRentaDateTimePicker.Enabled = false;
            this.fechaRentaDateTimePicker.Location = new System.Drawing.Point(125, 90);
            this.fechaRentaDateTimePicker.Name = "fechaRentaDateTimePicker";
            this.fechaRentaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaRentaDateTimePicker.TabIndex = 2;
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
            // fechaDevolucionDateTimePicker
            // 
            this.fechaDevolucionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vehiculosBindingSource, "FechaDevolucion", true));
            this.fechaDevolucionDateTimePicker.Location = new System.Drawing.Point(125, 125);
            this.fechaDevolucionDateTimePicker.Name = "fechaDevolucionDateTimePicker";
            this.fechaDevolucionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDevolucionDateTimePicker.TabIndex = 3;
            // 
            // costoDiaTextBox
            // 
            this.costoDiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "CostoDia", true));
            this.costoDiaTextBox.Location = new System.Drawing.Point(125, 160);
            this.costoDiaTextBox.Name = "costoDiaTextBox";
            this.costoDiaTextBox.Size = new System.Drawing.Size(100, 20);
            this.costoDiaTextBox.TabIndex = 5;
            this.costoDiaTextBox.TextChanged += new System.EventHandler(this.costoDiaTextBox_TextChanged);
            this.costoDiaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costoDiaTextBox_KeyPress);
            this.costoDiaTextBox.Validated += new System.EventHandler(this.costoDiaTextBox_Validated_1);
            // 
            // cantidadDiasTextBox
            // 
            this.cantidadDiasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "CantidadDias", true));
            this.cantidadDiasTextBox.Location = new System.Drawing.Point(125, 196);
            this.cantidadDiasTextBox.Name = "cantidadDiasTextBox";
            this.cantidadDiasTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadDiasTextBox.TabIndex = 7;
            this.cantidadDiasTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadDiasTextBox_KeyPress);
            this.cantidadDiasTextBox.Validated += new System.EventHandler(this.cantidadDiasTextBox_Validated_1);
            // 
            // comentarioTextBox
            // 
            this.comentarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "Comentario", true));
            this.comentarioTextBox.Location = new System.Drawing.Point(125, 231);
            this.comentarioTextBox.Multiline = true;
            this.comentarioTextBox.Name = "comentarioTextBox";
            this.comentarioTextBox.Size = new System.Drawing.Size(200, 102);
            this.comentarioTextBox.TabIndex = 9;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            this.Error.Icon = ((System.Drawing.Icon)(resources.GetObject("Error.Icon")));
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(23, 285);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(25, 23);
            this.txtResultado.TabIndex = 10;
            this.txtResultado.Visible = false;
            // 
            // txtPor
            // 
            this.txtPor.Location = new System.Drawing.Point(23, 324);
            this.txtPor.Name = "txtPor";
            this.txtPor.Size = new System.Drawing.Size(25, 23);
            this.txtPor.TabIndex = 11;
            this.txtPor.Visible = false;
            // 
            // comisionTextBox
            // 
            this.comisionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "Comision", true));
            this.comisionTextBox.Location = new System.Drawing.Point(23, 355);
            this.comisionTextBox.Name = "comisionTextBox";
            this.comisionTextBox.Size = new System.Drawing.Size(25, 20);
            this.comisionTextBox.TabIndex = 13;
            this.comisionTextBox.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRecibo);
            this.groupBox1.Location = new System.Drawing.Point(371, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 270);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // txtRecibo
            // 
            this.txtRecibo.Location = new System.Drawing.Point(6, 12);
            this.txtRecibo.Multiline = true;
            this.txtRecibo.Name = "txtRecibo";
            this.txtRecibo.Size = new System.Drawing.Size(256, 252);
            this.txtRecibo.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(25, 411);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Anterior";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(443, 411);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Inicio";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // metroButton
            // 
            this.metroButton.Location = new System.Drawing.Point(537, 411);
            this.metroButton.Name = "metroButton";
            this.metroButton.Size = new System.Drawing.Size(75, 23);
            this.metroButton.TabIndex = 17;
            this.metroButton.Text = "Recibo";
            this.metroButton.Click += new System.EventHandler(this.metroButton_Click_1);
            // 
            // noRentaTextBox
            // 
            this.noRentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculosBindingSource, "NoRenta", true));
            this.noRentaTextBox.Location = new System.Drawing.Point(23, 381);
            this.noRentaTextBox.Name = "noRentaTextBox";
            this.noRentaTextBox.Size = new System.Drawing.Size(100, 20);
            this.noRentaTextBox.TabIndex = 19;
            this.noRentaTextBox.Visible = false;
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
            // Renta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 465);
            this.Controls.Add(this.noRentaTextBox);
            this.Controls.Add(this.metroButton);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(comisionLabel);
            this.Controls.Add(this.comisionTextBox);
            this.Controls.Add(this.txtPor);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(comentarioLabel);
            this.Controls.Add(this.comentarioTextBox);
            this.Controls.Add(cantidadDiasLabel);
            this.Controls.Add(this.cantidadDiasTextBox);
            this.Controls.Add(costoDiaLabel);
            this.Controls.Add(this.costoDiaTextBox);
            this.Controls.Add(fechaDevolucionLabel);
            this.Controls.Add(this.fechaDevolucionDateTimePicker);
            this.Controls.Add(fechaRentaLabel);
            this.Controls.Add(this.fechaRentaDateTimePicker);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Renta";
            this.Text = "Renta";
            this.Load += new System.EventHandler(this.Renta_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZXDataSet zXDataSet;
        private System.Windows.Forms.BindingSource vehiculosBindingSource;
        private ZXDataSetTableAdapters.VehiculosTableAdapter vehiculosTableAdapter;
        private ZXDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ErrorProvider Error;
        private MetroFramework.Controls.MetroTextBox txtPor;
        private MetroFramework.Controls.MetroTextBox txtResultado;
        private System.Windows.Forms.TextBox comisionTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRecibo;
        private MetroFramework.Controls.MetroButton metroButton;
        private MetroFramework.Controls.MetroButton btnReturn;
        private MetroFramework.Controls.MetroButton btnBack;
        public System.Windows.Forms.DateTimePicker fechaRentaDateTimePicker;
        public System.Windows.Forms.DateTimePicker fechaDevolucionDateTimePicker;
        public System.Windows.Forms.TextBox costoDiaTextBox;
        public System.Windows.Forms.TextBox cantidadDiasTextBox;
        public System.Windows.Forms.TextBox comentarioTextBox;
        public System.Windows.Forms.TextBox noRentaTextBox;
    }
}