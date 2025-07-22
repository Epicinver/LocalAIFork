using System;
using System.Collections.Generic;

namespace LocalChatGPT
{
    public class ChatSession
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<SerializableMessage> Messages { get; set; }
    }

    public class SerializableMessage
    {
        public string Role { get; set; }
        public string Content { get; set; }
    }
}