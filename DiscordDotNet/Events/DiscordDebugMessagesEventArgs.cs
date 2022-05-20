using System;
using DiscordDotNet.Objects;
namespace DiscordDotNet
{
    public class DiscordDebugMessagesEventArgs : EventArgs
    {
        public string Message { get; internal set; }
    }
}