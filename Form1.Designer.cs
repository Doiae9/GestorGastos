namespace GestorGastos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonAgregar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonInformes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(12, 12);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 0;
            this.botonAgregar.Text = "agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(12, 67);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 1;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonInformes
            // 
            this.ButtonInformes.Location = new System.Drawing.Point(192, 11);
            this.ButtonInformes.Name = "ButtonInformes";
            this.ButtonInformes.Size = new System.Drawing.Size(75, 23);
            this.ButtonInformes.TabIndex = 3;
            this.ButtonInformes.Text = "Informes";
            this.ButtonInformes.UseVisualStyleBackColor = true;
            this.ButtonInformes.Click += new System.EventHandler(this.ButtonInformes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonInformes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.botonAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonInformes;
    }
}

