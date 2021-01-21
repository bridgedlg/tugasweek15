
namespace tugasweek15
{
    partial class Form1
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
            this.labelitem = new System.Windows.Forms.Label();
            this.labelkat = new System.Windows.Forms.Label();
            this.textBoxitem = new System.Windows.Forms.TextBox();
            this.radioButtmakanan = new System.Windows.Forms.RadioButton();
            this.radioButtminuman = new System.Windows.Forms.RadioButton();
            this.buttoninput = new System.Windows.Forms.Button();
            this.listBoxmenu = new System.Windows.Forms.ListBox();
            this.buttonpanah = new System.Windows.Forms.Button();
            this.buttonsilang = new System.Windows.Forms.Button();
            this.labelF = new System.Windows.Forms.Label();
            this.checkBoxmakanan = new System.Windows.Forms.CheckBox();
            this.checkBoxminuman = new System.Windows.Forms.CheckBox();
            this.listboxF = new System.Windows.Forms.ListBox();
            this.listBoxmakanan = new System.Windows.Forms.ListBox();
            this.listBoxminuman = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelitem
            // 
            this.labelitem.AutoSize = true;
            this.labelitem.Location = new System.Drawing.Point(30, 41);
            this.labelitem.Name = "labelitem";
            this.labelitem.Size = new System.Drawing.Size(87, 20);
            this.labelitem.TabIndex = 0;
            this.labelitem.Text = "Nama Item";
            // 
            // labelkat
            // 
            this.labelkat.AutoSize = true;
            this.labelkat.Location = new System.Drawing.Point(30, 113);
            this.labelkat.Name = "labelkat";
            this.labelkat.Size = new System.Drawing.Size(68, 20);
            this.labelkat.TabIndex = 1;
            this.labelkat.Text = "Kategori";
            // 
            // textBoxitem
            // 
            this.textBoxitem.Location = new System.Drawing.Point(171, 38);
            this.textBoxitem.Name = "textBoxitem";
            this.textBoxitem.Size = new System.Drawing.Size(199, 26);
            this.textBoxitem.TabIndex = 2;
            this.textBoxitem.TextChanged += new System.EventHandler(this.textBoxitem_TextChanged);
            // 
            // radioButtmakanan
            // 
            this.radioButtmakanan.AutoSize = true;
            this.radioButtmakanan.Location = new System.Drawing.Point(171, 111);
            this.radioButtmakanan.Name = "radioButtmakanan";
            this.radioButtmakanan.Size = new System.Drawing.Size(100, 24);
            this.radioButtmakanan.TabIndex = 3;
            this.radioButtmakanan.TabStop = true;
            this.radioButtmakanan.Text = "Makanan";
            this.radioButtmakanan.UseVisualStyleBackColor = true;
            // 
            // radioButtminuman
            // 
            this.radioButtminuman.AutoSize = true;
            this.radioButtminuman.Location = new System.Drawing.Point(326, 111);
            this.radioButtminuman.Name = "radioButtminuman";
            this.radioButtminuman.Size = new System.Drawing.Size(99, 24);
            this.radioButtminuman.TabIndex = 4;
            this.radioButtminuman.TabStop = true;
            this.radioButtminuman.Text = "Minuman";
            this.radioButtminuman.UseVisualStyleBackColor = true;
            // 
            // buttoninput
            // 
            this.buttoninput.Location = new System.Drawing.Point(171, 178);
            this.buttoninput.Name = "buttoninput";
            this.buttoninput.Size = new System.Drawing.Size(118, 32);
            this.buttoninput.TabIndex = 5;
            this.buttoninput.Text = "Input";
            this.buttoninput.UseVisualStyleBackColor = true;
            this.buttoninput.Click += new System.EventHandler(this.buttoninput_Click);
            // 
            // listBoxmenu
            // 
            this.listBoxmenu.FormattingEnabled = true;
            this.listBoxmenu.ItemHeight = 20;
            this.listBoxmenu.Items.AddRange(new object[] {
            "Mie Instan",
            "Telor",
            "Susu Sapi",
            "Kopi",
            "Roti",
            "Keju",
            "Daging Giling",
            "Teh",
            "Bir"});
            this.listBoxmenu.Location = new System.Drawing.Point(34, 256);
            this.listBoxmenu.Name = "listBoxmenu";
            this.listBoxmenu.Size = new System.Drawing.Size(212, 264);
            this.listBoxmenu.TabIndex = 6;
            // 
            // buttonpanah
            // 
            this.buttonpanah.Location = new System.Drawing.Point(302, 256);
            this.buttonpanah.Name = "buttonpanah";
            this.buttonpanah.Size = new System.Drawing.Size(113, 29);
            this.buttonpanah.TabIndex = 7;
            this.buttonpanah.Text = ">";
            this.buttonpanah.UseVisualStyleBackColor = true;
            this.buttonpanah.Click += new System.EventHandler(this.buttonpanah_Click);
            // 
            // buttonsilang
            // 
            this.buttonsilang.Location = new System.Drawing.Point(302, 301);
            this.buttonsilang.Name = "buttonsilang";
            this.buttonsilang.Size = new System.Drawing.Size(113, 29);
            this.buttonsilang.TabIndex = 8;
            this.buttonsilang.Text = "X";
            this.buttonsilang.UseVisualStyleBackColor = true;
            this.buttonsilang.Click += new System.EventHandler(this.buttonsilang_Click);
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(302, 352);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(44, 20);
            this.labelF.TabIndex = 9;
            this.labelF.Text = "Filter";
            // 
            // checkBoxmakanan
            // 
            this.checkBoxmakanan.AutoSize = true;
            this.checkBoxmakanan.Location = new System.Drawing.Point(302, 392);
            this.checkBoxmakanan.Name = "checkBoxmakanan";
            this.checkBoxmakanan.Size = new System.Drawing.Size(101, 24);
            this.checkBoxmakanan.TabIndex = 10;
            this.checkBoxmakanan.Text = "Makanan";
            this.checkBoxmakanan.UseVisualStyleBackColor = true;
            this.checkBoxmakanan.CheckedChanged += new System.EventHandler(this.checkBoxmakanan_CheckedChanged);
            // 
            // checkBoxminuman
            // 
            this.checkBoxminuman.AutoSize = true;
            this.checkBoxminuman.Location = new System.Drawing.Point(302, 434);
            this.checkBoxminuman.Name = "checkBoxminuman";
            this.checkBoxminuman.Size = new System.Drawing.Size(100, 24);
            this.checkBoxminuman.TabIndex = 11;
            this.checkBoxminuman.Text = "Minuman";
            this.checkBoxminuman.UseVisualStyleBackColor = true;
            this.checkBoxminuman.CheckedChanged += new System.EventHandler(this.checkBoxminuman_CheckedChanged);
            // 
            // listboxF
            // 
            this.listboxF.FormattingEnabled = true;
            this.listboxF.ItemHeight = 20;
            this.listboxF.Location = new System.Drawing.Point(461, 256);
            this.listboxF.Name = "listboxF";
            this.listboxF.Size = new System.Drawing.Size(202, 264);
            this.listboxF.TabIndex = 12;
            // 
            // listBoxmakanan
            // 
            this.listBoxmakanan.FormattingEnabled = true;
            this.listBoxmakanan.ItemHeight = 20;
            this.listBoxmakanan.Items.AddRange(new object[] {
            "Mie Instan",
            "Telor",
            "Roti",
            "Keju",
            "Daging Giling"});
            this.listBoxmakanan.Location = new System.Drawing.Point(34, 256);
            this.listBoxmakanan.Name = "listBoxmakanan";
            this.listBoxmakanan.Size = new System.Drawing.Size(212, 264);
            this.listBoxmakanan.TabIndex = 13;
            this.listBoxmakanan.SelectedIndexChanged += new System.EventHandler(this.listBoxmakanan_SelectedIndexChanged);
            // 
            // listBoxminuman
            // 
            this.listBoxminuman.FormattingEnabled = true;
            this.listBoxminuman.ItemHeight = 20;
            this.listBoxminuman.Items.AddRange(new object[] {
            "Susu Sapi",
            "Kopi",
            "Teh",
            "Bir"});
            this.listBoxminuman.Location = new System.Drawing.Point(34, 256);
            this.listBoxminuman.Name = "listBoxminuman";
            this.listBoxminuman.Size = new System.Drawing.Size(212, 264);
            this.listBoxminuman.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 625);
            this.Controls.Add(this.listBoxmenu);
            this.Controls.Add(this.listBoxminuman);
            this.Controls.Add(this.listBoxmakanan);
            this.Controls.Add(this.listboxF);
            this.Controls.Add(this.checkBoxminuman);
            this.Controls.Add(this.checkBoxmakanan);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.buttonsilang);
            this.Controls.Add(this.buttonpanah);
            this.Controls.Add(this.buttoninput);
            this.Controls.Add(this.radioButtminuman);
            this.Controls.Add(this.radioButtmakanan);
            this.Controls.Add(this.textBoxitem);
            this.Controls.Add(this.labelkat);
            this.Controls.Add(this.labelitem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelitem;
        private System.Windows.Forms.Label labelkat;
        private System.Windows.Forms.TextBox textBoxitem;
        private System.Windows.Forms.RadioButton radioButtmakanan;
        private System.Windows.Forms.RadioButton radioButtminuman;
        private System.Windows.Forms.Button buttoninput;
        private System.Windows.Forms.ListBox listBoxmenu;
        private System.Windows.Forms.Button buttonpanah;
        private System.Windows.Forms.Button buttonsilang;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.CheckBox checkBoxmakanan;
        private System.Windows.Forms.CheckBox checkBoxminuman;
        private System.Windows.Forms.ListBox listboxF;
        private System.Windows.Forms.ListBox listBoxmakanan;
        private System.Windows.Forms.ListBox listBoxminuman;
    }
}

