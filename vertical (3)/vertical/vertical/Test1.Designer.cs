namespace vertical
{
    partial class Test1
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
            this.vLabel1 = new VIBlend.WinForms.Controls.vLabel();
            this.vLabel2 = new VIBlend.WinForms.Controls.vLabel();
            this.txtAge = new VIBlend.WinForms.Controls.vTextBox();
            this.vLabel3 = new VIBlend.WinForms.Controls.vLabel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vLabel1
            // 
            this.vLabel1.BackColor = System.Drawing.Color.Transparent;
            this.vLabel1.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.vLabel1.Ellipsis = false;
            this.vLabel1.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel1.Location = new System.Drawing.Point(246, 149);
            this.vLabel1.Multiline = true;
            this.vLabel1.Name = "vLabel1";
            this.vLabel1.Size = new System.Drawing.Size(169, 23);
            this.vLabel1.TabIndex = 1;
            this.vLabel1.Text = "Enter Name of Crew Member";
            this.vLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel1.UseMnemonics = true;
            this.vLabel1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // vLabel2
            // 
            this.vLabel2.BackColor = System.Drawing.Color.Transparent;
            this.vLabel2.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.vLabel2.Ellipsis = false;
            this.vLabel2.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel2.Location = new System.Drawing.Point(246, 210);
            this.vLabel2.Multiline = true;
            this.vLabel2.Name = "vLabel2";
            this.vLabel2.Size = new System.Drawing.Size(169, 23);
            this.vLabel2.TabIndex = 3;
            this.vLabel2.Text = "Enter Age of Crew Member";
            this.vLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel2.UseMnemonics = true;
            this.vLabel2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.White;
            this.txtAge.BoundsOffset = new System.Drawing.Size(1, 1);
            this.txtAge.ControlBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtAge.DefaultText = "Empty...";
            this.txtAge.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtAge.Location = new System.Drawing.Point(421, 206);
            this.txtAge.MaxLength = 32767;
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAge.SelectionLength = 0;
            this.txtAge.SelectionStart = 0;
            this.txtAge.Size = new System.Drawing.Size(108, 23);
            this.txtAge.TabIndex = 2;
            this.txtAge.Text = "Enter Age";
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAge.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.ECOGREEN;
            // 
            // vLabel3
            // 
            this.vLabel3.BackColor = System.Drawing.Color.Transparent;
            this.vLabel3.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.vLabel3.Ellipsis = false;
            this.vLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vLabel3.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel3.Location = new System.Drawing.Point(246, 29);
            this.vLabel3.Multiline = true;
            this.vLabel3.Name = "vLabel3";
            this.vLabel3.Size = new System.Drawing.Size(330, 36);
            this.vLabel3.TabIndex = 4;
            this.vLabel3.Text = "Enter Details of Crew Member";
            this.vLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel3.UseMnemonics = true;
            this.vLabel3.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(421, 149);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(108, 20);
            this.txtName.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.vLabel3);
            this.Controls.Add(this.vLabel2);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.vLabel1);
            this.Name = "Test1";
            this.Text = "Testing Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VIBlend.WinForms.Controls.vLabel vLabel1;
        private VIBlend.WinForms.Controls.vLabel vLabel2;
        public VIBlend.WinForms.Controls.vTextBox txtAge;
        private VIBlend.WinForms.Controls.vLabel vLabel3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button1;

    }
}