using Newtonsoft.Json.Linq;
using System;
using DiscordDotNet.Objects;
namespace DiscordDotNet.Events
{
    public class DiscordMessageDeletedEventArgs : EventArgs
    {
        public DiscordMessage DeletedMessage { get; internal set; }
        public DiscordChannel Channel { get; internal set; }
        public JObject RawJson { get; internal set; }
    }

    public class DiscordPrivateMessageDeletedEventArgs : DiscordMessageDeletedEventArgs
    {
        public new DiscordPrivateChannel Channel { get; internal set; }
    }
}
