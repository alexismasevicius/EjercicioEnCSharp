namespace ComiqueriaApp
{
    partial class PrincipalForm
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
            this.listBoxProductos = new System.Windows.Forms.ListBox();
            this.richTextBoxVentas = new System.Windows.Forms.RichTextBox();
            this.groupBoxAcciones = new System.Windows.Forms.GroupBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.richTextBoxDetalle = new System.Windows.Forms.RichTextBox();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.groupBoxAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxProductos
            // 
            this.listBoxProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxProductos.FormattingEnabled = true;
            this.listBoxProductos.ItemHeight = 16;
            this.listBoxProductos.Location = new System.Drawing.Point(17, 53);
            this.listBoxProductos.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxProductos.Name = "listBoxProductos";
            this.listBoxProductos.Size = new System.Drawing.Size(567, 276);
            this.listBoxProductos.TabIndex = 0;
            this.listBoxProductos.SelectedIndexChanged += new System.EventHandler(this.ListBoxProductos_SelectedIndexChanged);
            // 
            // richTextBoxVentas
            // 
            this.richTextBoxVentas.Location = new System.Drawing.Point(17, 357);
            this.richTextBoxVentas.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxVentas.Name = "richTextBoxVentas";
            this.richTextBoxVentas.Size = new System.Drawing.Size(993, 157);
            this.richTextBoxVentas.TabIndex = 1;
            this.richTextBoxVentas.Text = "";
            // 
            // groupBoxAcciones
            // 
            this.groupBoxAcciones.Controls.Add(this.btnVender);
            this.groupBoxAcciones.Location = new System.Drawing.Point(597, 37);
            this.groupBoxAcciones.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAcciones.Name = "groupBoxAcciones";
            this.groupBoxAcciones.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAcciones.Size = new System.Drawing.Size(415, 119);
            this.groupBoxAcciones.TabIndex = 2;
            this.groupBoxAcciones.TabStop = false;
            this.groupBoxAcciones.Text = "Acciones";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(27, 42);
            this.btnVender.Margin = new System.Windows.Forms.Padding(4);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(100, 28);
            this.btnVender.TabIndex = 0;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // richTextBoxDetalle
            // 
            this.richTextBoxDetalle.Location = new System.Drawing.Point(597, 164);
            this.richTextBoxDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxDetalle.Name = "richTextBoxDetalle";
            this.richTextBoxDetalle.Size = new System.Drawing.Size(413, 165);
            this.richTextBoxDetalle.TabIndex = 3;
            this.richTextBoxDetalle.Text = "";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(16, 337);
            this.lblVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(131, 17);
            this.lblVentas.TabIndex = 4;
            this.lblVentas.Text = "Lista de Ventas: ";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(16, 33);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(149, 17);
            this.lblProductos.TabIndex = 5;
            this.lblProductos.Text = "Lista de Productos:";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 529);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.richTextBoxDetalle);
            this.Controls.Add(this.groupBoxAcciones);
            this.Controls.Add(this.richTextBoxVentas);
            this.Controls.Add(this.listBoxProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrincipalForm";
            this.Text = "La Comiquería";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.groupBoxAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProductos;
        private System.Windows.Forms.RichTextBox richTextBoxVentas;
        private System.Windows.Forms.GroupBox groupBoxAcciones;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.RichTextBox richTextBoxDetalle;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblProductos;
    }
}