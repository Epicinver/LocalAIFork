using System;
using System.Drawing;
using System.Windows.Forms;

namespace LocalChatGPT
{
    public partial class ChatItem : UserControl
    {
        public string FilePath { get; private set; }
        public event EventHandler Deleted;

        public ChatItem(string ChatName, string Path)
        {
            InitializeComponent();

            FilePath = Path;
            NameLabel.Text = ChatName;
        }

        private void ChatItem_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void ChatItem_MouseEnter(object sender, EventArgs e)
        {
            if (TrashButton.Visible == false)
            {
                TrashButton.Visible = true;
            }
        }

        private void ChatItem_MouseLeave(object sender, EventArgs e)
        {
            Point MousePosition = this.PointToClient(Cursor.Position);

            if (!ClientRectangle.Contains(MousePosition))
            {
                TrashButton.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Deleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
