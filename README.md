
![DDotNet](https://user-images.githubusercontent.com/82260790/169623650-6f583f89-79fa-40ac-84ff-06663592289c.png)

Welcome to the DiscordDotNet dev branch!

A C# API for Discord.

# From Nuget

DiscordDotNet is now available on NuGet! It is marked as pre-release package at the moment. At your package manager console, type
`Install-Package DiscordSharp -Pre` and it will install the additional dependencies (Newtonsoft.Json & websocket-sharp)

# How to use

Discord is what I like to call an *"event-based"* client. In other words, you get your instance of your client and hook up to its various events: either by lambda or by delegating to external voids. A simple example is as follows..

```
DiscordClient client = new DiscordClient();
client.ClientPrivateInformation.Email = "email";
client.ClientPrivateInformation.Password = "pass";

client.Connected += (sender, e) =>
{
  Console.WriteLine($"Connected! User: {e.User.Username}");
};
client.SendLoginRequest();
Thread t = new Thread(client.Connect);
t.Start();
```
This will get you logged in and print out a login notification to the console with the username you've logged in as.

## Example Bot
* https://github.com/NaamloosDT/DiscordSharp_Starter 
 * Kindly donated by NaamloosDT :)
