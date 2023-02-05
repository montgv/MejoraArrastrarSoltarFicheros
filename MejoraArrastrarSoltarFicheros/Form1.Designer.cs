namespace MejoraArrastrarSoltarFicheros
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
            this.listBoxFicheros = new System.Windows.Forms.ListBox();
            this.lbTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxFicheros
            // 
            this.listBoxFicheros.FormattingEnabled = true;
            this.listBoxFicheros.ItemHeight = 20;
            this.listBoxFicheros.Location = new System.Drawing.Point(29, 81);
            this.listBoxFicheros.Name = "listBoxFicheros";
            this.listBoxFicheros.Size = new System.Drawing.Size(980, 264);
            this.listBoxFicheros.TabIndex = 0;
            this.listBoxFicheros.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxFicheros_DragDrop);
            this.listBoxFicheros.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxFicheros_DragEnter);
            // 
            // lbTexto
            // 
            this.lbTexto.AutoSize = true;
            this.lbTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTexto.Location = new System.Drawing.Point(289, 27);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(469, 32);
            this.lbTexto.TabIndex = 1;
            this.lbTexto.Text = "Arrastra el fichero para ver la ruta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.lbTexto);
            this.Controls.Add(this.listBoxFicheros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFicheros;
        private System.Windows.Forms.Label lbTexto;
    }
}

