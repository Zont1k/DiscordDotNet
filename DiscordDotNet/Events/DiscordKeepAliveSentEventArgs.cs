using System;
using DiscordDotNet.Objects;
namespace DiscordDotNet
{
    public class DiscordKeepAliveSentEventArgs : EventArgs
    {
        public DateTime SentAt { get; set; }
        public string JsonSent { get; set; }
    }
}