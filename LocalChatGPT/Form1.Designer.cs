namespace LocalChatGPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.modernPanel1 = new ModernUI.Controls.ModernPanel();
            this.modernPanel3 = new ModernUI.Controls.ModernPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.modernTextBox1 = new ModernUI.Controls.ModernTextBox();
            this.modernPanel2 = new ModernUI.Controls.ModernPanel();
            this.ChatList = new System.Windows.Forms.FlowLayoutPanel();
            this.modernPanel4 = new ModernUI.Controls.ModernPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chatPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.modernScrollBar1 = new ModernScrollBar();
            this.modernPanel1.SuspendLayout();
            this.modernPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.modernPanel2.SuspendLayout();
            this.modernPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // modernPanel1
            // 
            this.modernPanel1.BackColorCustom = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.modernPanel1.Controls.Add(this.modernPanel3);
            this.modernPanel1.Controls.Add(this.modernTextBox1);
            this.modernPanel1.CornerRadius = 30;
            this.modernPanel1.Location = new System.Drawing.Point(401, 647);
            this.modernPanel1.Name = "modernPanel1";
            this.modernPanel1.Size = new System.Drawing.Size(737, 131);
            this.modernPanel1.TabIndex = 1;
            // 
            // modernPanel3
            // 
            this.modernPanel3.BackColor = System.Drawing.Color.Transparent;
            this.modernPanel3.BackColorCustom = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.modernPanel3.Controls.Add(this.pictureBox1);
            this.modernPanel3.CornerRadius = 20;
            this.modernPanel3.Location = new System.Drawing.Point(686, 13);
            this.modernPanel3.Name = "modernPanel3";
            this.modernPanel3.Size = new System.Drawing.Size(40, 40);
            this.modernPanel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // modernTextBox1
            // 
            this.modernTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.modernTextBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.modernTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.modernTextBox1.BorderRadius = 16;
            this.modernTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernTextBox1.Location = new System.Drawing.Point(14, 9);
            this.modernTextBox1.Multiline = true;
            this.modernTextBox1.Name = "modernTextBox1";
            this.modernTextBox1.Padding = new System.Windows.Forms.Padding(10);
            this.modernTextBox1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.modernTextBox1.PlaceholderText = "Enter text...";
            this.modernTextBox1.Size = new System.Drawing.Size(676, 70);
            this.modernTextBox1.TabIndex = 1;
            this.modernTextBox1.TextBoxText = "";
            this.modernTextBox1.TextColor = System.Drawing.Color.White;
            // 
            // modernPanel2
            // 
            this.modernPanel2.BackColorCustom = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.modernPanel2.Controls.Add(this.ChatList);
            this.modernPanel2.Controls.Add(this.modernPanel4);
            this.modernPanel2.CornerRadius = 30;
            this.modernPanel2.Location = new System.Drawing.Point(-19, -1);
            this.modernPanel2.Name = "modernPanel2";
            this.modernPanel2.Size = new System.Drawing.Size(262, 717);
            this.modernPanel2.TabIndex = 2;
            // 
            // ChatList
            // 
            this.ChatList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ChatList.Location = new System.Drawing.Point(32, 68);
            this.ChatList.Name = "ChatList";
            this.ChatList.Size = new System.Drawing.Size(217, 553);
            this.ChatList.TabIndex = 5;
            // 
            // modernPanel4
            // 
            this.modernPanel4.BackColor = System.Drawing.Color.Transparent;
            this.modernPanel4.BackColorCustom = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.modernPanel4.Controls.Add(this.pictureBox2);
            this.modernPanel4.CornerRadius = 20;
            this.modernPanel4.Location = new System.Drawing.Point(211, 666);
            this.modernPanel4.Name = "modernPanel4";
            this.modernPanel4.Size = new System.Drawing.Size(40, 40);
            this.modernPanel4.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // chatPanel
            // 
            this.chatPanel.AutoScroll = true;
            this.chatPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.chatPanel.Location = new System.Drawing.Point(401, 25);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(737, 595);
            this.chatPanel.TabIndex = 3;
            this.chatPanel.WrapContents = false;
            // 
            // modernScrollBar1
            // 
            this.modernScrollBar1.BorderRadius = 5;
            this.modernScrollBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modernScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.modernScrollBar1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.modernScrollBar1.LinkedControl = null;
            this.modernScrollBar1.Location = new System.Drawing.Point(1271, 0);
            this.modernScrollBar1.Name = "modernScrollBar1";
            this.modernScrollBar1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.modernScrollBar1.Size = new System.Drawing.Size(10, 716);
            this.modernScrollBar1.TabIndex = 4;
            this.modernScrollBar1.Text = "modernScrollBar1";
            this.modernScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.modernScrollBar1.ThumbSize = 50;
            this.modernScrollBar1.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1281, 716);
            this.Controls.Add(this.modernScrollBar1);
            this.Controls.Add(this.chatPanel);
            this.Controls.Add(this.modernPanel2);
            this.Controls.Add(this.modernPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local AI";
            this.modernPanel1.ResumeLayout(false);
            this.modernPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.modernPanel2.ResumeLayout(false);
            this.modernPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ModernUI.Controls.ModernPanel modernPanel1;
        private ModernUI.Controls.ModernTextBox modernTextBox1;
        private ModernUI.Controls.ModernPanel modernPanel2;
        private ModernUI.Controls.ModernPanel modernPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel chatPanel;
        private ModernScrollBar modernScrollBar1;
        private ModernUI.Controls.ModernPanel modernPanel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel ChatList;
    }
}

