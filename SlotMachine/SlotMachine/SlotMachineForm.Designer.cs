namespace SlotMachine
{
    partial class SlotMachineForm
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
            this.SpinPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bet50picture = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bet2picture = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.bet25picture = new System.Windows.Forms.PictureBox();
            this.credittextbox = new System.Windows.Forms.TextBox();
            this.bettextbox = new System.Windows.Forms.TextBox();
            this.winnerpaidtextbox = new System.Windows.Forms.TextBox();
            this.headtextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet50picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet2picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet25picture)).BeginInit();
            this.SuspendLayout();
            // 
            // SpinPictureBox
            // 
            this.SpinPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SpinPictureBox.Image = global::SlotMachine.Properties.Resources.spin;
            this.SpinPictureBox.Location = new System.Drawing.Point(336, 436);
            this.SpinPictureBox.Name = "SpinPictureBox";
            this.SpinPictureBox.Size = new System.Drawing.Size(60, 50);
            this.SpinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinPictureBox.TabIndex = 6;
            this.SpinPictureBox.TabStop = false;
            this.SpinPictureBox.Click += new System.EventHandler(this.SpinPictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SlotMachine.Properties.Resources.powerbutton;
            this.pictureBox1.Location = new System.Drawing.Point(281, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SlotMachine.Properties.Resources.reset;
            this.pictureBox2.Location = new System.Drawing.Point(65, 436);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // bet50picture
            // 
            this.bet50picture.Image = global::SlotMachine.Properties.Resources.bet50;
            this.bet50picture.Location = new System.Drawing.Point(126, 436);
            this.bet50picture.Name = "bet50picture";
            this.bet50picture.Size = new System.Drawing.Size(49, 50);
            this.bet50picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bet50picture.TabIndex = 7;
            this.bet50picture.TabStop = false;
            this.bet50picture.Tag = "50";
            this.bet50picture.ClientSizeChanged += new System.EventHandler(this.betboxclick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(-81, 460);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 50);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // bet2picture
            // 
            this.bet2picture.Image = global::SlotMachine.Properties.Resources.bet2;
            this.bet2picture.Location = new System.Drawing.Point(222, 436);
            this.bet2picture.Name = "bet2picture";
            this.bet2picture.Size = new System.Drawing.Size(49, 50);
            this.bet2picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bet2picture.TabIndex = 7;
            this.bet2picture.TabStop = false;
            this.bet2picture.Tag = "2";
            this.bet2picture.Click += new System.EventHandler(this.betboxclick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::SlotMachine.Properties.Resources.powerbutton;
            this.pictureBox7.Location = new System.Drawing.Point(281, 436);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(49, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::SlotMachine.Properties.Resources.orange;
            this.pictureBox9.Location = new System.Drawing.Point(194, 230);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(77, 122);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 7;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::SlotMachine.Properties.Resources.seven;
            this.pictureBox10.Location = new System.Drawing.Point(81, 230);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(75, 122);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 7;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SlotMachine.Properties.Resources.bar;
            this.pictureBox6.Location = new System.Drawing.Point(306, 230);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(77, 122);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // bet25picture
            // 
            this.bet25picture.Image = global::SlotMachine.Properties.Resources.bet25;
            this.bet25picture.Location = new System.Drawing.Point(169, 436);
            this.bet25picture.Name = "bet25picture";
            this.bet25picture.Size = new System.Drawing.Size(49, 50);
            this.bet25picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bet25picture.TabIndex = 7;
            this.bet25picture.TabStop = false;
            this.bet25picture.Tag = "25";
            this.bet25picture.Click += new System.EventHandler(this.betboxclick);
            // 
            // credittextbox
            // 
            this.credittextbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.credittextbox.ForeColor = System.Drawing.SystemColors.Info;
            this.credittextbox.Location = new System.Drawing.Point(75, 378);
            this.credittextbox.Name = "credittextbox";
            this.credittextbox.ReadOnly = true;
            this.credittextbox.Size = new System.Drawing.Size(100, 20);
            this.credittextbox.TabIndex = 9;
            this.credittextbox.Text = "Credits";
            // 
            // bettextbox
            // 
            this.bettextbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bettextbox.ForeColor = System.Drawing.SystemColors.Info;
            this.bettextbox.Location = new System.Drawing.Point(194, 378);
            this.bettextbox.Name = "bettextbox";
            this.bettextbox.ReadOnly = true;
            this.bettextbox.Size = new System.Drawing.Size(64, 20);
            this.bettextbox.TabIndex = 9;
            this.bettextbox.Text = "Value";
            // 
            // winnerpaidtextbox
            // 
            this.winnerpaidtextbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.winnerpaidtextbox.ForeColor = System.Drawing.SystemColors.Info;
            this.winnerpaidtextbox.Location = new System.Drawing.Point(283, 378);
            this.winnerpaidtextbox.Name = "winnerpaidtextbox";
            this.winnerpaidtextbox.ReadOnly = true;
            this.winnerpaidtextbox.Size = new System.Drawing.Size(100, 20);
            this.winnerpaidtextbox.TabIndex = 9;
            this.winnerpaidtextbox.Text = "Amount";
            // 
            // headtextbox
            // 
            this.headtextbox.Location = new System.Drawing.Point(181, 164);
            this.headtextbox.Name = "headtextbox";
            this.headtextbox.ReadOnly = true;
            this.headtextbox.Size = new System.Drawing.Size(100, 20);
            this.headtextbox.TabIndex = 9;
            // 
            // SlotMachineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SlotMachine.Properties.Resources.slotmachine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(462, 533);
            this.Controls.Add(this.winnerpaidtextbox);
            this.Controls.Add(this.headtextbox);
            this.Controls.Add(this.bettextbox);
            this.Controls.Add(this.credittextbox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.bet50picture);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.bet25picture);
            this.Controls.Add(this.bet2picture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SpinPictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SlotMachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet50picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet2picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet25picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox SpinPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox bet50picture;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox bet2picture;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox bet25picture;
        private System.Windows.Forms.TextBox credittextbox;
        private System.Windows.Forms.TextBox bettextbox;
        private System.Windows.Forms.TextBox winnerpaidtextbox;
        private System.Windows.Forms.TextBox headtextbox;
    }
}