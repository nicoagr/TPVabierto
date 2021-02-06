///
///
///        TPVABIERTO
///        Copyright 2019-2020, Nicolás Aguado
///        
///        Todos los derechos reservados
///


namespace TPVabierto
{
    partial class VentanaPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.productosbtn = new System.Windows.Forms.Button();
            this.usuariosbtn = new System.Windows.Forms.Button();
            this.ticketsgrupo = new System.Windows.Forms.GroupBox();
            this.verticket = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.calibrarbtn = new System.Windows.Forms.Button();
            this.confgenbtn = new System.Windows.Forms.Button();
            this.nuevoticketbtn = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iniciarimagen = new System.Windows.Forms.PictureBox();
            this.ticketsgrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iniciarimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "TPVabierto v1.0";
            // 
            // productosbtn
            // 
            this.productosbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productosbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.productosbtn.Location = new System.Drawing.Point(94, 130);
            this.productosbtn.Name = "productosbtn";
            this.productosbtn.Size = new System.Drawing.Size(100, 69);
            this.productosbtn.TabIndex = 1;
            this.productosbtn.Text = "Añadir y/o quitar Productos";
            this.productosbtn.UseVisualStyleBackColor = true;
            this.productosbtn.Click += new System.EventHandler(this.productosbtn_Click);
            // 
            // usuariosbtn
            // 
            this.usuariosbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usuariosbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosbtn.Location = new System.Drawing.Point(103, 37);
            this.usuariosbtn.Name = "usuariosbtn";
            this.usuariosbtn.Size = new System.Drawing.Size(91, 70);
            this.usuariosbtn.TabIndex = 0;
            this.usuariosbtn.Text = "Editar Empleados";
            this.usuariosbtn.UseVisualStyleBackColor = true;
            this.usuariosbtn.Click += new System.EventHandler(this.usuariosbtn_Click);
            // 
            // ticketsgrupo
            // 
            this.ticketsgrupo.Controls.Add(this.verticket);
            this.ticketsgrupo.Location = new System.Drawing.Point(336, 140);
            this.ticketsgrupo.Name = "ticketsgrupo";
            this.ticketsgrupo.Size = new System.Drawing.Size(280, 100);
            this.ticketsgrupo.TabIndex = 5;
            this.ticketsgrupo.TabStop = false;
            this.ticketsgrupo.Text = "Tickets";
            // 
            // verticket
            // 
            this.verticket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.verticket.Location = new System.Drawing.Point(20, 25);
            this.verticket.Name = "verticket";
            this.verticket.Size = new System.Drawing.Size(102, 58);
            this.verticket.TabIndex = 0;
            this.verticket.Text = "Consultar Ticket";
            this.verticket.UseVisualStyleBackColor = true;
            this.verticket.Click += new System.EventHandler(this.verticket_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Aplicaciones Octocero";
            // 
            // calibrarbtn
            // 
            this.calibrarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calibrarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calibrarbtn.Location = new System.Drawing.Point(94, 420);
            this.calibrarbtn.Name = "calibrarbtn";
            this.calibrarbtn.Size = new System.Drawing.Size(100, 52);
            this.calibrarbtn.TabIndex = 1;
            this.calibrarbtn.Text = "Calibración Escaner";
            this.calibrarbtn.UseVisualStyleBackColor = true;
            this.calibrarbtn.Click += new System.EventHandler(this.calibrarbtn_Click);
            // 
            // confgenbtn
            // 
            this.confgenbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confgenbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confgenbtn.Location = new System.Drawing.Point(82, 319);
            this.confgenbtn.Name = "confgenbtn";
            this.confgenbtn.Size = new System.Drawing.Size(100, 52);
            this.confgenbtn.TabIndex = 0;
            this.confgenbtn.Text = "Configuración General";
            this.confgenbtn.UseVisualStyleBackColor = true;
            this.confgenbtn.Click += new System.EventHandler(this.confgenbtn_Click);
            // 
            // nuevoticketbtn
            // 
            this.nuevoticketbtn.Location = new System.Drawing.Point(843, 504);
            this.nuevoticketbtn.Name = "nuevoticketbtn";
            this.nuevoticketbtn.Size = new System.Drawing.Size(152, 23);
            this.nuevoticketbtn.TabIndex = 1;
            this.nuevoticketbtn.Text = "Nuevo Ticket";
            this.nuevoticketbtn.UseVisualStyleBackColor = true;
            this.nuevoticketbtn.Click += new System.EventHandler(this.nuevoticketbtn_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::TPVabierto.Properties.Resources.calibrarsensor;
            this.pictureBox5.Location = new System.Drawing.Point(18, 410);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(240, 75);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.calibrarbtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::TPVabierto.Properties.Resources.confgen;
            this.pictureBox4.Location = new System.Drawing.Point(18, 310);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(240, 75);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.confgenbtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::TPVabierto.Properties.Resources.productos;
            this.pictureBox3.Location = new System.Drawing.Point(18, 130);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(240, 75);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.productosbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::TPVabierto.Properties.Resources.empleados;
            this.pictureBox2.Location = new System.Drawing.Point(18, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 75);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.usuariosbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TPVabierto.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(901, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 90);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // iniciarimagen
            // 
            this.iniciarimagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iniciarimagen.Image = global::TPVabierto.Properties.Resources.ticket;
            this.iniciarimagen.Location = new System.Drawing.Point(700, 439);
            this.iniciarimagen.Name = "iniciarimagen";
            this.iniciarimagen.Size = new System.Drawing.Size(321, 125);
            this.iniciarimagen.TabIndex = 6;
            this.iniciarimagen.TabStop = false;
            this.iniciarimagen.Click += new System.EventHandler(this.iniciarimagen_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1033, 573);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ticketsgrupo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iniciarimagen);
            this.Controls.Add(this.nuevoticketbtn);
            this.Controls.Add(this.confgenbtn);
            this.Controls.Add(this.calibrarbtn);
            this.Controls.Add(this.usuariosbtn);
            this.Controls.Add(this.productosbtn);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TPVabierto [Ventana Principal]";
            this.ticketsgrupo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iniciarimagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button usuariosbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iniciarimagen;
        private System.Windows.Forms.Button productosbtn;
        private System.Windows.Forms.GroupBox ticketsgrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confgenbtn;
        private System.Windows.Forms.Button calibrarbtn;
        private System.Windows.Forms.Button nuevoticketbtn;
        private System.Windows.Forms.Button verticket;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

