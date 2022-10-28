using System.Collections.Generic;

namespace SocialNetwork.Core
{
    public class Message
    {
        private string message { get; set; } 
        public List<string> MentionedAccount { get; }
        public Message(string message)
        {
            this.message = message;
            MentionedAccount = new List<string> {"Charlie"};
        }
    }
}