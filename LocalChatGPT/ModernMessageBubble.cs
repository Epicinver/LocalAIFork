using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OllamaSharp.Models.Chat;
using System.Security;

namespace LocalChatGPT
{
    public partial class ModernMessageBubble: UserControl
    {
        //Nah but this part is vibe coded. I tried my best.

        private Label lblMessage;
        public bool IsUser { get; private set; }
        private const int TotalWidth = 737;
        private const int HorizontalPadding = 20;

        public ModernMessageBubble(string message, bool isUser)
        {
            IsUser = isUser;
            InitializeComponents();
            SetMessage(message);
            StyleBubble();
        }

        private void InitializeComponents()
        {
            this.AutoSize = true;

            this.MaximumSize = new Size(TotalWidth, 0);
            this.Padding = new Padding(15);
            this.Margin = new Padding(0, 5, 0, 5);

            lblMessage = new Label
            {
                AutoSize = true,
                MaximumSize = new Size(TotalWidth - (HorizontalPadding * 2), 0),
                Location = new Point(10, 10),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10)
            };

            this.Controls.Add(lblMessage);

            if (IsUser)
            {
                this.Anchor = AnchorStyles.Right;
                this.Dock = DockStyle.Right;
            }

            else
            {
                this.Anchor = AnchorStyles.Left;
                this.Dock = DockStyle.Left;
            }
        }

        private void StyleBubble()
        {
            this.BackColor = IsUser ? Color.FromArgb(50, 50, 50) : Color.FromArgb(60, 60, 60);
            this.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, this.Width, this.Height, 16, 16));
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, this.Width, this.Height, 16, 16));
        }

        public void UpdateText(string message)
        {
            if (lblMessage.InvokeRequired)
            {
                lblMessage.Invoke(new Action(() => lblMessage.Text = message));
            }
            else
            {
                lblMessage.Text = message;
            }
        }

        public void SetMessage(string message)
        {
            lblMessage.Text = message;
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
    }
}
