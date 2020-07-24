namespace Ordre_de_virement
{
    partial class MAD
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
            this.txt_montant_lettre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_rib = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.combo_banque = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.RichTextBox();
            this.txt_montant_chiffre = new System.Windows.Forms.TextBox();
            this.txt_ben = new System.Windows.Forms.TextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.date_op = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.combo_type_op = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_montant_lettre
            // 
            this.txt_montant_lettre.Location = new System.Drawing.Point(635, 252);
            this.txt_montant_lettre.Name = "txt_montant_lettre";
            this.txt_montant_lettre.Size = new System.Drawing.Size(169, 20);
            this.txt_montant_lettre.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(524, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Montant en lettre";
            // 
            // txt_rib
            // 
            this.txt_rib.Location = new System.Drawing.Point(267, 106);
            this.txt_rib.Name = "txt_rib";
            this.txt_rib.Size = new System.Drawing.Size(333, 20);
            this.txt_rib.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "RIB";
            // 
            // combo_banque
            // 
            this.combo_banque.FormattingEnabled = true;
            this.combo_banque.Location = new System.Drawing.Point(267, 62);
            this.combo_banque.Name = "combo_banque";
            this.combo_banque.Size = new System.Drawing.Size(121, 21);
            this.combo_banque.TabIndex = 41;
            this.combo_banque.SelectedIndexChanged += new System.EventHandler(this.combo_banque_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Date OP";
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(269, 357);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(216, 39);
            this.txt_note.TabIndex = 35;
            this.txt_note.Text = "";
            // 
            // txt_montant_chiffre
            // 
            this.txt_montant_chiffre.Location = new System.Drawing.Point(267, 253);
            this.txt_montant_chiffre.Name = "txt_montant_chiffre";
            this.txt_montant_chiffre.Size = new System.Drawing.Size(100, 20);
            this.txt_montant_chiffre.TabIndex = 33;
            // 
            // txt_ben
            // 
            this.txt_ben.Location = new System.Drawing.Point(267, 157);
            this.txt_ben.Name = "txt_ben";
            this.txt_ben.Size = new System.Drawing.Size(100, 20);
            this.txt_ben.TabIndex = 32;
            this.txt_ben.TextChanged += new System.EventHandler(this.txt_ben_TextChanged);
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(267, 18);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 20);
            this.txt_num.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 39);
            this.label7.TabIndex = 30;
            this.label7.Text = "Veillez Saisir\r\n une note\r\n(Optionnel)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Montant en Dhs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Type d\'operation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Bénéficiaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Banque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "N° Document";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_cin
            // 
            this.txt_cin.Location = new System.Drawing.Point(527, 160);
            this.txt_cin.Name = "txt_cin";
            this.txt_cin.Size = new System.Drawing.Size(100, 20);
            this.txt_cin.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(410, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "CIN du bénéficiaire";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "-->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date_op
            // 
            this.date_op.Location = new System.Drawing.Point(267, 310);
            this.date_op.Name = "date_op";
            this.date_op.Size = new System.Drawing.Size(200, 20);
            this.date_op.TabIndex = 50;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(635, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 55;
            this.button4.Text = "Fermer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(685, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 54;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "Imprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // combo_type_op
            // 
            this.combo_type_op.Location = new System.Drawing.Point(269, 203);
            this.combo_type_op.Name = "combo_type_op";
            this.combo_type_op.ReadOnly = true;
            this.combo_type_op.Size = new System.Drawing.Size(100, 20);
            this.combo_type_op.TabIndex = 59;
            // 
            // MAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 531);
            this.Controls.Add(this.combo_type_op);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.date_op);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_cin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_montant_lettre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_rib);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combo_banque);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.txt_montant_chiffre);
            this.Controls.Add(this.txt_ben);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MAD";
            this.Text = "Mise à disposition";
            this.Load += new System.EventHandler(this.MAD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_montant_lettre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_rib;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combo_banque;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txt_note;
        private System.Windows.Forms.TextBox txt_montant_chiffre;
        private System.Windows.Forms.TextBox txt_ben;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker date_op;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox combo_type_op;
    }
}