namespace TallerMécanicoProgra
{
    partial class Menu_Principal
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
            this.btnAutos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnRefacciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAutos
            // 
            this.btnAutos.Location = new System.Drawing.Point(308, 249);
            this.btnAutos.Name = "btnAutos";
            this.btnAutos.Size = new System.Drawing.Size(185, 35);
            this.btnAutos.TabIndex = 5;
            this.btnAutos.Text = "Catálogo de Autos";
            this.btnAutos.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(308, 207);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(185, 36);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Catálogo de Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnRefacciones
            // 
            this.btnRefacciones.Location = new System.Drawing.Point(308, 166);
            this.btnRefacciones.Name = "btnRefacciones";
            this.btnRefacciones.Size = new System.Drawing.Size(185, 35);
            this.btnRefacciones.TabIndex = 3;
            this.btnRefacciones.Text = "Catálogo de Refacciones";
            this.btnRefacciones.UseVisualStyleBackColor = true;
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAutos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnRefacciones);
            this.Name = "Menu_Principal";
            this.Text = "Menu_Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAutos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnRefacciones;
    }
}