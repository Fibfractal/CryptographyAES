namespace CryptographyAES
{
    partial class MainForm
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
            this.tbx_Plaintext = new System.Windows.Forms.RichTextBox();
            this.tbx_CiphertextAndIV = new System.Windows.Forms.RichTextBox();
            this.tbx_DecryptPlaintext = new System.Windows.Forms.RichTextBox();
            this.btn_EncryptMessage = new System.Windows.Forms.Button();
            this.btn_DecryptMessage = new System.Windows.Forms.Button();
            this.lbl_PlainText = new System.Windows.Forms.Label();
            this.lbl_EncryptedCipherText = new System.Windows.Forms.Label();
            this.lbl_DecryptedPlaintext = new System.Windows.Forms.Label();
            this.btn_ClearMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_Plaintext
            // 
            this.tbx_Plaintext.Location = new System.Drawing.Point(179, 76);
            this.tbx_Plaintext.Name = "tbx_Plaintext";
            this.tbx_Plaintext.Size = new System.Drawing.Size(366, 79);
            this.tbx_Plaintext.TabIndex = 0;
            this.tbx_Plaintext.Text = "";
            // 
            // tbx_CiphertextAndIV
            // 
            this.tbx_CiphertextAndIV.Location = new System.Drawing.Point(179, 202);
            this.tbx_CiphertextAndIV.Name = "tbx_CiphertextAndIV";
            this.tbx_CiphertextAndIV.Size = new System.Drawing.Size(366, 79);
            this.tbx_CiphertextAndIV.TabIndex = 1;
            this.tbx_CiphertextAndIV.Text = "";
            // 
            // tbx_DecryptPlaintext
            // 
            this.tbx_DecryptPlaintext.Location = new System.Drawing.Point(179, 332);
            this.tbx_DecryptPlaintext.Name = "tbx_DecryptPlaintext";
            this.tbx_DecryptPlaintext.Size = new System.Drawing.Size(366, 79);
            this.tbx_DecryptPlaintext.TabIndex = 2;
            this.tbx_DecryptPlaintext.Text = "";
            // 
            // btn_EncryptMessage
            // 
            this.btn_EncryptMessage.Location = new System.Drawing.Point(614, 76);
            this.btn_EncryptMessage.Name = "btn_EncryptMessage";
            this.btn_EncryptMessage.Size = new System.Drawing.Size(129, 37);
            this.btn_EncryptMessage.TabIndex = 3;
            this.btn_EncryptMessage.Text = "Encrypt Message";
            this.btn_EncryptMessage.UseVisualStyleBackColor = true;
            this.btn_EncryptMessage.Click += new System.EventHandler(this.btn_EncryptMessage_Click);
            // 
            // btn_DecryptMessage
            // 
            this.btn_DecryptMessage.Location = new System.Drawing.Point(614, 119);
            this.btn_DecryptMessage.Name = "btn_DecryptMessage";
            this.btn_DecryptMessage.Size = new System.Drawing.Size(129, 37);
            this.btn_DecryptMessage.TabIndex = 4;
            this.btn_DecryptMessage.Text = "Decrypt Message";
            this.btn_DecryptMessage.UseVisualStyleBackColor = true;
            this.btn_DecryptMessage.Click += new System.EventHandler(this.btn_DecryptMessage_Click);
            // 
            // lbl_PlainText
            // 
            this.lbl_PlainText.AutoSize = true;
            this.lbl_PlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlainText.Location = new System.Drawing.Point(26, 76);
            this.lbl_PlainText.Name = "lbl_PlainText";
            this.lbl_PlainText.Size = new System.Drawing.Size(60, 15);
            this.lbl_PlainText.TabIndex = 5;
            this.lbl_PlainText.Text = "Plaintext :";
            // 
            // lbl_EncryptedCipherText
            // 
            this.lbl_EncryptedCipherText.AutoSize = true;
            this.lbl_EncryptedCipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EncryptedCipherText.Location = new System.Drawing.Point(26, 207);
            this.lbl_EncryptedCipherText.Name = "lbl_EncryptedCipherText";
            this.lbl_EncryptedCipherText.Size = new System.Drawing.Size(136, 15);
            this.lbl_EncryptedCipherText.TabIndex = 6;
            this.lbl_EncryptedCipherText.Text = "Encrypted to ciphertext :";
            // 
            // lbl_DecryptedPlaintext
            // 
            this.lbl_DecryptedPlaintext.AutoSize = true;
            this.lbl_DecryptedPlaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DecryptedPlaintext.Location = new System.Drawing.Point(26, 332);
            this.lbl_DecryptedPlaintext.Name = "lbl_DecryptedPlaintext";
            this.lbl_DecryptedPlaintext.Size = new System.Drawing.Size(130, 15);
            this.lbl_DecryptedPlaintext.TabIndex = 7;
            this.lbl_DecryptedPlaintext.Text = "Decrypted to plaintext :";
            // 
            // btn_ClearMessage
            // 
            this.btn_ClearMessage.Location = new System.Drawing.Point(614, 162);
            this.btn_ClearMessage.Name = "btn_ClearMessage";
            this.btn_ClearMessage.Size = new System.Drawing.Size(129, 37);
            this.btn_ClearMessage.TabIndex = 10;
            this.btn_ClearMessage.Text = "Clear Message";
            this.btn_ClearMessage.UseVisualStyleBackColor = true;
            this.btn_ClearMessage.Click += new System.EventHandler(this.btn_ClearMessage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(812, 465);
            this.Controls.Add(this.btn_ClearMessage);
            this.Controls.Add(this.lbl_DecryptedPlaintext);
            this.Controls.Add(this.lbl_EncryptedCipherText);
            this.Controls.Add(this.lbl_PlainText);
            this.Controls.Add(this.btn_DecryptMessage);
            this.Controls.Add(this.btn_EncryptMessage);
            this.Controls.Add(this.tbx_DecryptPlaintext);
            this.Controls.Add(this.tbx_CiphertextAndIV);
            this.Controls.Add(this.tbx_Plaintext);
            this.Name = "MainForm";
            this.Text = "AES Cryptography";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbx_Plaintext;
        private System.Windows.Forms.RichTextBox tbx_CiphertextAndIV;
        private System.Windows.Forms.RichTextBox tbx_DecryptPlaintext;
        private System.Windows.Forms.Button btn_EncryptMessage;
        private System.Windows.Forms.Button btn_DecryptMessage;
        private System.Windows.Forms.Label lbl_PlainText;
        private System.Windows.Forms.Label lbl_EncryptedCipherText;
        private System.Windows.Forms.Label lbl_DecryptedPlaintext;
        private System.Windows.Forms.Button btn_ClearMessage;
    }
}

