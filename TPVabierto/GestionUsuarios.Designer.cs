namespace TPVabierto
{
    partial class GestionUsuarios
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.anadirusuariotxt = new System.Windows.Forms.TextBox();
            this.anadirusuariobtn = new System.Windows.Forms.Button();
            this.dropdown = new System.Windows.Forms.ComboBox();
            this.quitarusbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TPVabierto.Properties.Resources.volver;
            this.pictureBox1.Location = new System.Drawing.Point(23, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // anadirusuariotxt
            // 
            this.anadirusuariotxt.Location = new System.Drawing.Point(23, 22);
            this.anadirusuariotxt.Name = "anadirusuariotxt";
            this.anadirusuariotxt.Size = new System.Drawing.Size(100, 20);
            this.anadirusuariotxt.TabIndex = 1;
            this.anadirusuariotxt.TextChanged += new System.EventHandler(this.anadirusuariotxt_TextChanged);
            // 
            // anadirusuariobtn
            // 
            this.anadirusuariobtn.Location = new System.Drawing.Point(23, 49);
            this.anadirusuariobtn.Name = "anadirusuariobtn";
            this.anadirusuariobtn.Size = new System.Drawing.Size(100, 23);
            this.anadirusuariobtn.TabIndex = 2;
            this.anadirusuariobtn.Text = "Añadir Empleado";
            this.anadirusuariobtn.UseVisualStyleBackColor = true;
            this.anadirusuariobtn.Click += new System.EventHandler(this.anadirusuariobtn_Click);
            // 
            // dropdown
            // 
            this.dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown.FormattingEnabled = true;
            this.dropdown.Location = new System.Drawing.Point(23, 112);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(100, 21);
            this.dropdown.TabIndex = 3;
            this.dropdown.SelectedIndexChanged += new System.EventHandler(this.dropdown_SelectedIndexChanged);
            // 
            // quitarusbtn
            // 
            this.quitarusbtn.Location = new System.Drawing.Point(23, 139);
            this.quitarusbtn.Name = "quitarusbtn";
            this.quitarusbtn.Size = new System.Drawing.Size(100, 23);
            this.quitarusbtn.TabIndex = 4;
            this.quitarusbtn.Text = "Quitar Empleado";
            this.quitarusbtn.UseVisualStyleBackColor = true;
            this.quitarusbtn.Click += new System.EventHandler(this.quitarusbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Límite 8 empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "(Para quitar pantalla de selección de empleado, poner solo un empleado)";
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 25;
            this.lista.Items.AddRange(new object[] {
            "Peter",
            "Juan de los Palotes",
            "Pues yo no"});
            this.lista.Location = new System.Drawing.Point(171, 22);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(264, 329);
            this.lista.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "________________";
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 423);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitarusbtn);
            this.Controls.Add(this.dropdown);
            this.Controls.Add(this.anadirusuariobtn);
            this.Controls.Add(this.anadirusuariotxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GestionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TPVabierto [Gestión] - Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox anadirusuariotxt;
        private System.Windows.Forms.Button anadirusuariobtn;
        private System.Windows.Forms.ComboBox dropdown;
        private System.Windows.Forms.Button quitarusbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Label label3;
    }
}