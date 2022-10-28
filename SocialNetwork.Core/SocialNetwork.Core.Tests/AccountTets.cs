using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace SocialNetwork.Core.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CanPublishMessagesOnMyOwnFeed()
    {
        var thomas = new Account("Thomas");
        var message = "Hello, World!";
        thomas.PublishOnFeed(message);
        Assert.That(thomas.Feed.Contains(message));
    }
    [Test]
    public void AnotherAccountCanSeeAnotherFeed()
    {
        var thomas = new Account("Thomas");
        var message = "Hello, World!";
        thomas.PublishOnFeed(message);
        var alice = new Account("Alice");
        Assert.That(thomas.FeedFor(alice).Contains(message));
    }

    [Test]
    public void CanSubscribeToAnotherFeed()
    {
        var charlie = new Account("Charlie");
        var thomas = new Account("Thomas");
        var alice = new Account("Alice");
        
        var messageThomas = "Hello, World!";
        var messageAlice = "Ciao, Mondo!";
        
        thomas.PublishOnFeed(messageThomas);
        alice.PublishOnFeed(messageAlice);

        charlie.Subscribe(thomas);
        charlie.Subscribe(alice);

        Assert.That(charlie.Dashboard.Contains(messageThomas));
        Assert.That(charlie.Dashboard.Contains(messageAlice));
    }
}
