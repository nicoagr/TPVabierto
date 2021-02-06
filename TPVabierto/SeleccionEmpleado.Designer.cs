namespace TPVabierto
{
    partial class SeleccionEmpleado
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
            this.volverimg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.volverimg)).BeginInit();
            this.SuspendLayout();
            // 
            // volverimg
            // 
            this.volverimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volverimg.Image = global::TPVabierto.Properties.Resources.volver;
            this.volverimg.Location = new System.Drawing.Point(40, 125);
            this.volverimg.Name = "volverimg";
            this.volverimg.Size = new System.Drawing.Size(100, 100);
            this.volverimg.TabIndex = 1;
            this.volverimg.TabStop = false;
            this.volverimg.Click += new System.EventHandler(this.volverimg_Click);
            // 
            // SeleccionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 389);
            this.ControlBox = false;
            this.Controls.Add(this.volverimg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeleccionEmpleado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TPVabierto [Venta] - Seleccion de Empelado";
            ((System.ComponentModel.ISupportInitialize)(this.volverimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox volverimg;
    }
}