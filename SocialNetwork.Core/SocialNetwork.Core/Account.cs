using System.Collections.Generic;

namespace SocialNetwork.Core {
    public class Account {
        private readonly List<string> feed;
        
        public Account(string username) {
            feed = new List<string>();
        }

        public IReadOnlyList<string> Feed => feed.AsReadOnly();

        public void PublishOnFeed(string message) {
            feed.Add(message);
        }
    }
}
