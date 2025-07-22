using OllamaSharp;
using OllamaSharp.Models.Chat;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LocalChatGPT
{
    public partial class Form1 : Form
    {
        //Hello, this project is a mess and should be optimized which I will do trust me.
        //Ton of StackOverflow and online tutorials slapped into one project.
        //Enjoy mate.

        private Chat chat;
        private OllamaApiClient ollama;
        private ChatSession currentSession;
        private string currentChatFile;

        public Form1()
        {
            InitializeComponent();

            Directory.CreateDirectory("Chats");
            StartOllama();
            LoadAllChats();

            if (ChatList.Controls.Count == 0)
            {
                CreateNewChat();
            }

            else
            {
                LoadFirstChat();
            }
        }

        private void StartOllama()
        {
            var uri = new Uri("http://localhost:11434");
            ollama = new OllamaApiClient(uri)
            { 
                SelectedModel = "llama3:latest" //Model name goes here.
            };

            chat = new Chat(ollama);
        }

        private void LoadFirstChat()
        {
            if (ChatList.Controls.Count > 0)
            {
                var FirstChat = ChatList.Controls[0] as ChatItem;

                if (FirstChat != null)
                {
                    LoadChat(FirstChat.FilePath);
                }
            }
        }

        private void LoadChat(string filePath)
        {
            var Session = LoadChatFromFile(filePath);
            currentSession = Session;
            currentChatFile = filePath;

            chat.Messages.Clear();
            chatPanel.Controls.Clear();
            chatPanel.Controls.Add(CreateLabel("ChatGPT Local message"));
            chatPanel.Controls.Add(new ModernMessageBubble("Welcome to your new ChatGPT but local. No internet connection needed. No data collected by massive corps. Choose between a lot of different AI models, all runing locally.", false));

            foreach (var message in Session.Messages)
            {
                bool IsUser = message.Role == "user";
                chat.Messages.Add(new OllamaSharp.Models.Chat.Message
                { 
                    Role = IsUser ? ChatRole.User : ChatRole.Assistant, 
                    Content = message.Content 
                });
                chatPanel.Controls.Add(new ModernMessageBubble(message.Content, IsUser));
            }

            chatPanel.ScrollControlIntoView(chatPanel.Controls[chatPanel.Controls.Count - 1]);
        }

        private void LoadAllChats()
        {
            ChatList.Controls.Clear();

            foreach (var Path in Directory.GetFiles("Chats", "*.json"))
            { 
                AddChatToSidebar(LoadChatFromFile(Path), Path);
            }
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            //Stack overflow mess.

            var Message = modernTextBox1.TextBoxText.Trim();
            modernTextBox1.TextBoxText = "";

            if (string.IsNullOrEmpty(Message)) return;

            chat.Messages.Add(new OllamaSharp.Models.Chat.Message { Role = ChatRole.User, Content = Message });
            currentSession.Messages.Add(new SerializableMessage { Role = "user", Content = Message });

            chatPanel.Controls.Add(new ModernMessageBubble(Message, true));

            var sb = new StringBuilder();
            var enumerator = chat.SendAsync(Message).GetAsyncEnumerator();

            try
            {
                while (await enumerator.MoveNextAsync())
                {
                    sb.Append(enumerator.Current);
                }
            }

            finally
            {
                await enumerator.DisposeAsync();
            }

            var reply = sb.ToString();

            chat.Messages.Add(new OllamaSharp.Models.Chat.Message { Role = ChatRole.Assistant, Content = reply });
            currentSession.Messages.Add(new SerializableMessage { Role = "assistant", Content = reply });

            chatPanel.Controls.Add(CreateLabel("llama 3"));
            chatPanel.Controls.Add(new ModernMessageBubble(reply, false));

            chatPanel.ScrollControlIntoView(chatPanel.Controls[chatPanel.Controls.Count - 1]);

            SaveChat(currentSession, currentChatFile);
        }

        private Label CreateLabel(string text)
        {
            Label label = new Label()
            {
                Text = text,
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 8, FontStyle.Italic),
                AutoSize = true,
                Padding = new Padding(10, 0, 0, 0)
            };

            return label;
        }

        private void SaveChat(ChatSession session, string Path)
        {
            File.WriteAllText(Path, JsonConvert.SerializeObject(session, Formatting.Indented));
        }

        private ChatSession LoadChatFromFile(string Path)
        {
            return JsonConvert.DeserializeObject<ChatSession>(File.ReadAllText(Path));
        }

        private void CreateNewChat()
        {
            string ChatName = $"Chat {Directory.GetFiles("Chats").Length + 1}";
            string ChatFile = Path.Combine("Chats", $"{ChatName}.json");

            var Session = new ChatSession
            {
                Id = Guid.NewGuid().ToString(),
                Name = ChatName,
                Messages = new List<SerializableMessage>()
            };

            SaveChat(Session, ChatFile);

            currentSession = Session;
            currentChatFile = ChatFile;

            AddChatToSidebar(Session, ChatFile);
            LoadChat(ChatFile);
        }

        private void AddChatToSidebar(ChatSession session, string Path)
        {
            ChatItem ChatItem = new ChatItem(session.Name, Path);

            ChatItem.Click += (s, e) =>
            {
                LoadChat(Path);
            };

            ChatItem.Deleted += (s, e) =>
            {
                DeleteChat(ChatItem);
            };

            ChatList.Controls.Add(ChatItem);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var ID = Guid.NewGuid().ToString();
            var ChatName = $"Chat {Directory.GetFiles("Chats").Length + 1}";

            var session = new ChatSession
            {
                Id = ID,
                Name = ChatName,
                Messages = new List<SerializableMessage>()
            };

            Directory.CreateDirectory("Chats");
            var ChatFile = Path.Combine("Chats", $"{ChatName}.json");
            SaveChat(session, ChatFile);

            currentSession = session;
            currentChatFile = ChatFile;

            AddChatToSidebar(session, ChatFile);
            LoadChat(ChatFile);
        }

        private void DeleteChat(ChatItem ChatItem)
        {
            if (File.Exists(ChatItem.FilePath))
            {
                File.Delete(ChatItem.FilePath);
            }

            ChatList.Controls.Remove(ChatItem);

            if (currentChatFile == ChatItem.FilePath)
            {
                chatPanel.Controls.Clear();
                currentSession = null;
                currentChatFile = null;
            }
        }
    }
}
