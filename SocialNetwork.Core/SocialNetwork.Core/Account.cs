using System.Collections.Generic;
using System.Linq;

namespace SocialNetwork.Core {
    public class Account {
        private readonly List<string> feed;
        private readonly List<string> dashboard;
        public Account(string username)
        {
            dashboard = new List<string>();
            feed = new List<string>();
        }

        public IReadOnlyList<string> FeedFor(Account _) => Feed;

        public IReadOnlyList<string> Feed => feed.AsReadOnly();

        public void PublishOnFeed(string message) {
            feed.Add(message);
        }

        public void Subscribe(Account account)
        {
            foreach (string message in account.Feed)
            {
                dashboard.Add(message);
            }
        }

        public IReadOnlyList<string> Dashboard => dashboard.AsReadOnly(); 
    }
}
