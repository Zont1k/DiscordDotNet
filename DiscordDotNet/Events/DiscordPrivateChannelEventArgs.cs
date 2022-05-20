using System;
using DiscordDotNet.Objects;

namespace DiscordDotNet
{
    public class DiscordPrivateChannelEventArgs : EventArgs
    { 
        public DiscordChannelCreateType ChannelType { get; set; }
        public DiscordPrivateChannel ChannelCreated { get; set; }
    }
}