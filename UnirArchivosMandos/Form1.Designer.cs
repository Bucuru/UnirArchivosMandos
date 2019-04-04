namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lstArchivos = new System.Windows.Forms.ListView();
            this.btnClean = new System.Windows.Forms.Button();
            this.lblMandosFinal = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(37, 84);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(186, 45);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Añade Archivos de Mandos a la lista";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lstArchivos
            // 
            this.lstArchivos.Location = new System.Drawing.Point(37, 145);
            this.lstArchivos.MultiSelect = false;
            this.lstArchivos.Name = "lstArchivos";
            this.lstArchivos.Size = new System.Drawing.Size(400, 148);
            this.lstArchivos.TabIndex = 1;
            this.lstArchivos.UseCompatibleStateImageBehavior = false;
            this.lstArchivos.View = System.Windows.Forms.View.List;
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(341, 84);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(96, 45);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Limpiar Lista";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // lblMandosFinal
            // 
            this.lblMandosFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMandosFinal.Location = new System.Drawing.Point(33, 307);
            this.lblMandosFinal.Name = "lblMandosFinal";
            this.lblMandosFinal.Size = new System.Drawing.Size(276, 47);
            this.lblMandosFinal.TabIndex = 3;
            this.lblMandosFinal.Text = "Guarda el archivo suma de todos los archivos de mandos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(315, 307);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 38);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Crear Archivo";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 72);
            this.label1.TabIndex = 5;
            this.label1.Text = "Este programa junta archivos de mandos y los ordena para su correcta ejecución.  " +
                "Selecciona todos los archivos de mandos a juntar.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(477, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblMandosFinal);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.lstArchivos);
            this.Controls.Add(this.btnAbrir);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(493, 462);
            this.MinimumSize = new System.Drawing.Size(493, 462);
            this.Name = "Form1";
            this.Text = "App Unir Archivos Mandos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.ListView lstArchivos;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label lblMandosFinal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
    }
}

