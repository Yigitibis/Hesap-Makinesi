namespace Hesap_Makinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ekranLabel = new System.Windows.Forms.Label();
            this.rakam1Button = new System.Windows.Forms.Button();
            this.rakam3Button = new System.Windows.Forms.Button();
            this.rakam2Button = new System.Windows.Forms.Button();
            this.artiButton = new System.Windows.Forms.Button();
            this.rakam4Button = new System.Windows.Forms.Button();
            this.rakam5Button = new System.Windows.Forms.Button();
            this.rakam6Button = new System.Windows.Forms.Button();
            this.rakam7Button = new System.Windows.Forms.Button();
            this.rakam8Button = new System.Windows.Forms.Button();
            this.rakam9Button = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.rakam0Button = new System.Windows.Forms.Button();
            this.esitButton = new System.Windows.Forms.Button();
            this.eksiButton = new System.Windows.Forms.Button();
            this.carpıButton = new System.Windows.Forms.Button();
            this.boluButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekranLabel
            // 
            this.ekranLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ekranLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekranLabel.Location = new System.Drawing.Point(12, 31);
            this.ekranLabel.Name = "ekranLabel";
            this.ekranLabel.Size = new System.Drawing.Size(398, 60);
            this.ekranLabel.TabIndex = 0;
            this.ekranLabel.Text = "0";
            this.ekranLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ekranLabel.Click += new System.EventHandler(this.ekranLabel_Click);
            // 
            // rakam1Button
            // 
            this.rakam1Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam1Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.rakam1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam1Button.Location = new System.Drawing.Point(12, 105);
            this.rakam1Button.Name = "rakam1Button";
            this.rakam1Button.Size = new System.Drawing.Size(89, 89);
            this.rakam1Button.TabIndex = 1;
            this.rakam1Button.Text = "1";
            this.rakam1Button.UseVisualStyleBackColor = false;
            this.rakam1Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // rakam3Button
            // 
            this.rakam3Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam3Button.Location = new System.Drawing.Point(202, 105);
            this.rakam3Button.Name = "rakam3Button";
            this.rakam3Button.Size = new System.Drawing.Size(89, 89);
            this.rakam3Button.TabIndex = 2;
            this.rakam3Button.Text = "3";
            this.rakam3Button.UseVisualStyleBackColor = false;
            this.rakam3Button.Click += new System.EventHandler(this.rakam3Button_Click);
            // 
            // rakam2Button
            // 
            this.rakam2Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam2Button.Location = new System.Drawing.Point(107, 105);
            this.rakam2Button.Name = "rakam2Button";
            this.rakam2Button.Size = new System.Drawing.Size(89, 89);
            this.rakam2Button.TabIndex = 3;
            this.rakam2Button.Text = "2";
            this.rakam2Button.UseVisualStyleBackColor = false;
            this.rakam2Button.Click += new System.EventHandler(this.rakam2Button_Click);
            // 
            // artiButton
            // 
            this.artiButton.BackColor = System.Drawing.Color.Crimson;
            this.artiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.artiButton.Location = new System.Drawing.Point(321, 105);
            this.artiButton.Name = "artiButton";
            this.artiButton.Size = new System.Drawing.Size(89, 89);
            this.artiButton.TabIndex = 4;
            this.artiButton.Text = "+";
            this.artiButton.UseVisualStyleBackColor = false;
            this.artiButton.Click += new System.EventHandler(this.artiButton_Click);
            // 
            // rakam4Button
            // 
            this.rakam4Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam4Button.Location = new System.Drawing.Point(12, 200);
            this.rakam4Button.Name = "rakam4Button";
            this.rakam4Button.Size = new System.Drawing.Size(89, 89);
            this.rakam4Button.TabIndex = 5;
            this.rakam4Button.Text = "4";
            this.rakam4Button.UseVisualStyleBackColor = false;
            this.rakam4Button.Click += new System.EventHandler(this.rakam4Button_Click);
            // 
            // rakam5Button
            // 
            this.rakam5Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam5Button.Location = new System.Drawing.Point(107, 200);
            this.rakam5Button.Name = "rakam5Button";
            this.rakam5Button.Size = new System.Drawing.Size(89, 89);
            this.rakam5Button.TabIndex = 6;
            this.rakam5Button.Text = "5";
            this.rakam5Button.UseVisualStyleBackColor = false;
            this.rakam5Button.Click += new System.EventHandler(this.rakam5Button_Click);
            // 
            // rakam6Button
            // 
            this.rakam6Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam6Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam6Button.Location = new System.Drawing.Point(202, 200);
            this.rakam6Button.Name = "rakam6Button";
            this.rakam6Button.Size = new System.Drawing.Size(89, 89);
            this.rakam6Button.TabIndex = 7;
            this.rakam6Button.Text = "6";
            this.rakam6Button.UseVisualStyleBackColor = false;
            this.rakam6Button.Click += new System.EventHandler(this.rakam6Button_Click);
            // 
            // rakam7Button
            // 
            this.rakam7Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam7Button.Location = new System.Drawing.Point(12, 295);
            this.rakam7Button.Name = "rakam7Button";
            this.rakam7Button.Size = new System.Drawing.Size(89, 89);
            this.rakam7Button.TabIndex = 8;
            this.rakam7Button.Text = "7";
            this.rakam7Button.UseVisualStyleBackColor = false;
            this.rakam7Button.Click += new System.EventHandler(this.rakam7Button_Click);
            // 
            // rakam8Button
            // 
            this.rakam8Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam8Button.Location = new System.Drawing.Point(107, 295);
            this.rakam8Button.Name = "rakam8Button";
            this.rakam8Button.Size = new System.Drawing.Size(89, 89);
            this.rakam8Button.TabIndex = 9;
            this.rakam8Button.Text = "8";
            this.rakam8Button.UseVisualStyleBackColor = false;
            this.rakam8Button.Click += new System.EventHandler(this.rakam8Button_Click);
            // 
            // rakam9Button
            // 
            this.rakam9Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam9Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam9Button.Location = new System.Drawing.Point(202, 295);
            this.rakam9Button.Name = "rakam9Button";
            this.rakam9Button.Size = new System.Drawing.Size(89, 89);
            this.rakam9Button.TabIndex = 10;
            this.rakam9Button.Text = "9";
            this.rakam9Button.UseVisualStyleBackColor = false;
            this.rakam9Button.Click += new System.EventHandler(this.rakam9Button_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.Location = new System.Drawing.Point(12, 390);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(89, 89);
            this.button11.TabIndex = 11;
            this.button11.Text = "C";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // rakam0Button
            // 
            this.rakam0Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam0Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam0Button.Location = new System.Drawing.Point(107, 390);
            this.rakam0Button.Name = "rakam0Button";
            this.rakam0Button.Size = new System.Drawing.Size(89, 89);
            this.rakam0Button.TabIndex = 12;
            this.rakam0Button.Text = "0";
            this.rakam0Button.UseVisualStyleBackColor = false;
            this.rakam0Button.Click += new System.EventHandler(this.rakam0Button_Click);
            // 
            // esitButton
            // 
            this.esitButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.esitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.esitButton.Location = new System.Drawing.Point(202, 390);
            this.esitButton.Name = "esitButton";
            this.esitButton.Size = new System.Drawing.Size(89, 89);
            this.esitButton.TabIndex = 13;
            this.esitButton.Text = "=";
            this.esitButton.UseVisualStyleBackColor = false;
            this.esitButton.Click += new System.EventHandler(this.esitButton_Click);
            // 
            // eksiButton
            // 
            this.eksiButton.BackColor = System.Drawing.Color.Crimson;
            this.eksiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eksiButton.Location = new System.Drawing.Point(321, 200);
            this.eksiButton.Name = "eksiButton";
            this.eksiButton.Size = new System.Drawing.Size(89, 89);
            this.eksiButton.TabIndex = 14;
            this.eksiButton.Text = "-";
            this.eksiButton.UseVisualStyleBackColor = false;
            this.eksiButton.Click += new System.EventHandler(this.eksiButton_Click);
            // 
            // carpıButton
            // 
            this.carpıButton.BackColor = System.Drawing.Color.Crimson;
            this.carpıButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carpıButton.Location = new System.Drawing.Point(321, 295);
            this.carpıButton.Name = "carpıButton";
            this.carpıButton.Size = new System.Drawing.Size(89, 89);
            this.carpıButton.TabIndex = 15;
            this.carpıButton.Text = "x";
            this.carpıButton.UseVisualStyleBackColor = false;
            this.carpıButton.Click += new System.EventHandler(this.carpıButton_Click);
            // 
            // boluButton
            // 
            this.boluButton.BackColor = System.Drawing.Color.Crimson;
            this.boluButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boluButton.Location = new System.Drawing.Point(321, 390);
            this.boluButton.Name = "boluButton";
            this.boluButton.Size = new System.Drawing.Size(89, 89);
            this.boluButton.TabIndex = 16;
            this.boluButton.Text = "/";
            this.boluButton.UseVisualStyleBackColor = false;
            this.boluButton.Click += new System.EventHandler(this.boluButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 494);
            this.Controls.Add(this.boluButton);
            this.Controls.Add(this.carpıButton);
            this.Controls.Add(this.eksiButton);
            this.Controls.Add(this.esitButton);
            this.Controls.Add(this.rakam0Button);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.rakam9Button);
            this.Controls.Add(this.rakam8Button);
            this.Controls.Add(this.rakam7Button);
            this.Controls.Add(this.rakam6Button);
            this.Controls.Add(this.rakam5Button);
            this.Controls.Add(this.rakam4Button);
            this.Controls.Add(this.artiButton);
            this.Controls.Add(this.rakam2Button);
            this.Controls.Add(this.rakam3Button);
            this.Controls.Add(this.rakam1Button);
            this.Controls.Add(this.ekranLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ekranLabel;
        private System.Windows.Forms.Button rakam1Button;
        private System.Windows.Forms.Button rakam3Button;
        private System.Windows.Forms.Button rakam2Button;
        private System.Windows.Forms.Button artiButton;
        private System.Windows.Forms.Button rakam4Button;
        private System.Windows.Forms.Button rakam5Button;
        private System.Windows.Forms.Button rakam6Button;
        private System.Windows.Forms.Button rakam7Button;
        private System.Windows.Forms.Button rakam8Button;
        private System.Windows.Forms.Button rakam9Button;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button rakam0Button;
        private System.Windows.Forms.Button esitButton;
        private System.Windows.Forms.Button eksiButton;
        private System.Windows.Forms.Button carpıButton;
        private System.Windows.Forms.Button boluButton;
    }
}

