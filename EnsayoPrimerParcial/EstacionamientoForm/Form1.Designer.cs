
namespace EstacionamientoForm
{
    partial class FrmEstacionamiento
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbTipoMoto = new System.Windows.Forms.ComboBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lstVehiculos = new System.Windows.Forms.ListBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNombreEstacionamiento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(73, 373);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 29);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(33, 41);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(95, 20);
            this.lblTipoVehiculo.TabIndex = 1;
            this.lblTipoVehiculo.Text = "TipoVehiculo";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(53, 86);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(58, 20);
            this.lblPatente.TabIndex = 2;
            this.lblPatente.Text = "Patente";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(53, 119);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(75, 20);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "TipoMoto";
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(135, 41);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(151, 28);
            this.cmbTipoVehiculo.TabIndex = 4;
            this.cmbTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVehiculo_SelectedIndexChanged);
            // 
            // cmbTipoMoto
            // 
            this.cmbTipoMoto.FormattingEnabled = true;
            this.cmbTipoMoto.Location = new System.Drawing.Point(124, 119);
            this.cmbTipoMoto.Name = "cmbTipoMoto";
            this.cmbTipoMoto.Size = new System.Drawing.Size(151, 28);
            this.cmbTipoMoto.TabIndex = 5;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(135, 79);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(125, 27);
            this.txtPatente.TabIndex = 6;
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.FormattingEnabled = true;
            this.lstVehiculos.ItemHeight = 20;
            this.lstVehiculos.Location = new System.Drawing.Point(417, 88);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(534, 324);
            this.lstVehiculos.TabIndex = 7;
            this.lstVehiculos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstVehiculos_MouseDoubleClick);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(281, 120);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(125, 27);
            this.txtMarca.TabIndex = 8;
            // 
            // txtNombreEstacionamiento
            // 
            this.txtNombreEstacionamiento.Location = new System.Drawing.Point(417, 30);
            this.txtNombreEstacionamiento.Name = "txtNombreEstacionamiento";
            this.txtNombreEstacionamiento.Size = new System.Drawing.Size(542, 27);
            this.txtNombreEstacionamiento.TabIndex = 9;
            // 
            // FrmEstacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.txtNombreEstacionamiento);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lstVehiculos);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.cmbTipoMoto);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FrmEstacionamiento";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmEstacionamiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.ComboBox cmbTipoMoto;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.ListBox lstVehiculos;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtNombreEstacionamiento;
    }
}

