namespace Lab4_test2
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
            this.dataBox = new System.Windows.Forms.ComboBox();
            this.dataText = new System.Windows.Forms.TextBox();
            this.importFileButton = new System.Windows.Forms.Button();
            this.checkMD5 = new System.Windows.Forms.CheckBox();
            this.checkSHA1 = new System.Windows.Forms.CheckBox();
            this.checkSHA256 = new System.Windows.Forms.CheckBox();
            this.MD5Hash = new System.Windows.Forms.TextBox();
            this.SHA1Hash = new System.Windows.Forms.TextBox();
            this.SHA256Hash = new System.Windows.Forms.TextBox();
            this.hashButton = new System.Windows.Forms.Button();
            this.checkSHA384 = new System.Windows.Forms.CheckBox();
            this.checkSHA512 = new System.Windows.Forms.CheckBox();
            this.SHA384Hash = new System.Windows.Forms.TextBox();
            this.SHA512Hash = new System.Windows.Forms.TextBox();
            this.checkRIPEMD160 = new System.Windows.Forms.CheckBox();
            this.RIPEMD160Hash = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dataBox
            // 
            this.dataBox.FormattingEnabled = true;
            this.dataBox.Items.AddRange(new object[] {
            "Text",
            "Hex string",
            "File"});
            this.dataBox.Location = new System.Drawing.Point(12, 12);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(102, 24);
            this.dataBox.TabIndex = 0;
            // 
            // dataText
            // 
            this.dataText.Location = new System.Drawing.Point(158, 12);
            this.dataText.Multiline = true;
            this.dataText.Name = "dataText";
            this.dataText.Size = new System.Drawing.Size(871, 24);
            this.dataText.TabIndex = 1;
            // 
            // importFileButton
            // 
            this.importFileButton.BackColor = System.Drawing.SystemColors.Info;
            this.importFileButton.Location = new System.Drawing.Point(12, 54);
            this.importFileButton.Name = "importFileButton";
            this.importFileButton.Size = new System.Drawing.Size(102, 38);
            this.importFileButton.TabIndex = 2;
            this.importFileButton.Text = "FIle";
            this.importFileButton.UseVisualStyleBackColor = false;
            this.importFileButton.Click += new System.EventHandler(this.importFileButton_Click_1);
            // 
            // checkMD5
            // 
            this.checkMD5.AutoSize = true;
            this.checkMD5.Location = new System.Drawing.Point(19, 118);
            this.checkMD5.Name = "checkMD5";
            this.checkMD5.Size = new System.Drawing.Size(57, 20);
            this.checkMD5.TabIndex = 3;
            this.checkMD5.Text = "MD5";
            this.checkMD5.UseVisualStyleBackColor = true;
            // 
            // checkSHA1
            // 
            this.checkSHA1.AutoSize = true;
            this.checkSHA1.Location = new System.Drawing.Point(19, 156);
            this.checkSHA1.Name = "checkSHA1";
            this.checkSHA1.Size = new System.Drawing.Size(68, 20);
            this.checkSHA1.TabIndex = 4;
            this.checkSHA1.Text = "SHA-1";
            this.checkSHA1.UseVisualStyleBackColor = true;
            // 
            // checkSHA256
            // 
            this.checkSHA256.AutoSize = true;
            this.checkSHA256.Location = new System.Drawing.Point(19, 197);
            this.checkSHA256.Name = "checkSHA256";
            this.checkSHA256.Size = new System.Drawing.Size(82, 20);
            this.checkSHA256.TabIndex = 5;
            this.checkSHA256.Text = "SHA-256";
            this.checkSHA256.UseVisualStyleBackColor = true;
            // 
            // MD5Hash
            // 
            this.MD5Hash.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.MD5Hash.Location = new System.Drawing.Point(158, 116);
            this.MD5Hash.Multiline = true;
            this.MD5Hash.Name = "MD5Hash";
            this.MD5Hash.Size = new System.Drawing.Size(871, 22);
            this.MD5Hash.TabIndex = 6;
            // 
            // SHA1Hash
            // 
            this.SHA1Hash.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SHA1Hash.Location = new System.Drawing.Point(158, 154);
            this.SHA1Hash.Multiline = true;
            this.SHA1Hash.Name = "SHA1Hash";
            this.SHA1Hash.Size = new System.Drawing.Size(871, 22);
            this.SHA1Hash.TabIndex = 7;
            // 
            // SHA256Hash
            // 
            this.SHA256Hash.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SHA256Hash.Location = new System.Drawing.Point(158, 195);
            this.SHA256Hash.Multiline = true;
            this.SHA256Hash.Name = "SHA256Hash";
            this.SHA256Hash.Size = new System.Drawing.Size(871, 22);
            this.SHA256Hash.TabIndex = 8;
            // 
            // hashButton
            // 
            this.hashButton.BackColor = System.Drawing.SystemColors.Info;
            this.hashButton.Location = new System.Drawing.Point(12, 359);
            this.hashButton.Name = "hashButton";
            this.hashButton.Size = new System.Drawing.Size(127, 54);
            this.hashButton.TabIndex = 9;
            this.hashButton.Text = "Hash";
            this.hashButton.UseVisualStyleBackColor = false;
            this.hashButton.Click += new System.EventHandler(this.hashButton_Click);
            // 
            // checkSHA384
            // 
            this.checkSHA384.AutoSize = true;
            this.checkSHA384.Location = new System.Drawing.Point(19, 240);
            this.checkSHA384.Name = "checkSHA384";
            this.checkSHA384.Size = new System.Drawing.Size(82, 20);
            this.checkSHA384.TabIndex = 10;
            this.checkSHA384.Text = "SHA-384";
            this.checkSHA384.UseVisualStyleBackColor = true;
            // 
            // checkSHA512
            // 
            this.checkSHA512.AutoSize = true;
            this.checkSHA512.Location = new System.Drawing.Point(19, 281);
            this.checkSHA512.Name = "checkSHA512";
            this.checkSHA512.Size = new System.Drawing.Size(78, 20);
            this.checkSHA512.TabIndex = 11;
            this.checkSHA512.Text = "SHA512";
            this.checkSHA512.UseVisualStyleBackColor = true;
            // 
            // SHA384Hash
            // 
            this.SHA384Hash.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SHA384Hash.Location = new System.Drawing.Point(159, 242);
            this.SHA384Hash.Multiline = true;
            this.SHA384Hash.Name = "SHA384Hash";
            this.SHA384Hash.Size = new System.Drawing.Size(871, 22);
            this.SHA384Hash.TabIndex = 12;
            // 
            // SHA512Hash
            // 
            this.SHA512Hash.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SHA512Hash.Location = new System.Drawing.Point(159, 281);
            this.SHA512Hash.Name = "SHA512Hash";
            this.SHA512Hash.Size = new System.Drawing.Size(871, 22);
            this.SHA512Hash.TabIndex = 13;
            // 
            // checkRIPEMD160
            // 
            this.checkRIPEMD160.AutoSize = true;
            this.checkRIPEMD160.Location = new System.Drawing.Point(19, 320);
            this.checkRIPEMD160.Name = "checkRIPEMD160";
            this.checkRIPEMD160.Size = new System.Drawing.Size(102, 20);
            this.checkRIPEMD160.TabIndex = 14;
            this.checkRIPEMD160.Text = "RIPEMD160";
            this.checkRIPEMD160.UseVisualStyleBackColor = true;
            // 
            // RIPEMD160Hash
            // 
            this.RIPEMD160Hash.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.RIPEMD160Hash.Location = new System.Drawing.Point(158, 320);
            this.RIPEMD160Hash.Multiline = true;
            this.RIPEMD160Hash.Name = "RIPEMD160Hash";
            this.RIPEMD160Hash.Size = new System.Drawing.Size(871, 22);
            this.RIPEMD160Hash.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 425);
            this.Controls.Add(this.RIPEMD160Hash);
            this.Controls.Add(this.checkRIPEMD160);
            this.Controls.Add(this.SHA512Hash);
            this.Controls.Add(this.SHA384Hash);
            this.Controls.Add(this.checkSHA512);
            this.Controls.Add(this.checkSHA384);
            this.Controls.Add(this.hashButton);
            this.Controls.Add(this.SHA256Hash);
            this.Controls.Add(this.SHA1Hash);
            this.Controls.Add(this.MD5Hash);
            this.Controls.Add(this.checkSHA256);
            this.Controls.Add(this.checkSHA1);
            this.Controls.Add(this.checkMD5);
            this.Controls.Add(this.importFileButton);
            this.Controls.Add(this.dataText);
            this.Controls.Add(this.dataBox);
            this.Name = "Form1";
            this.Text = "Calculate Hash Values";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dataBox;
        private System.Windows.Forms.TextBox dataText;
        private System.Windows.Forms.Button importFileButton;
        private System.Windows.Forms.CheckBox checkMD5;
        private System.Windows.Forms.CheckBox checkSHA1;
        private System.Windows.Forms.CheckBox checkSHA256;
        private System.Windows.Forms.TextBox MD5Hash;
        private System.Windows.Forms.TextBox SHA1Hash;
        private System.Windows.Forms.TextBox SHA256Hash;
        private System.Windows.Forms.Button hashButton;
        private System.Windows.Forms.CheckBox checkSHA384;
        private System.Windows.Forms.CheckBox checkSHA512;
        private System.Windows.Forms.TextBox SHA384Hash;
        private System.Windows.Forms.TextBox SHA512Hash;
        private System.Windows.Forms.CheckBox checkRIPEMD160;
        private System.Windows.Forms.TextBox RIPEMD160Hash;
    }
}

