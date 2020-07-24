namespace Ordre_de_virement
{
    partial class Modification
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_rib_ben = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_montant_lettre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_rib = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.combo_banque = new System.Windows.Forms.ComboBox();
            this.txt_typeop = new System.Windows.Forms.TextBox();
            this.label_op = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.RichTextBox();
            this.txt_montant_chiffre = new System.Windows.Forms.TextBox();
            this.txt_num_doc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_type_op = new System.Windows.Forms.ComboBox();
            this.txt_ben_moral = new System.Windows.Forms.TextBox();
            this.txt_ben_pc = new System.Windows.Forms.TextBox();
            this.date_OP = new System.Windows.Forms.DateTimePicker();
            this.btn_imprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(592, 432);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 79;
            this.button4.Text = "Fermer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(694, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 78;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(592, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 77;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_rib_ben
            // 
            this.txt_rib_ben.Location = new System.Drawing.Point(211, 201);
            this.txt_rib_ben.Name = "txt_rib_ben";
            this.txt_rib_ben.Size = new System.Drawing.Size(335, 20);
            this.txt_rib_ben.TabIndex = 76;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 75;
            this.label11.Text = "RIB Bénéficiaire";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 74;
            this.button1.Text = "-->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_montant_lettre
            // 
            this.txt_montant_lettre.Location = new System.Drawing.Point(510, 296);
            this.txt_montant_lettre.Name = "txt_montant_lettre";
            this.txt_montant_lettre.Size = new System.Drawing.Size(185, 20);
            this.txt_montant_lettre.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "Montant en lettre";
            // 
            // txt_rib
            // 
            this.txt_rib.Location = new System.Drawing.Point(211, 136);
            this.txt_rib.Name = "txt_rib";
            this.txt_rib.Size = new System.Drawing.Size(333, 20);
            this.txt_rib.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "RIB";
            // 
            // combo_banque
            // 
            this.combo_banque.FormattingEnabled = true;
            this.combo_banque.Location = new System.Drawing.Point(211, 92);
            this.combo_banque.Name = "combo_banque";
            this.combo_banque.Size = new System.Drawing.Size(121, 21);
            this.combo_banque.TabIndex = 69;
            this.combo_banque.SelectedIndexChanged += new System.EventHandler(this.combo_banque_SelectedIndexChanged);
            // 
            // txt_typeop
            // 
            this.txt_typeop.Location = new System.Drawing.Point(444, 243);
            this.txt_typeop.Name = "txt_typeop";
            this.txt_typeop.Size = new System.Drawing.Size(100, 20);
            this.txt_typeop.TabIndex = 68;
            // 
            // label_op
            // 
            this.label_op.AutoSize = true;
            this.label_op.Location = new System.Drawing.Point(368, 242);
            this.label_op.Name = "label_op";
            this.label_op.Size = new System.Drawing.Size(63, 39);
            this.label_op.TabIndex = 67;
            this.label_op.Text = "Preciser \r\nl\'operation\r\n(Obligatoire)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Date OP";
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(211, 416);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(216, 39);
            this.txt_note.TabIndex = 64;
            this.txt_note.Text = "";
            this.txt_note.TextChanged += new System.EventHandler(this.txt_note_TextChanged);
            // 
            // txt_montant_chiffre
            // 
            this.txt_montant_chiffre.Location = new System.Drawing.Point(211, 296);
            this.txt_montant_chiffre.Name = "txt_montant_chiffre";
            this.txt_montant_chiffre.Size = new System.Drawing.Size(100, 20);
            this.txt_montant_chiffre.TabIndex = 63;
            // 
            // txt_num_doc
            // 
            this.txt_num_doc.Location = new System.Drawing.Point(211, 48);
            this.txt_num_doc.Name = "txt_num_doc";
            this.txt_num_doc.Size = new System.Drawing.Size(100, 20);
            this.txt_num_doc.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 39);
            this.label7.TabIndex = 60;
            this.label7.Text = "Veillez Saisir\r\n une note\r\n(Optionnel)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Montant en Dhs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Type d\'operation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Bénéficiaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Banque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "N° Document";
            // 
            // txt_cin
            // 
            this.txt_cin.Location = new System.Drawing.Point(624, 166);
            this.txt_cin.Name = "txt_cin";
            this.txt_cin.Size = new System.Drawing.Size(100, 20);
            this.txt_cin.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "CIN du bénéficiaire";
            // 
            // combo_type_op
            // 
            this.combo_type_op.FormattingEnabled = true;
            this.combo_type_op.Location = new System.Drawing.Point(211, 242);
            this.combo_type_op.Name = "combo_type_op";
            this.combo_type_op.Size = new System.Drawing.Size(121, 21);
            this.combo_type_op.TabIndex = 65;
            this.combo_type_op.SelectedIndexChanged += new System.EventHandler(this.combo_type_op_SelectedIndexChanged);
            // 
            // txt_ben_moral
            // 
            this.txt_ben_moral.Location = new System.Drawing.Point(358, 165);
            this.txt_ben_moral.Name = "txt_ben_moral";
            this.txt_ben_moral.Size = new System.Drawing.Size(141, 20);
            this.txt_ben_moral.TabIndex = 84;
            // 
            // txt_ben_pc
            // 
            this.txt_ben_pc.Location = new System.Drawing.Point(211, 165);
            this.txt_ben_pc.Name = "txt_ben_pc";
            this.txt_ben_pc.Size = new System.Drawing.Size(121, 20);
            this.txt_ben_pc.TabIndex = 85;
            // 
            // date_OP
            // 
            this.date_OP.Location = new System.Drawing.Point(211, 353);
            this.date_OP.Name = "date_OP";
            this.date_OP.Size = new System.Drawing.Size(200, 20);
            this.date_OP.TabIndex = 86;
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.Location = new System.Drawing.Point(489, 389);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimer.TabIndex = 87;
            this.btn_imprimer.Text = "Imprimer";
            this.btn_imprimer.UseVisualStyleBackColor = true;
            this.btn_imprimer.Click += new System.EventHandler(this.btn_imprimer_Click);
            // 
            // Modification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 498);
            this.Controls.Add(this.btn_imprimer);
            this.Controls.Add(this.date_OP);
            this.Controls.Add(this.txt_ben_pc);
            this.Controls.Add(this.txt_ben_moral);
            this.Controls.Add(this.txt_cin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_rib_ben);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_montant_lettre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_rib);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combo_banque);
            this.Controls.Add(this.txt_typeop);
            this.Controls.Add(this.label_op);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combo_type_op);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.txt_montant_chiffre);
            this.Controls.Add(this.txt_num_doc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modification";
            this.Text = "Modification";
            this.Load += new System.EventHandler(this.Modification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_rib_ben;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_montant_lettre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_rib;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combo_banque;
        private System.Windows.Forms.TextBox txt_typeop;
        private System.Windows.Forms.Label label_op;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txt_note;
        private System.Windows.Forms.TextBox txt_montant_chiffre;
        private System.Windows.Forms.TextBox txt_num_doc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_type_op;
        private System.Windows.Forms.TextBox txt_ben_moral;
        private System.Windows.Forms.DateTimePicker date_OP;
        private System.Windows.Forms.Button btn_imprimer;
        public System.Windows.Forms.TextBox txt_ben_pc;
    }
}