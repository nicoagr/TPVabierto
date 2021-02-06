///
///
///        TPVABIERTO
///        Copyright 2019-2020, Nicolás Aguado
///        
///        Todos los derechos reservados
///


namespace TPVabierto
{
    partial class Venta
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
            this.numticketxt = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.empleado = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListBox();
            this.total = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.moneda = new System.Windows.Forms.Label();
            this.aceptaridbtn = new System.Windows.Forms.Button();
            this.listaproductos = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cerrarimg = new System.Windows.Forms.PictureBox();
            this.cat1btn = new System.Windows.Forms.Button();
            this.cat2btn = new System.Windows.Forms.Button();
            this.cat3btn = new System.Windows.Forms.Button();
            this.cat4btn = new System.Windows.Forms.Button();
            this.cat5btn = new System.Windows.Forms.Button();
            this.cat6btn = new System.Windows.Forms.Button();
            this.cat7btn = new System.Windows.Forms.Button();
            this.item1 = new System.Windows.Forms.Button();
            this.item2 = new System.Windows.Forms.Button();
            this.item3 = new System.Windows.Forms.Button();
            this.item4 = new System.Windows.Forms.Button();
            this.item5 = new System.Windows.Forms.Button();
            this.item6 = new System.Windows.Forms.Button();
            this.item7 = new System.Windows.Forms.Button();
            this.item14 = new System.Windows.Forms.Button();
            this.item13 = new System.Windows.Forms.Button();
            this.item12 = new System.Windows.Forms.Button();
            this.item11 = new System.Windows.Forms.Button();
            this.item10 = new System.Windows.Forms.Button();
            this.item9 = new System.Windows.Forms.Button();
            this.item8 = new System.Windows.Forms.Button();
            this.item21 = new System.Windows.Forms.Button();
            this.item20 = new System.Windows.Forms.Button();
            this.item19 = new System.Windows.Forms.Button();
            this.item18 = new System.Windows.Forms.Button();
            this.item17 = new System.Windows.Forms.Button();
            this.item16 = new System.Windows.Forms.Button();
            this.item15 = new System.Windows.Forms.Button();
            this.item28 = new System.Windows.Forms.Button();
            this.item27 = new System.Windows.Forms.Button();
            this.item26 = new System.Windows.Forms.Button();
            this.item25 = new System.Windows.Forms.Button();
            this.item24 = new System.Windows.Forms.Button();
            this.item23 = new System.Windows.Forms.Button();
            this.item22 = new System.Windows.Forms.Button();
            this.item35 = new System.Windows.Forms.Button();
            this.item34 = new System.Windows.Forms.Button();
            this.item33 = new System.Windows.Forms.Button();
            this.item32 = new System.Windows.Forms.Button();
            this.item31 = new System.Windows.Forms.Button();
            this.item30 = new System.Windows.Forms.Button();
            this.item29 = new System.Windows.Forms.Button();
            this.item42 = new System.Windows.Forms.Button();
            this.item41 = new System.Windows.Forms.Button();
            this.item40 = new System.Windows.Forms.Button();
            this.item39 = new System.Windows.Forms.Button();
            this.item38 = new System.Windows.Forms.Button();
            this.item37 = new System.Windows.Forms.Button();
            this.item36 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarimg)).BeginInit();
            this.SuspendLayout();
            // 
            // numticketxt
            // 
            this.numticketxt.AutoSize = true;
            this.numticketxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numticketxt.Location = new System.Drawing.Point(17, 9);
            this.numticketxt.Name = "numticketxt";
            this.numticketxt.Size = new System.Drawing.Size(115, 24);
            this.numticketxt.TabIndex = 5;
            this.numticketxt.Text = "Ticket #0000";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(1040, 611);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(31, 13);
            this.id.TabIndex = 6;
            this.id.Text = "nullid";
            // 
            // empleado
            // 
            this.empleado.AutoSize = true;
            this.empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleado.Location = new System.Drawing.Point(989, 611);
            this.empleado.Name = "empleado";
            this.empleado.Size = new System.Drawing.Size(45, 13);
            this.empleado.TabIndex = 7;
            this.empleado.Text = "nullempl";
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Lucida Console", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 23;
            this.lista.Items.AddRange(new object[] {
            "----------------------------",
            "Aqui lista items",
            "",
            "Goma 7,00",
            "Lapiz 2,00 ",
            "etc"});
            this.lista.Location = new System.Drawing.Point(21, 40);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(405, 326);
            this.lista.TabIndex = 8;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(8, 415);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(158, 73);
            this.total.TabIndex = 9;
            this.total.Text = "0,00";
            // 
            // idtxt
            // 
            this.idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.Location = new System.Drawing.Point(21, 386);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(405, 26);
            this.idtxt.TabIndex = 11;
            this.idtxt.TextChanged += new System.EventHandler(this.idtxt_TextChanged);
            // 
            // moneda
            // 
            this.moneda.AutoSize = true;
            this.moneda.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneda.Location = new System.Drawing.Point(359, 423);
            this.moneda.Name = "moneda";
            this.moneda.Size = new System.Drawing.Size(67, 65);
            this.moneda.TabIndex = 12;
            this.moneda.Text = "$";
            // 
            // aceptaridbtn
            // 
            this.aceptaridbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptaridbtn.Location = new System.Drawing.Point(432, 386);
            this.aceptaridbtn.Name = "aceptaridbtn";
            this.aceptaridbtn.Size = new System.Drawing.Size(20, 26);
            this.aceptaridbtn.TabIndex = 13;
            this.aceptaridbtn.Text = "↵ ";
            this.aceptaridbtn.UseVisualStyleBackColor = true;
            this.aceptaridbtn.Click += new System.EventHandler(this.aceptaridbtn_Click);
            // 
            // listaproductos
            // 
            this.listaproductos.FormattingEnabled = true;
            this.listaproductos.Location = new System.Drawing.Point(206, 423);
            this.listaproductos.Name = "listaproductos";
            this.listaproductos.Size = new System.Drawing.Size(120, 95);
            this.listaproductos.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TPVabierto.Properties.Resources.pago;
            this.pictureBox1.Location = new System.Drawing.Point(158, 531);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 90);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // cerrarimg
            // 
            this.cerrarimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarimg.Image = global::TPVabierto.Properties.Resources.cerrarti;
            this.cerrarimg.Location = new System.Drawing.Point(12, 531);
            this.cerrarimg.Name = "cerrarimg";
            this.cerrarimg.Size = new System.Drawing.Size(120, 90);
            this.cerrarimg.TabIndex = 4;
            this.cerrarimg.TabStop = false;
            this.cerrarimg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cat1btn
            // 
            this.cat1btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cat1btn.Location = new System.Drawing.Point(452, 12);
            this.cat1btn.Name = "cat1btn";
            this.cat1btn.Size = new System.Drawing.Size(81, 74);
            this.cat1btn.TabIndex = 15;
            this.cat1btn.UseVisualStyleBackColor = true;
            this.cat1btn.Click += new System.EventHandler(this.catbtn_Click);
            // 
            // cat2btn
            // 
            this.cat2btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cat2btn.Location = new System.Drawing.Point(539, 12);
            this.cat2btn.Name = "cat2btn";
            this.cat2btn.Size = new System.Drawing.Size(81, 74);
            this.cat2btn.TabIndex = 16;
            this.cat2btn.UseVisualStyleBackColor = true;
            this.cat2btn.Click += new System.EventHandler(this.catbtn_Click);
            // 
            // cat3btn
            // 
            this.cat3btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cat3btn.Location = new System.Drawing.Point(626, 12);
            this.cat3btn.Name = "cat3btn";
            this.cat3btn.Size = new System.Drawing.Size(81, 74);
            this.cat3btn.TabIndex = 17;
            this.cat3btn.UseVisualStyleBackColor = true;
            this.cat3btn.Click += new System.EventHandler(this.catbtn_Click);
            // 
            // cat4btn
            // 
            this.cat4btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cat4btn.Location = new System.Drawing.Point(713, 12);
            this.cat4btn.Name = "cat4btn";
            this.cat4btn.Size = new System.Drawing.Size(81, 74);
            this.cat4btn.TabIndex = 18;
            this.cat4btn.UseVisualStyleBackColor = true;
            this.cat4btn.Click += new System.EventHandler(this.catbtn_Click);
            // 
            // cat5btn
            // 
            this.cat5btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cat5btn.Location = new System.Drawing.Point(800, 12);
            this.cat5btn.Name = "cat5btn";
            this.cat5btn.Size = new System.Drawing.Size(81, 74);
            this.cat5btn.TabIndex = 19;
            this.cat5btn.UseVisualStyleBackColor = true;
            this.cat5btn.Click += new System.EventHandler(this.catbtn_Click);
            // 
            // cat6btn
            // 
            this.cat6btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cat6btn.Location = new System.Drawing.Point(887, 12);
            this.cat6btn.Name = "cat6btn";
            this.cat6btn.Size = new System.Drawing.Size(81, 74);
            this.cat6btn.TabIndex = 20;
            this.cat6btn.UseVisualStyleBackColor = true;
            this.cat6btn.Click += new System.EventHandler(this.catbtn_Click);
            // 
            // cat7btn
            // 
            this.cat7btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cat7btn.Location = new System.Drawing.Point(974, 12);
            this.cat7btn.Name = "cat7btn";
            this.cat7btn.Size = new System.Drawing.Size(81, 74);
            this.cat7btn.TabIndex = 21;
            this.cat7btn.UseVisualStyleBackColor = true;
            this.cat7btn.Click += new System.EventHandler(this.catbtn_Click);
            // 
            // item1
            // 
            this.item1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item1.Location = new System.Drawing.Point(452, 129);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(81, 74);
            this.item1.TabIndex = 22;
            this.item1.UseVisualStyleBackColor = true;
            this.item1.Click += new System.EventHandler(this.item_Click);
            // 
            // item2
            // 
            this.item2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item2.Location = new System.Drawing.Point(539, 129);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(81, 74);
            this.item2.TabIndex = 23;
            this.item2.UseVisualStyleBackColor = true;
            this.item2.Click += new System.EventHandler(this.item_Click);
            // 
            // item3
            // 
            this.item3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item3.Location = new System.Drawing.Point(626, 129);
            this.item3.Name = "item3";
            this.item3.Size = new System.Drawing.Size(81, 74);
            this.item3.TabIndex = 24;
            this.item3.UseVisualStyleBackColor = true;
            this.item3.Click += new System.EventHandler(this.item_Click);
            // 
            // item4
            // 
            this.item4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item4.Location = new System.Drawing.Point(713, 129);
            this.item4.Name = "item4";
            this.item4.Size = new System.Drawing.Size(81, 74);
            this.item4.TabIndex = 25;
            this.item4.UseVisualStyleBackColor = true;
            this.item4.Click += new System.EventHandler(this.item_Click);
            // 
            // item5
            // 
            this.item5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item5.Location = new System.Drawing.Point(800, 129);
            this.item5.Name = "item5";
            this.item5.Size = new System.Drawing.Size(81, 74);
            this.item5.TabIndex = 26;
            this.item5.UseVisualStyleBackColor = true;
            this.item5.Click += new System.EventHandler(this.item_Click);
            // 
            // item6
            // 
            this.item6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item6.Location = new System.Drawing.Point(887, 129);
            this.item6.Name = "item6";
            this.item6.Size = new System.Drawing.Size(81, 74);
            this.item6.TabIndex = 27;
            this.item6.UseVisualStyleBackColor = true;
            this.item6.Click += new System.EventHandler(this.item_Click);
            // 
            // item7
            // 
            this.item7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item7.Location = new System.Drawing.Point(974, 129);
            this.item7.Name = "item7";
            this.item7.Size = new System.Drawing.Size(81, 74);
            this.item7.TabIndex = 28;
            this.item7.UseVisualStyleBackColor = true;
            this.item7.Click += new System.EventHandler(this.item_Click);
            // 
            // item14
            // 
            this.item14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item14.Location = new System.Drawing.Point(974, 209);
            this.item14.Name = "item14";
            this.item14.Size = new System.Drawing.Size(81, 74);
            this.item14.TabIndex = 35;
            this.item14.UseVisualStyleBackColor = true;
            this.item14.Click += new System.EventHandler(this.item_Click);
            // 
            // item13
            // 
            this.item13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item13.Location = new System.Drawing.Point(887, 209);
            this.item13.Name = "item13";
            this.item13.Size = new System.Drawing.Size(81, 74);
            this.item13.TabIndex = 34;
            this.item13.UseVisualStyleBackColor = true;
            this.item13.Click += new System.EventHandler(this.item_Click);
            // 
            // item12
            // 
            this.item12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item12.Location = new System.Drawing.Point(800, 209);
            this.item12.Name = "item12";
            this.item12.Size = new System.Drawing.Size(81, 74);
            this.item12.TabIndex = 33;
            this.item12.UseVisualStyleBackColor = true;
            this.item12.Click += new System.EventHandler(this.item_Click);
            // 
            // item11
            // 
            this.item11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item11.Location = new System.Drawing.Point(713, 209);
            this.item11.Name = "item11";
            this.item11.Size = new System.Drawing.Size(81, 74);
            this.item11.TabIndex = 32;
            this.item11.UseVisualStyleBackColor = true;
            this.item11.Click += new System.EventHandler(this.item_Click);
            // 
            // item10
            // 
            this.item10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item10.Location = new System.Drawing.Point(626, 209);
            this.item10.Name = "item10";
            this.item10.Size = new System.Drawing.Size(81, 74);
            this.item10.TabIndex = 31;
            this.item10.UseVisualStyleBackColor = true;
            this.item10.Click += new System.EventHandler(this.item_Click);
            // 
            // item9
            // 
            this.item9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item9.Location = new System.Drawing.Point(539, 209);
            this.item9.Name = "item9";
            this.item9.Size = new System.Drawing.Size(81, 74);
            this.item9.TabIndex = 30;
            this.item9.UseVisualStyleBackColor = true;
            this.item9.Click += new System.EventHandler(this.item_Click);
            // 
            // item8
            // 
            this.item8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item8.Location = new System.Drawing.Point(452, 209);
            this.item8.Name = "item8";
            this.item8.Size = new System.Drawing.Size(81, 74);
            this.item8.TabIndex = 29;
            this.item8.UseVisualStyleBackColor = true;
            this.item8.Click += new System.EventHandler(this.item_Click);
            // 
            // item21
            // 
            this.item21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item21.Location = new System.Drawing.Point(974, 292);
            this.item21.Name = "item21";
            this.item21.Size = new System.Drawing.Size(81, 74);
            this.item21.TabIndex = 42;
            this.item21.UseVisualStyleBackColor = true;
            this.item21.Click += new System.EventHandler(this.item_Click);
            // 
            // item20
            // 
            this.item20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item20.Location = new System.Drawing.Point(887, 292);
            this.item20.Name = "item20";
            this.item20.Size = new System.Drawing.Size(81, 74);
            this.item20.TabIndex = 41;
            this.item20.UseVisualStyleBackColor = true;
            this.item20.Click += new System.EventHandler(this.item_Click);
            // 
            // item19
            // 
            this.item19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item19.Location = new System.Drawing.Point(800, 292);
            this.item19.Name = "item19";
            this.item19.Size = new System.Drawing.Size(81, 74);
            this.item19.TabIndex = 40;
            this.item19.UseVisualStyleBackColor = true;
            this.item19.Click += new System.EventHandler(this.item_Click);
            // 
            // item18
            // 
            this.item18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item18.Location = new System.Drawing.Point(713, 292);
            this.item18.Name = "item18";
            this.item18.Size = new System.Drawing.Size(81, 74);
            this.item18.TabIndex = 39;
            this.item18.UseVisualStyleBackColor = true;
            this.item18.Click += new System.EventHandler(this.item_Click);
            // 
            // item17
            // 
            this.item17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item17.Location = new System.Drawing.Point(626, 292);
            this.item17.Name = "item17";
            this.item17.Size = new System.Drawing.Size(81, 74);
            this.item17.TabIndex = 38;
            this.item17.UseVisualStyleBackColor = true;
            this.item17.Click += new System.EventHandler(this.item_Click);
            // 
            // item16
            // 
            this.item16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item16.Location = new System.Drawing.Point(539, 292);
            this.item16.Name = "item16";
            this.item16.Size = new System.Drawing.Size(81, 74);
            this.item16.TabIndex = 37;
            this.item16.UseVisualStyleBackColor = true;
            this.item16.Click += new System.EventHandler(this.item_Click);
            // 
            // item15
            // 
            this.item15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item15.Location = new System.Drawing.Point(452, 292);
            this.item15.Name = "item15";
            this.item15.Size = new System.Drawing.Size(81, 74);
            this.item15.TabIndex = 36;
            this.item15.UseVisualStyleBackColor = true;
            this.item15.Click += new System.EventHandler(this.item_Click);
            // 
            // item28
            // 
            this.item28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item28.Location = new System.Drawing.Point(974, 372);
            this.item28.Name = "item28";
            this.item28.Size = new System.Drawing.Size(81, 74);
            this.item28.TabIndex = 49;
            this.item28.UseVisualStyleBackColor = true;
            this.item28.Click += new System.EventHandler(this.item_Click);
            // 
            // item27
            // 
            this.item27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item27.Location = new System.Drawing.Point(887, 372);
            this.item27.Name = "item27";
            this.item27.Size = new System.Drawing.Size(81, 74);
            this.item27.TabIndex = 48;
            this.item27.UseVisualStyleBackColor = true;
            this.item27.Click += new System.EventHandler(this.item_Click);
            // 
            // item26
            // 
            this.item26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item26.Location = new System.Drawing.Point(800, 372);
            this.item26.Name = "item26";
            this.item26.Size = new System.Drawing.Size(81, 74);
            this.item26.TabIndex = 47;
            this.item26.UseVisualStyleBackColor = true;
            this.item26.Click += new System.EventHandler(this.item_Click);
            // 
            // item25
            // 
            this.item25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item25.Location = new System.Drawing.Point(713, 372);
            this.item25.Name = "item25";
            this.item25.Size = new System.Drawing.Size(81, 74);
            this.item25.TabIndex = 46;
            this.item25.UseVisualStyleBackColor = true;
            this.item25.Click += new System.EventHandler(this.item_Click);
            // 
            // item24
            // 
            this.item24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item24.Location = new System.Drawing.Point(626, 372);
            this.item24.Name = "item24";
            this.item24.Size = new System.Drawing.Size(81, 74);
            this.item24.TabIndex = 45;
            this.item24.UseVisualStyleBackColor = true;
            this.item24.Click += new System.EventHandler(this.item_Click);
            // 
            // item23
            // 
            this.item23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item23.Location = new System.Drawing.Point(539, 372);
            this.item23.Name = "item23";
            this.item23.Size = new System.Drawing.Size(81, 74);
            this.item23.TabIndex = 44;
            this.item23.UseVisualStyleBackColor = true;
            this.item23.Click += new System.EventHandler(this.item_Click);
            // 
            // item22
            // 
            this.item22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item22.Location = new System.Drawing.Point(452, 372);
            this.item22.Name = "item22";
            this.item22.Size = new System.Drawing.Size(81, 74);
            this.item22.TabIndex = 43;
            this.item22.UseVisualStyleBackColor = true;
            this.item22.Click += new System.EventHandler(this.item_Click);
            // 
            // item35
            // 
            this.item35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item35.Location = new System.Drawing.Point(974, 452);
            this.item35.Name = "item35";
            this.item35.Size = new System.Drawing.Size(81, 74);
            this.item35.TabIndex = 56;
            this.item35.UseVisualStyleBackColor = true;
            this.item35.Click += new System.EventHandler(this.item_Click);
            // 
            // item34
            // 
            this.item34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item34.Location = new System.Drawing.Point(887, 452);
            this.item34.Name = "item34";
            this.item34.Size = new System.Drawing.Size(81, 74);
            this.item34.TabIndex = 55;
            this.item34.UseVisualStyleBackColor = true;
            this.item34.Click += new System.EventHandler(this.item_Click);
            // 
            // item33
            // 
            this.item33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item33.Location = new System.Drawing.Point(800, 452);
            this.item33.Name = "item33";
            this.item33.Size = new System.Drawing.Size(81, 74);
            this.item33.TabIndex = 54;
            this.item33.UseVisualStyleBackColor = true;
            this.item33.Click += new System.EventHandler(this.item_Click);
            // 
            // item32
            // 
            this.item32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item32.Location = new System.Drawing.Point(713, 452);
            this.item32.Name = "item32";
            this.item32.Size = new System.Drawing.Size(81, 74);
            this.item32.TabIndex = 53;
            this.item32.UseVisualStyleBackColor = true;
            this.item32.Click += new System.EventHandler(this.item_Click);
            // 
            // item31
            // 
            this.item31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item31.Location = new System.Drawing.Point(626, 452);
            this.item31.Name = "item31";
            this.item31.Size = new System.Drawing.Size(81, 74);
            this.item31.TabIndex = 52;
            this.item31.UseVisualStyleBackColor = true;
            this.item31.Click += new System.EventHandler(this.item_Click);
            // 
            // item30
            // 
            this.item30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item30.Location = new System.Drawing.Point(539, 452);
            this.item30.Name = "item30";
            this.item30.Size = new System.Drawing.Size(81, 74);
            this.item30.TabIndex = 51;
            this.item30.UseVisualStyleBackColor = true;
            this.item30.Click += new System.EventHandler(this.item_Click);
            // 
            // item29
            // 
            this.item29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item29.Location = new System.Drawing.Point(452, 452);
            this.item29.Name = "item29";
            this.item29.Size = new System.Drawing.Size(81, 74);
            this.item29.TabIndex = 50;
            this.item29.UseVisualStyleBackColor = true;
            this.item29.Click += new System.EventHandler(this.item_Click);
            // 
            // item42
            // 
            this.item42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item42.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item42.Location = new System.Drawing.Point(974, 531);
            this.item42.Name = "item42";
            this.item42.Size = new System.Drawing.Size(81, 74);
            this.item42.TabIndex = 63;
            this.item42.UseVisualStyleBackColor = true;
            this.item42.Click += new System.EventHandler(this.item_Click);
            // 
            // item41
            // 
            this.item41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item41.Location = new System.Drawing.Point(887, 531);
            this.item41.Name = "item41";
            this.item41.Size = new System.Drawing.Size(81, 74);
            this.item41.TabIndex = 62;
            this.item41.UseVisualStyleBackColor = true;
            this.item41.Click += new System.EventHandler(this.item_Click);
            // 
            // item40
            // 
            this.item40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item40.Location = new System.Drawing.Point(800, 531);
            this.item40.Name = "item40";
            this.item40.Size = new System.Drawing.Size(81, 74);
            this.item40.TabIndex = 61;
            this.item40.UseVisualStyleBackColor = true;
            this.item40.Click += new System.EventHandler(this.item_Click);
            // 
            // item39
            // 
            this.item39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item39.Location = new System.Drawing.Point(713, 531);
            this.item39.Name = "item39";
            this.item39.Size = new System.Drawing.Size(81, 74);
            this.item39.TabIndex = 60;
            this.item39.UseVisualStyleBackColor = true;
            this.item39.Click += new System.EventHandler(this.item_Click);
            // 
            // item38
            // 
            this.item38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item38.Location = new System.Drawing.Point(626, 531);
            this.item38.Name = "item38";
            this.item38.Size = new System.Drawing.Size(81, 74);
            this.item38.TabIndex = 59;
            this.item38.UseVisualStyleBackColor = true;
            this.item38.Click += new System.EventHandler(this.item_Click);
            // 
            // item37
            // 
            this.item37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item37.Location = new System.Drawing.Point(539, 531);
            this.item37.Name = "item37";
            this.item37.Size = new System.Drawing.Size(81, 74);
            this.item37.TabIndex = 58;
            this.item37.UseVisualStyleBackColor = true;
            this.item37.Click += new System.EventHandler(this.item_Click);
            // 
            // item36
            // 
            this.item36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.item36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.item36.Location = new System.Drawing.Point(452, 531);
            this.item36.Name = "item36";
            this.item36.Size = new System.Drawing.Size(81, 74);
            this.item36.TabIndex = 57;
            this.item36.UseVisualStyleBackColor = true;
            this.item36.Click += new System.EventHandler(this.item_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "_________________________________________________________________________________" +
    "___________________";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 633);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.item42);
            this.Controls.Add(this.item41);
            this.Controls.Add(this.item40);
            this.Controls.Add(this.item39);
            this.Controls.Add(this.item38);
            this.Controls.Add(this.item37);
            this.Controls.Add(this.item36);
            this.Controls.Add(this.item35);
            this.Controls.Add(this.item34);
            this.Controls.Add(this.item33);
            this.Controls.Add(this.item32);
            this.Controls.Add(this.item31);
            this.Controls.Add(this.item30);
            this.Controls.Add(this.item29);
            this.Controls.Add(this.item28);
            this.Controls.Add(this.item27);
            this.Controls.Add(this.item26);
            this.Controls.Add(this.item25);
            this.Controls.Add(this.item24);
            this.Controls.Add(this.item23);
            this.Controls.Add(this.item22);
            this.Controls.Add(this.item21);
            this.Controls.Add(this.item20);
            this.Controls.Add(this.item19);
            this.Controls.Add(this.item18);
            this.Controls.Add(this.item17);
            this.Controls.Add(this.item16);
            this.Controls.Add(this.item15);
            this.Controls.Add(this.item14);
            this.Controls.Add(this.item13);
            this.Controls.Add(this.item12);
            this.Controls.Add(this.item11);
            this.Controls.Add(this.item10);
            this.Controls.Add(this.item9);
            this.Controls.Add(this.item8);
            this.Controls.Add(this.item7);
            this.Controls.Add(this.item6);
            this.Controls.Add(this.item5);
            this.Controls.Add(this.item4);
            this.Controls.Add(this.item3);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.item1);
            this.Controls.Add(this.cat7btn);
            this.Controls.Add(this.cat6btn);
            this.Controls.Add(this.cat5btn);
            this.Controls.Add(this.cat4btn);
            this.Controls.Add(this.cat3btn);
            this.Controls.Add(this.cat2btn);
            this.Controls.Add(this.cat1btn);
            this.Controls.Add(this.listaproductos);
            this.Controls.Add(this.aceptaridbtn);
            this.Controls.Add(this.moneda);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.empleado);
            this.Controls.Add(this.id);
            this.Controls.Add(this.numticketxt);
            this.Controls.Add(this.cerrarimg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Venta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TPVabierto [Venta]";
            this.Activated += new System.EventHandler(this.Venta_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cerrarimg;
        private System.Windows.Forms.Label numticketxt;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label empleado;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label moneda;
        private System.Windows.Forms.Button aceptaridbtn;
        private System.Windows.Forms.ListBox listaproductos;
        private System.Windows.Forms.Button cat1btn;
        private System.Windows.Forms.Button cat2btn;
        private System.Windows.Forms.Button cat3btn;
        private System.Windows.Forms.Button cat4btn;
        private System.Windows.Forms.Button cat5btn;
        private System.Windows.Forms.Button cat6btn;
        private System.Windows.Forms.Button cat7btn;
        private System.Windows.Forms.Button item1;
        private System.Windows.Forms.Button item2;
        private System.Windows.Forms.Button item3;
        private System.Windows.Forms.Button item4;
        private System.Windows.Forms.Button item5;
        private System.Windows.Forms.Button item6;
        private System.Windows.Forms.Button item7;
        private System.Windows.Forms.Button item14;
        private System.Windows.Forms.Button item13;
        private System.Windows.Forms.Button item12;
        private System.Windows.Forms.Button item11;
        private System.Windows.Forms.Button item10;
        private System.Windows.Forms.Button item9;
        private System.Windows.Forms.Button item8;
        private System.Windows.Forms.Button item21;
        private System.Windows.Forms.Button item20;
        private System.Windows.Forms.Button item19;
        private System.Windows.Forms.Button item18;
        private System.Windows.Forms.Button item17;
        private System.Windows.Forms.Button item16;
        private System.Windows.Forms.Button item15;
        private System.Windows.Forms.Button item28;
        private System.Windows.Forms.Button item27;
        private System.Windows.Forms.Button item26;
        private System.Windows.Forms.Button item25;
        private System.Windows.Forms.Button item24;
        private System.Windows.Forms.Button item23;
        private System.Windows.Forms.Button item22;
        private System.Windows.Forms.Button item35;
        private System.Windows.Forms.Button item34;
        private System.Windows.Forms.Button item33;
        private System.Windows.Forms.Button item32;
        private System.Windows.Forms.Button item31;
        private System.Windows.Forms.Button item30;
        private System.Windows.Forms.Button item29;
        private System.Windows.Forms.Button item42;
        private System.Windows.Forms.Button item41;
        private System.Windows.Forms.Button item40;
        private System.Windows.Forms.Button item39;
        private System.Windows.Forms.Button item38;
        private System.Windows.Forms.Button item37;
        private System.Windows.Forms.Button item36;
        private System.Windows.Forms.Label label1;
    }
}