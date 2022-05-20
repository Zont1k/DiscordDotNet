using DiscordDotNet.Objects;
using System;

namespace DiscordDotNet
{
    public enum DiscordChannelCreateType
    {
        PRIVATE, CHANNEL
    }
    public class DiscordChannelCreateEventArgs : EventArgs
    {
        public DiscordChannelCreateType ChannelType { get; set; }
        public DiscordChannel ChannelCreated { get; set; }
    }
}