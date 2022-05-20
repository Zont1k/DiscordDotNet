using System;
using DiscordDotNet.Objects;
namespace DiscordDotNet
{
    public class DiscordConnectEventArgs : EventArgs
    {
        public DiscordMember User { get; internal set; }
    }
}