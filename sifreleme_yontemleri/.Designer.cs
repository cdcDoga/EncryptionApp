namespace sifreleme_yontemleri
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
            this.rtbPlain = new System.Windows.Forms.RichTextBox();
            this.cbAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblAlgorithm = new System.Windows.Forms.Label();
            this.lblCaesarKey = new System.Windows.Forms.Label();
            this.cbCaesarKey = new System.Windows.Forms.ComboBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.rtbCipher = new System.Windows.Forms.RichTextBox();
            this.lblSubstitutionKey = new System.Windows.Forms.Label();
            this.tbSubstitutionKey = new System.Windows.Forms.TextBox();
            this.tbAffineA = new System.Windows.Forms.TextBox();
            this.lblAffineKey = new System.Windows.Forms.Label();
            this.tbAffineB = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.tbVigenereKey = new System.Windows.Forms.TextBox();
            this.lblVigenereKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbPlain
            // 
            this.rtbPlain.BackColor = System.Drawing.SystemColors.Control;
            this.rtbPlain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbPlain.Location = new System.Drawing.Point(368, 37);
            this.rtbPlain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbPlain.Name = "rtbPlain";
            this.rtbPlain.Size = new System.Drawing.Size(535, 154);
            this.rtbPlain.TabIndex = 0;
            this.rtbPlain.Text = "";
            // 
            // cbAlgorithm
            // 
            this.cbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlgorithm.FormattingEnabled = true;
            this.cbAlgorithm.Items.AddRange(new object[] {
            "Caesar(Shift) Algorithm",
            "Substitution Algorithm",
            "Affine(Linear) Algorithm",
            "Vigenere(Block) Algorithm"});
            this.cbAlgorithm.Location = new System.Drawing.Point(140, 37);
            this.cbAlgorithm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAlgorithm.Name = "cbAlgorithm";
            this.cbAlgorithm.Size = new System.Drawing.Size(217, 24);
            this.cbAlgorithm.TabIndex = 1;
            this.cbAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cbAlgorithm_SelectedIndexChanged);
            // 
            // lblAlgorithm
            // 
            this.lblAlgorithm.AutoSize = true;
            this.lblAlgorithm.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlgorithm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAlgorithm.Location = new System.Drawing.Point(12, 41);
            this.lblAlgorithm.Name = "lblAlgorithm";
            this.lblAlgorithm.Size = new System.Drawing.Size(123, 16);
            this.lblAlgorithm.TabIndex = 2;
            this.lblAlgorithm.Text = "Encryption Algorithm :";
            // 
            // lblCaesarKey
            // 
            this.lblCaesarKey.AutoSize = true;
            this.lblCaesarKey.Location = new System.Drawing.Point(12, 85);
            this.lblCaesarKey.Name = "lblCaesarKey";
            this.lblCaesarKey.Size = new System.Drawing.Size(76, 16);
            this.lblCaesarKey.TabIndex = 4;
            this.lblCaesarKey.Text = "Caesar Key :";
            // 
            // cbCaesarKey
            // 
            this.cbCaesarKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaesarKey.FormattingEnabled = true;
            this.cbCaesarKey.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "23",
            "24",
            "25"});
            this.cbCaesarKey.Location = new System.Drawing.Point(140, 81);
            this.cbCaesarKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCaesarKey.Name = "cbCaesarKey";
            this.cbCaesarKey.Size = new System.Drawing.Size(217, 24);
            this.cbCaesarKey.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEncrypt.Location = new System.Drawing.Point(571, 198);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(118, 37);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "ENCRYPT";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // rtbCipher
            // 
            this.rtbCipher.BackColor = System.Drawing.SystemColors.Control;
            this.rtbCipher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbCipher.Location = new System.Drawing.Point(368, 242);
            this.rtbCipher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbCipher.Name = "rtbCipher";
            this.rtbCipher.Size = new System.Drawing.Size(535, 154);
            this.rtbCipher.TabIndex = 6;
            this.rtbCipher.Text = "";
            // 
            // lblSubstitutionKey
            // 
            this.lblSubstitutionKey.AutoSize = true;
            this.lblSubstitutionKey.Location = new System.Drawing.Point(12, 130);
            this.lblSubstitutionKey.Name = "lblSubstitutionKey";
            this.lblSubstitutionKey.Size = new System.Drawing.Size(99, 16);
            this.lblSubstitutionKey.TabIndex = 8;
            this.lblSubstitutionKey.Text = "Substitution Key :";
            // 
            // tbSubstitutionKey
            // 
            this.tbSubstitutionKey.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSubstitutionKey.Location = new System.Drawing.Point(140, 126);
            this.tbSubstitutionKey.Name = "tbSubstitutionKey";
            this.tbSubstitutionKey.Size = new System.Drawing.Size(217, 22);
            this.tbSubstitutionKey.TabIndex = 9;
            // 
            // tbAffineA
            // 
            this.tbAffineA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAffineA.Location = new System.Drawing.Point(193, 169);
            this.tbAffineA.Name = "tbAffineA";
            this.tbAffineA.Size = new System.Drawing.Size(46, 22);
            this.tbAffineA.TabIndex = 11;
            // 
            // lblAffineKey
            // 
            this.lblAffineKey.AutoSize = true;
            this.lblAffineKey.Location = new System.Drawing.Point(12, 173);
            this.lblAffineKey.Name = "lblAffineKey";
            this.lblAffineKey.Size = new System.Drawing.Size(66, 16);
            this.lblAffineKey.TabIndex = 10;
            this.lblAffineKey.Text = "Affine Key :";
            // 
            // tbAffineB
            // 
            this.tbAffineB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAffineB.Location = new System.Drawing.Point(311, 169);
            this.tbAffineB.Name = "tbAffineB";
            this.tbAffineB.Size = new System.Drawing.Size(46, 22);
            this.tbAffineB.TabIndex = 12;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(172, 173);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(16, 16);
            this.lblA.TabIndex = 13;
            this.lblA.Text = "a";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(246, 173);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 16);
            this.lblX.TabIndex = 14;
            this.lblX.Text = "x";
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Location = new System.Drawing.Point(269, 175);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(14, 16);
            this.lblPlus.TabIndex = 15;
            this.lblPlus.Text = "+";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(289, 174);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(16, 16);
            this.lblB.TabIndex = 16;
            this.lblB.Text = "b";
            // 
            // tbVigenereKey
            // 
            this.tbVigenereKey.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbVigenereKey.Location = new System.Drawing.Point(140, 213);
            this.tbVigenereKey.Name = "tbVigenereKey";
            this.tbVigenereKey.Size = new System.Drawing.Size(217, 22);
            this.tbVigenereKey.TabIndex = 18;
            // 
            // lblVigenereKey
            // 
            this.lblVigenereKey.AutoSize = true;
            this.lblVigenereKey.Location = new System.Drawing.Point(12, 217);
            this.lblVigenereKey.Name = "lblVigenereKey";
            this.lblVigenereKey.Size = new System.Drawing.Size(84, 16);
            this.lblVigenereKey.TabIndex = 17;
            this.lblVigenereKey.Text = "Vigenere Key :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 433);
            this.Controls.Add(this.tbVigenereKey);
            this.Controls.Add(this.lblVigenereKey);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.tbAffineB);
            this.Controls.Add(this.tbAffineA);
            this.Controls.Add(this.lblAffineKey);
            this.Controls.Add(this.tbSubstitutionKey);
            this.Controls.Add(this.lblSubstitutionKey);
            this.Controls.Add(this.rtbCipher);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblCaesarKey);
            this.Controls.Add(this.cbCaesarKey);
            this.Controls.Add(this.lblAlgorithm);
            this.Controls.Add(this.cbAlgorithm);
            this.Controls.Add(this.rtbPlain);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Encryption";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPlain;
        private System.Windows.Forms.ComboBox cbAlgorithm;
        private System.Windows.Forms.Label lblAlgorithm;
        private System.Windows.Forms.Label lblCaesarKey;
        private System.Windows.Forms.ComboBox cbCaesarKey;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.RichTextBox rtbCipher;
        private System.Windows.Forms.Label lblSubstitutionKey;
        private System.Windows.Forms.TextBox tbSubstitutionKey;
        private System.Windows.Forms.TextBox tbAffineA;
        private System.Windows.Forms.Label lblAffineKey;
        private System.Windows.Forms.TextBox tbAffineB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox tbVigenereKey;
        private System.Windows.Forms.Label lblVigenereKey;
    }
}

