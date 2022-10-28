using System.Linq;
using NUnit.Framework;

namespace SocialNetwork.Core.Tests;

public class Tests {
    [SetUp]
    public void Setup() {
    }

    [Test]
    public void CanPublishMessagesOnMyOwnFeed() {
        var thomas = new Account("Thomas");
        var message = "Hello, World!";
        thomas.PublishOnFeed(message);
        Assert.That(thomas.Feed.Contains(message));
    }
}
