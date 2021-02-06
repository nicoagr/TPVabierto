namespace TPVabierto
{
    partial class ConfGen
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
            this.cerrarsin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monedasimbolo = new System.Windows.Forms.Label();
            this.monedadropdown = new System.Windows.Forms.ComboBox();
            this.billetelabel = new System.Windows.Forms.Label();
            this.billete1txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.billete2txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.billete3txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.billete4txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.billete5txt = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cerrarsin
            // 
            this.cerrarsin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarsin.Location = new System.Drawing.Point(345, 49);
            this.cerrarsin.Name = "cerrarsin";
            this.cerrarsin.Size = new System.Drawing.Size(115, 67);
            this.cerrarsin.TabIndex = 0;
            this.cerrarsin.Text = "Cerrar SIN Guardar";
            this.cerrarsin.UseVisualStyleBackColor = true;
            this.cerrarsin.Click += new System.EventHandler(this.cerrarsin_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(345, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar Guardando";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de la Empresa:";
            // 
            // monedasimbolo
            // 
            this.monedasimbolo.AutoSize = true;
            this.monedasimbolo.Location = new System.Drawing.Point(52, 80);
            this.monedasimbolo.Name = "monedasimbolo";
            this.monedasimbolo.Size = new System.Drawing.Size(97, 13);
            this.monedasimbolo.TabIndex = 5;
            this.monedasimbolo.Text = "Moneda (Símbolo):";
            // 
            // monedadropdown
            // 
            this.monedadropdown.FormattingEnabled = true;
            this.monedadropdown.Items.AddRange(new object[] {
            "€",
            "$",
            "£",
            "¢",
            "Bs",
            "S/",
            "¥",
            "C$",
            "A$",
            "R$",
            "₹",
            "元"});
            this.monedadropdown.Location = new System.Drawing.Point(52, 96);
            this.monedadropdown.Name = "monedadropdown";
            this.monedadropdown.Size = new System.Drawing.Size(105, 21);
            this.monedadropdown.TabIndex = 6;
            // 
            // billetelabel
            // 
            this.billetelabel.AutoSize = true;
            this.billetelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.billetelabel.Location = new System.Drawing.Point(34, 187);
            this.billetelabel.Name = "billetelabel";
            this.billetelabel.Size = new System.Drawing.Size(271, 15);
            this.billetelabel.TabIndex = 7;
            this.billetelabel.Text = "Módulo de Pago. Cantidades de Acceso Rápido:";
            // 
            // billete1txt
            // 
            this.billete1txt.Location = new System.Drawing.Point(52, 232);
            this.billete1txt.Name = "billete1txt";
            this.billete1txt.Size = new System.Drawing.Size(95, 20);
            this.billete1txt.TabIndex = 8;
            this.billete1txt.TextChanged += new System.EventHandler(this.billete1txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Acceso Rápido 2:";
            // 
            // billete2txt
            // 
            this.billete2txt.Location = new System.Drawing.Point(52, 271);
            this.billete2txt.Name = "billete2txt";
            this.billete2txt.Size = new System.Drawing.Size(95, 20);
            this.billete2txt.TabIndex = 10;
            this.billete2txt.TextChanged += new System.EventHandler(this.billete2txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Acceso Rápido 3:";
            // 
            // billete3txt
            // 
            this.billete3txt.Location = new System.Drawing.Point(52, 310);
            this.billete3txt.Name = "billete3txt";
            this.billete3txt.Size = new System.Drawing.Size(95, 20);
            this.billete3txt.TabIndex = 12;
            this.billete3txt.TextChanged += new System.EventHandler(this.billete3txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Acceso Rápido 4:";
            // 
            // billete4txt
            // 
            this.billete4txt.Location = new System.Drawing.Point(166, 248);
            this.billete4txt.Name = "billete4txt";
            this.billete4txt.Size = new System.Drawing.Size(95, 20);
            this.billete4txt.TabIndex = 14;
            this.billete4txt.TextChanged += new System.EventHandler(this.billete4txt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Acceso Rápido 5:";
            // 
            // billete5txt
            // 
            this.billete5txt.Location = new System.Drawing.Point(166, 291);
            this.billete5txt.Name = "billete5txt";
            this.billete5txt.Size = new System.Drawing.Size(95, 20);
            this.billete5txt.TabIndex = 16;
            this.billete5txt.TextChanged += new System.EventHandler(this.billete5txt_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(52, 130);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(201, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Al finalizar un ticket, crear otro nuevo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(52, 153);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(225, 17);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Al finalizar un ticket, abrir el menu principal";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Acceso Rápido 1:";
            // 
            // ConfGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 363);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.billete5txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.billete4txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.billete3txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.billete2txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.billete1txt);
            this.Controls.Add(this.billetelabel);
            this.Controls.Add(this.monedadropdown);
            this.Controls.Add(this.monedasimbolo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cerrarsin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfGen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TPVabierto [Configuración General]";
            this.Load += new System.EventHandler(this.ConfGen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cerrarsin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label monedasimbolo;
        private System.Windows.Forms.ComboBox monedadropdown;
        private System.Windows.Forms.Label billetelabel;
        private System.Windows.Forms.TextBox billete1txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox billete2txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox billete3txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox billete4txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox billete5txt;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label6;
    }
}