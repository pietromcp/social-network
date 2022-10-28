using SocialNetwork.Core;

public class Program {
    public static void Main() {
        var account = new Account("Thomas");
        account.PublishOnFeed("Hello, World!");
        
        Console.WriteLine(account.Feed);
    }
}