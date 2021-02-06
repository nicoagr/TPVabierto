namespace TPVabierto
{
    partial class GestionProductos
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
            this.idtxt = new System.Windows.Forms.TextBox();
            this.anadirusuariobtn = new System.Windows.Forms.Button();
            this.quitarusbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productotxt = new System.Windows.Forms.TextBox();
            this.preciotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quitarpr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.categoriatxt = new System.Windows.Forms.TextBox();
            this.anadircatbtn = new System.Windows.Forms.Button();
            this.quitarcatbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.anadirprcattxt = new System.Windows.Forms.TextBox();
            this.separador = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListBox();
            this.dropdown = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(421, 81);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 20);
            this.idtxt.TabIndex = 1;
            this.idtxt.TextChanged += new System.EventHandler(this.anadirusuariotxt_TextChanged);
            // 
            // anadirusuariobtn
            // 
            this.anadirusuariobtn.Location = new System.Drawing.Point(421, 225);
            this.anadirusuariobtn.Name = "anadirusuariobtn";
            this.anadirusuariobtn.Size = new System.Drawing.Size(100, 23);
            this.anadirusuariobtn.TabIndex = 4;
            this.anadirusuariobtn.Text = "Añadir Producto";
            this.anadirusuariobtn.UseVisualStyleBackColor = true;
            this.anadirusuariobtn.Click += new System.EventHandler(this.anadirusuariobtn_Click);
            // 
            // quitarusbtn
            // 
            this.quitarusbtn.Location = new System.Drawing.Point(421, 352);
            this.quitarusbtn.Name = "quitarusbtn";
            this.quitarusbtn.Size = new System.Drawing.Size(100, 23);
            this.quitarusbtn.TabIndex = 6;
            this.quitarusbtn.Text = "Quitar Producto";
            this.quitarusbtn.UseVisualStyleBackColor = true;
            this.quitarusbtn.Click += new System.EventHandler(this.quitarusbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(531, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(382, 401);
            this.dataGridView1.TabIndex = 5;
            // 
            // productotxt
            // 
            this.productotxt.Location = new System.Drawing.Point(421, 120);
            this.productotxt.MaxLength = 18;
            this.productotxt.Name = "productotxt";
            this.productotxt.Size = new System.Drawing.Size(100, 20);
            this.productotxt.TabIndex = 2;
            // 
            // preciotxt
            // 
            this.preciotxt.Location = new System.Drawing.Point(421, 159);
            this.preciotxt.Name = "preciotxt";
            this.preciotxt.Size = new System.Drawing.Size(100, 20);
            this.preciotxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Código:";
            // 
            // quitarpr
            // 
            this.quitarpr.Location = new System.Drawing.Point(421, 326);
            this.quitarpr.Name = "quitarpr";
            this.quitarpr.Size = new System.Drawing.Size(100, 20);
            this.quitarpr.TabIndex = 5;
            this.quitarpr.TextChanged += new System.EventHandler(this.quitarpr_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Código del Producto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TPVabierto.Properties.Resources.volver;
            this.pictureBox1.Location = new System.Drawing.Point(0, 353);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Categoría:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(538, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Productos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Categorías:";
            // 
            // categoriatxt
            // 
            this.categoriatxt.Location = new System.Drawing.Point(5, 92);
            this.categoriatxt.MaxLength = 11;
            this.categoriatxt.Name = "categoriatxt";
            this.categoriatxt.Size = new System.Drawing.Size(100, 20);
            this.categoriatxt.TabIndex = 18;
            this.categoriatxt.TextChanged += new System.EventHandler(this.categoriatxt_TextChanged);
            // 
            // anadircatbtn
            // 
            this.anadircatbtn.Location = new System.Drawing.Point(5, 117);
            this.anadircatbtn.Name = "anadircatbtn";
            this.anadircatbtn.Size = new System.Drawing.Size(100, 23);
            this.anadircatbtn.TabIndex = 19;
            this.anadircatbtn.Text = "Añadir Categoría";
            this.anadircatbtn.UseVisualStyleBackColor = true;
            this.anadircatbtn.Click += new System.EventHandler(this.anadircatbtn_Click);
            // 
            // quitarcatbtn
            // 
            this.quitarcatbtn.Location = new System.Drawing.Point(5, 225);
            this.quitarcatbtn.Name = "quitarcatbtn";
            this.quitarcatbtn.Size = new System.Drawing.Size(100, 23);
            this.quitarcatbtn.TabIndex = 21;
            this.quitarcatbtn.Text = "Quitar Categoría";
            this.quitarcatbtn.UseVisualStyleBackColor = true;
            this.quitarcatbtn.Click += new System.EventHandler(this.quitarcatbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Máximo 7 Categorías";
            // 
            // anadirprcattxt
            // 
            this.anadirprcattxt.Location = new System.Drawing.Point(421, 199);
            this.anadirprcattxt.Name = "anadirprcattxt";
            this.anadirprcattxt.Size = new System.Drawing.Size(100, 20);
            this.anadirprcattxt.TabIndex = 24;
            this.anadirprcattxt.TextChanged += new System.EventHandler(this.anadirprcattxt_TextChanged);
            // 
            // separador
            // 
            this.separador.AutoSize = true;
            this.separador.Location = new System.Drawing.Point(2, 159);
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(103, 13);
            this.separador.TabIndex = 25;
            this.separador.Text = "________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(418, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "________________";
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 20;
            this.lista.Items.AddRange(new object[] {
            "GoMinOlas:",
            "Palotes",
            "Regalices",
            "Palitos de pescado"});
            this.lista.Location = new System.Drawing.Point(111, 46);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(304, 404);
            this.lista.TabIndex = 27;
            // 
            // dropdown
            // 
            this.dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown.FormattingEnabled = true;
            this.dropdown.Location = new System.Drawing.Point(5, 199);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(100, 21);
            this.dropdown.TabIndex = 28;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(238, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // GestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 466);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dropdown);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.separador);
            this.Controls.Add(this.anadirprcattxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quitarcatbtn);
            this.Controls.Add(this.anadircatbtn);
            this.Controls.Add(this.categoriatxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quitarpr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.preciotxt);
            this.Controls.Add(this.productotxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quitarusbtn);
            this.Controls.Add(this.anadirusuariobtn);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GestionProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TPVabierto [Gestión] - Productos y Categorías";
            this.Load += new System.EventHandler(this.GestionProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Button anadirusuariobtn;
        private System.Windows.Forms.Button quitarusbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox productotxt;
        private System.Windows.Forms.TextBox preciotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quitarpr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox categoriatxt;
        private System.Windows.Forms.Button anadircatbtn;
        private System.Windows.Forms.Button quitarcatbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox anadirprcattxt;
        private System.Windows.Forms.Label separador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.ComboBox dropdown;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}