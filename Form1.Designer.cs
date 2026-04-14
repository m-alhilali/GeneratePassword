namespace PasswordGenerator
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbPasswordLength = new System.Windows.Forms.GroupBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.lblLengthPassword = new System.Windows.Forms.Label();
            this.gbPasswordCharacters = new System.Windows.Forms.GroupBox();
            this.checkMix = new System.Windows.Forms.CheckBox();
            this.checkabs = new System.Windows.Forms.CheckBox();
            this.checkPunct = new System.Windows.Forms.CheckBox();
            this.check123 = new System.Windows.Forms.CheckBox();
            this.checkABC = new System.Windows.Forms.CheckBox();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.gbPasswordLength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.gbPasswordCharacters.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Sitka Small", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitle.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1118, 58);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PASSWORD  GENERATOR";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textPassword.Location = new System.Drawing.Point(339, 146);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(445, 49);
            this.textPassword.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.Aqua;
            this.btnGenerate.Location = new System.Drawing.Point(261, 256);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(130, 44);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            this.btnGenerate.MouseEnter += new System.EventHandler(this.ChangeButtonSize);
            this.btnGenerate.MouseLeave += new System.EventHandler(this.ResetButtonSize);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.Transparent;
            this.btnCopy.Enabled = false;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCopy.Location = new System.Drawing.Point(497, 256);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(120, 44);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "COPY";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            this.btnCopy.MouseEnter += new System.EventHandler(this.ChangeButtonSize);
            this.btnCopy.MouseLeave += new System.EventHandler(this.ResetButtonSize);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Crimson;
            this.btnReset.Location = new System.Drawing.Point(752, 260);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 44);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.ChangeButtonSize);
            this.btnReset.MouseLeave += new System.EventHandler(this.ResetButtonSize);
            // 
            // gbPasswordLength
            // 
            this.gbPasswordLength.BackColor = System.Drawing.Color.Transparent;
            this.gbPasswordLength.Controls.Add(this.trackBar);
            this.gbPasswordLength.Controls.Add(this.lblLengthPassword);
            this.gbPasswordLength.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbPasswordLength.ForeColor = System.Drawing.SystemColors.Window;
            this.gbPasswordLength.Location = new System.Drawing.Point(170, 363);
            this.gbPasswordLength.Name = "gbPasswordLength";
            this.gbPasswordLength.Size = new System.Drawing.Size(294, 124);
            this.gbPasswordLength.TabIndex = 6;
            this.gbPasswordLength.TabStop = false;
            this.gbPasswordLength.Text = "Password Length";
            // 
            // trackBar
            // 
            this.trackBar.AutoSize = false;
            this.trackBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBar.LargeChange = 3;
            this.trackBar.Location = new System.Drawing.Point(15, 74);
            this.trackBar.Maximum = 30;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(263, 33);
            this.trackBar.SmallChange = 5;
            this.trackBar.TabIndex = 1;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lblLengthPassword
            // 
            this.lblLengthPassword.AutoSize = true;
            this.lblLengthPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthPassword.Location = new System.Drawing.Point(129, 42);
            this.lblLengthPassword.Name = "lblLengthPassword";
            this.lblLengthPassword.Size = new System.Drawing.Size(28, 29);
            this.lblLengthPassword.TabIndex = 0;
            this.lblLengthPassword.Text = "0";
            // 
            // gbPasswordCharacters
            // 
            this.gbPasswordCharacters.BackColor = System.Drawing.Color.Transparent;
            this.gbPasswordCharacters.Controls.Add(this.checkMix);
            this.gbPasswordCharacters.Controls.Add(this.checkabs);
            this.gbPasswordCharacters.Controls.Add(this.checkPunct);
            this.gbPasswordCharacters.Controls.Add(this.check123);
            this.gbPasswordCharacters.Controls.Add(this.checkABC);
            this.gbPasswordCharacters.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gbPasswordCharacters.ForeColor = System.Drawing.SystemColors.Window;
            this.gbPasswordCharacters.Location = new System.Drawing.Point(650, 363);
            this.gbPasswordCharacters.Name = "gbPasswordCharacters";
            this.gbPasswordCharacters.Size = new System.Drawing.Size(294, 124);
            this.gbPasswordCharacters.TabIndex = 7;
            this.gbPasswordCharacters.TabStop = false;
            this.gbPasswordCharacters.Text = "Password Characters";
            // 
            // checkMix
            // 
            this.checkMix.AutoSize = true;
            this.checkMix.Font = new System.Drawing.Font("Tahoma", 9F);
            this.checkMix.Location = new System.Drawing.Point(195, 50);
            this.checkMix.Name = "checkMix";
            this.checkMix.Size = new System.Drawing.Size(63, 26);
            this.checkMix.TabIndex = 4;
            this.checkMix.Text = "Mix";
            this.checkMix.UseVisualStyleBackColor = true;
            // 
            // checkabs
            // 
            this.checkabs.AutoSize = true;
            this.checkabs.Font = new System.Drawing.Font("Tahoma", 9F);
            this.checkabs.Location = new System.Drawing.Point(176, 95);
            this.checkabs.Name = "checkabs";
            this.checkabs.Size = new System.Drawing.Size(63, 26);
            this.checkabs.TabIndex = 3;
            this.checkabs.Text = "abc";
            this.checkabs.UseVisualStyleBackColor = true;
            // 
            // checkPunct
            // 
            this.checkPunct.AutoSize = true;
            this.checkPunct.Font = new System.Drawing.Font("Tahoma", 9F);
            this.checkPunct.Location = new System.Drawing.Point(59, 95);
            this.checkPunct.Name = "checkPunct";
            this.checkPunct.Size = new System.Drawing.Size(75, 26);
            this.checkPunct.TabIndex = 2;
            this.checkPunct.Text = "@#$";
            this.checkPunct.UseVisualStyleBackColor = true;
            // 
            // check123
            // 
            this.check123.AutoSize = true;
            this.check123.Font = new System.Drawing.Font("Tahoma", 9F);
            this.check123.Location = new System.Drawing.Point(102, 50);
            this.check123.Name = "check123";
            this.check123.Size = new System.Drawing.Size(66, 26);
            this.check123.TabIndex = 1;
            this.check123.Text = "123";
            this.check123.UseVisualStyleBackColor = true;
            // 
            // checkABC
            // 
            this.checkABC.AutoSize = true;
            this.checkABC.Font = new System.Drawing.Font("Tahoma", 9F);
            this.checkABC.Location = new System.Drawing.Point(19, 50);
            this.checkABC.Name = "checkABC";
            this.checkABC.Size = new System.Drawing.Size(69, 26);
            this.checkABC.TabIndex = 0;
            this.checkABC.Text = "ABC";
            this.checkABC.UseVisualStyleBackColor = true;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblSubTitle.Location = new System.Drawing.Point(261, 86);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(791, 29);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "GENERATE STRONG PASSWORD AND KEEP YIUR ACCOUNT SAFE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::PasswordGenerator.Properties.Resources.generatebasswordicon;
            this.ClientSize = new System.Drawing.Size(1118, 559);
            this.Controls.Add(this.gbPasswordCharacters);
            this.Controls.Add(this.gbPasswordLength);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPasswordLength.ResumeLayout(false);
            this.gbPasswordLength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.gbPasswordCharacters.ResumeLayout(false);
            this.gbPasswordCharacters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbPasswordLength;
        private System.Windows.Forms.Label lblLengthPassword;
        private System.Windows.Forms.GroupBox gbPasswordCharacters;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.CheckBox checkMix;
        private System.Windows.Forms.CheckBox checkabs;
        private System.Windows.Forms.CheckBox checkPunct;
        private System.Windows.Forms.CheckBox check123;
        private System.Windows.Forms.CheckBox checkABC;
        private System.Windows.Forms.Label lblSubTitle;
    }
}

