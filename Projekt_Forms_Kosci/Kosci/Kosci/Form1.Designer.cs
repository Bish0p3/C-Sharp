namespace Kosci
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.b_start = new System.Windows.Forms.Button();
            this.b_wyjdz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.b_wiecej = new System.Windows.Forms.Button();
            this.b_mniej = new System.Windows.Forms.Button();
            this.l_punkty = new System.Windows.Forms.Label();
            this.l_info = new System.Windows.Forms.Label();
            this.b_1 = new System.Windows.Forms.Button();
            this.b_2 = new System.Windows.Forms.Button();
            this.b_3 = new System.Windows.Forms.Button();
            this.b_4 = new System.Windows.Forms.Button();
            this.b_5 = new System.Windows.Forms.Button();
            this.b_6 = new System.Windows.Forms.Button();
            this.pic_1 = new System.Windows.Forms.PictureBox();
            this.pic_2 = new System.Windows.Forms.PictureBox();
            this.l_obstawiles1 = new System.Windows.Forms.Label();
            this.l_obstawienie = new System.Windows.Forms.Label();
            this.l_numerki = new System.Windows.Forms.Label();
            this.l_obstawienie2 = new System.Windows.Forms.Label();
            this.l_wiecej_dobrze = new System.Windows.Forms.Label();
            this.l_wiecej_zle = new System.Windows.Forms.Label();
            this.l_numer_dobrze = new System.Windows.Forms.Label();
            this.l_numer_zle = new System.Windows.Forms.Label();
            this.l_mniej_dobrze = new System.Windows.Forms.Label();
            this.l_mniej_zle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2)).BeginInit();
            this.SuspendLayout();
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(327, 238);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(131, 57);
            this.b_start.TabIndex = 0;
            this.b_start.Text = "Start";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // b_wyjdz
            // 
            this.b_wyjdz.Location = new System.Drawing.Point(356, 301);
            this.b_wyjdz.Name = "b_wyjdz";
            this.b_wyjdz.Size = new System.Drawing.Size(75, 23);
            this.b_wyjdz.TabIndex = 1;
            this.b_wyjdz.Text = "Wyjdź";
            this.b_wyjdz.UseVisualStyleBackColor = true;
            this.b_wyjdz.Click += new System.EventHandler(this.b_wyjdz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kości";
            // 
            // b_wiecej
            // 
            this.b_wiecej.Location = new System.Drawing.Point(246, 255);
            this.b_wiecej.Name = "b_wiecej";
            this.b_wiecej.Size = new System.Drawing.Size(75, 23);
            this.b_wiecej.TabIndex = 3;
            this.b_wiecej.Text = "więcej";
            this.b_wiecej.UseVisualStyleBackColor = true;
            this.b_wiecej.Visible = false;
            this.b_wiecej.Click += new System.EventHandler(this.b_wiecej_Click);
            // 
            // b_mniej
            // 
            this.b_mniej.Location = new System.Drawing.Point(464, 255);
            this.b_mniej.Name = "b_mniej";
            this.b_mniej.Size = new System.Drawing.Size(75, 23);
            this.b_mniej.TabIndex = 4;
            this.b_mniej.Text = "mniej";
            this.b_mniej.UseVisualStyleBackColor = true;
            this.b_mniej.Visible = false;
            this.b_mniej.Click += new System.EventHandler(this.b_mniej_Click);
            // 
            // l_punkty
            // 
            this.l_punkty.AutoSize = true;
            this.l_punkty.Location = new System.Drawing.Point(367, 222);
            this.l_punkty.Name = "l_punkty";
            this.l_punkty.Size = new System.Drawing.Size(52, 13);
            this.l_punkty.TabIndex = 5;
            this.l_punkty.Text = "Punkty: 0";
            // 
            // l_info
            // 
            this.l_info.AutoSize = true;
            this.l_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_info.Location = new System.Drawing.Point(12, 16);
            this.l_info.Name = "l_info";
            this.l_info.Size = new System.Drawing.Size(266, 91);
            this.l_info.TabIndex = 6;
            this.l_info.Text = resources.GetString("l_info.Text");
            // 
            // b_1
            // 
            this.b_1.Location = new System.Drawing.Point(632, 228);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(35, 35);
            this.b_1.TabIndex = 7;
            this.b_1.Text = "1";
            this.b_1.UseVisualStyleBackColor = true;
            this.b_1.Visible = false;
            this.b_1.Click += new System.EventHandler(this.b_1_Click);
            // 
            // b_2
            // 
            this.b_2.Location = new System.Drawing.Point(673, 228);
            this.b_2.Name = "b_2";
            this.b_2.Size = new System.Drawing.Size(35, 35);
            this.b_2.TabIndex = 8;
            this.b_2.Text = "2";
            this.b_2.UseVisualStyleBackColor = true;
            this.b_2.Visible = false;
            this.b_2.Click += new System.EventHandler(this.b_2_Click);
            // 
            // b_3
            // 
            this.b_3.Location = new System.Drawing.Point(714, 228);
            this.b_3.Name = "b_3";
            this.b_3.Size = new System.Drawing.Size(35, 35);
            this.b_3.TabIndex = 9;
            this.b_3.Text = "3";
            this.b_3.UseVisualStyleBackColor = true;
            this.b_3.Visible = false;
            this.b_3.Click += new System.EventHandler(this.b_3_Click);
            // 
            // b_4
            // 
            this.b_4.Location = new System.Drawing.Point(632, 269);
            this.b_4.Name = "b_4";
            this.b_4.Size = new System.Drawing.Size(35, 35);
            this.b_4.TabIndex = 10;
            this.b_4.Text = "4";
            this.b_4.UseVisualStyleBackColor = true;
            this.b_4.Visible = false;
            this.b_4.Click += new System.EventHandler(this.b_4_Click);
            // 
            // b_5
            // 
            this.b_5.Location = new System.Drawing.Point(673, 269);
            this.b_5.Name = "b_5";
            this.b_5.Size = new System.Drawing.Size(35, 35);
            this.b_5.TabIndex = 11;
            this.b_5.Text = "5";
            this.b_5.UseVisualStyleBackColor = true;
            this.b_5.Visible = false;
            this.b_5.Click += new System.EventHandler(this.b_5_Click);
            // 
            // b_6
            // 
            this.b_6.Location = new System.Drawing.Point(714, 269);
            this.b_6.Name = "b_6";
            this.b_6.Size = new System.Drawing.Size(35, 35);
            this.b_6.TabIndex = 11;
            this.b_6.Text = "6";
            this.b_6.UseVisualStyleBackColor = true;
            this.b_6.Visible = false;
            this.b_6.Click += new System.EventHandler(this.b_6_Click);
            // 
            // pic_1
            // 
            this.pic_1.Location = new System.Drawing.Point(293, 116);
            this.pic_1.Name = "pic_1";
            this.pic_1.Size = new System.Drawing.Size(80, 80);
            this.pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_1.TabIndex = 14;
            this.pic_1.TabStop = false;
            this.pic_1.Visible = false;
            // 
            // pic_2
            // 
            this.pic_2.Location = new System.Drawing.Point(407, 115);
            this.pic_2.Name = "pic_2";
            this.pic_2.Size = new System.Drawing.Size(80, 80);
            this.pic_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_2.TabIndex = 15;
            this.pic_2.TabStop = false;
            this.pic_2.Visible = false;
            // 
            // l_obstawiles1
            // 
            this.l_obstawiles1.AutoSize = true;
            this.l_obstawiles1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_obstawiles1.Location = new System.Drawing.Point(13, 233);
            this.l_obstawiles1.Name = "l_obstawiles1";
            this.l_obstawiles1.Size = new System.Drawing.Size(95, 20);
            this.l_obstawiles1.TabIndex = 16;
            this.l_obstawiles1.Text = "Obstawiłeś: ";
            this.l_obstawiles1.Visible = false;
            // 
            // l_obstawienie
            // 
            this.l_obstawienie.AutoSize = true;
            this.l_obstawienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_obstawienie.ForeColor = System.Drawing.Color.Black;
            this.l_obstawienie.Location = new System.Drawing.Point(13, 261);
            this.l_obstawienie.Name = "l_obstawienie";
            this.l_obstawienie.Size = new System.Drawing.Size(31, 20);
            this.l_obstawienie.TabIndex = 17;
            this.l_obstawienie.Text = "Nic";
            this.l_obstawienie.Visible = false;
            // 
            // l_numerki
            // 
            this.l_numerki.AutoSize = true;
            this.l_numerki.Location = new System.Drawing.Point(668, 208);
            this.l_numerki.Name = "l_numerki";
            this.l_numerki.Size = new System.Drawing.Size(46, 13);
            this.l_numerki.TabIndex = 18;
            this.l_numerki.Text = "Numery:";
            this.l_numerki.Visible = false;
            // 
            // l_obstawienie2
            // 
            this.l_obstawienie2.AutoSize = true;
            this.l_obstawienie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_obstawienie2.ForeColor = System.Drawing.Color.Black;
            this.l_obstawienie2.Location = new System.Drawing.Point(13, 293);
            this.l_obstawienie2.Name = "l_obstawienie2";
            this.l_obstawienie2.Size = new System.Drawing.Size(0, 20);
            this.l_obstawienie2.TabIndex = 17;
            this.l_obstawienie2.Visible = false;
            // 
            // l_wiecej_dobrze
            // 
            this.l_wiecej_dobrze.AutoSize = true;
            this.l_wiecej_dobrze.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_wiecej_dobrze.ForeColor = System.Drawing.Color.DarkCyan;
            this.l_wiecej_dobrze.Location = new System.Drawing.Point(253, 236);
            this.l_wiecej_dobrze.Name = "l_wiecej_dobrze";
            this.l_wiecej_dobrze.Size = new System.Drawing.Size(58, 13);
            this.l_wiecej_dobrze.TabIndex = 13;
            this.l_wiecej_dobrze.Text = "Zgadłeś!";
            this.l_wiecej_dobrze.Visible = false;
            // 
            // l_wiecej_zle
            // 
            this.l_wiecej_zle.AutoSize = true;
            this.l_wiecej_zle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_wiecej_zle.ForeColor = System.Drawing.Color.IndianRed;
            this.l_wiecej_zle.Location = new System.Drawing.Point(266, 236);
            this.l_wiecej_zle.Name = "l_wiecej_zle";
            this.l_wiecej_zle.Size = new System.Drawing.Size(29, 13);
            this.l_wiecej_zle.TabIndex = 13;
            this.l_wiecej_zle.Text = "Źle!";
            this.l_wiecej_zle.Visible = false;
            // 
            // l_numer_dobrze
            // 
            this.l_numer_dobrze.AutoSize = true;
            this.l_numer_dobrze.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_numer_dobrze.ForeColor = System.Drawing.Color.DarkCyan;
            this.l_numer_dobrze.Location = new System.Drawing.Point(660, 185);
            this.l_numer_dobrze.Name = "l_numer_dobrze";
            this.l_numer_dobrze.Size = new System.Drawing.Size(58, 13);
            this.l_numer_dobrze.TabIndex = 13;
            this.l_numer_dobrze.Text = "Zgadłeś!";
            this.l_numer_dobrze.Visible = false;
            // 
            // l_numer_zle
            // 
            this.l_numer_zle.AutoSize = true;
            this.l_numer_zle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_numer_zle.ForeColor = System.Drawing.Color.IndianRed;
            this.l_numer_zle.Location = new System.Drawing.Point(674, 185);
            this.l_numer_zle.Name = "l_numer_zle";
            this.l_numer_zle.Size = new System.Drawing.Size(29, 13);
            this.l_numer_zle.TabIndex = 13;
            this.l_numer_zle.Text = "Źle!";
            this.l_numer_zle.Visible = false;
            // 
            // l_mniej_dobrze
            // 
            this.l_mniej_dobrze.AutoSize = true;
            this.l_mniej_dobrze.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_mniej_dobrze.ForeColor = System.Drawing.Color.DarkCyan;
            this.l_mniej_dobrze.Location = new System.Drawing.Point(471, 236);
            this.l_mniej_dobrze.Name = "l_mniej_dobrze";
            this.l_mniej_dobrze.Size = new System.Drawing.Size(58, 13);
            this.l_mniej_dobrze.TabIndex = 13;
            this.l_mniej_dobrze.Text = "Zgadłeś!";
            this.l_mniej_dobrze.Visible = false;
            // 
            // l_mniej_zle
            // 
            this.l_mniej_zle.AutoSize = true;
            this.l_mniej_zle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_mniej_zle.ForeColor = System.Drawing.Color.IndianRed;
            this.l_mniej_zle.Location = new System.Drawing.Point(484, 236);
            this.l_mniej_zle.Name = "l_mniej_zle";
            this.l_mniej_zle.Size = new System.Drawing.Size(29, 13);
            this.l_mniej_zle.TabIndex = 13;
            this.l_mniej_zle.Text = "Źle!";
            this.l_mniej_zle.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 331);
            this.Controls.Add(this.l_numerki);
            this.Controls.Add(this.l_obstawienie2);
            this.Controls.Add(this.l_obstawienie);
            this.Controls.Add(this.l_obstawiles1);
            this.Controls.Add(this.pic_2);
            this.Controls.Add(this.pic_1);
            this.Controls.Add(this.l_wiecej_zle);
            this.Controls.Add(this.l_numer_zle);
            this.Controls.Add(this.l_mniej_zle);
            this.Controls.Add(this.l_wiecej_dobrze);
            this.Controls.Add(this.l_numer_dobrze);
            this.Controls.Add(this.l_mniej_dobrze);
            this.Controls.Add(this.b_6);
            this.Controls.Add(this.b_5);
            this.Controls.Add(this.b_4);
            this.Controls.Add(this.b_3);
            this.Controls.Add(this.b_2);
            this.Controls.Add(this.b_1);
            this.Controls.Add(this.l_info);
            this.Controls.Add(this.l_punkty);
            this.Controls.Add(this.b_mniej);
            this.Controls.Add(this.b_wiecej);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_wyjdz);
            this.Controls.Add(this.b_start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Button b_wyjdz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_wiecej;
        private System.Windows.Forms.Button b_mniej;
        private System.Windows.Forms.Label l_punkty;
        private System.Windows.Forms.Label l_info;
        private System.Windows.Forms.Button b_1;
        private System.Windows.Forms.Button b_2;
        private System.Windows.Forms.Button b_3;
        private System.Windows.Forms.Button b_4;
        private System.Windows.Forms.Button b_5;
        private System.Windows.Forms.Button b_6;
        private System.Windows.Forms.PictureBox pic_1;
        private System.Windows.Forms.PictureBox pic_2;
        private System.Windows.Forms.Label l_obstawiles1;
        private System.Windows.Forms.Label l_obstawienie;
        private System.Windows.Forms.Label l_numerki;
        private System.Windows.Forms.Label l_obstawienie2;
        private System.Windows.Forms.Label l_wiecej_dobrze;
        private System.Windows.Forms.Label l_wiecej_zle;
        private System.Windows.Forms.Label l_numer_dobrze;
        private System.Windows.Forms.Label l_numer_zle;
        private System.Windows.Forms.Label l_mniej_dobrze;
        private System.Windows.Forms.Label l_mniej_zle;
    }
}

