using System;
using DiscordDotNet.Objects;
namespace DiscordDotNet
{
    public class DiscordGuildBanEventArgs : EventArgs
    {
        public DiscordMember MemberBanned { get; internal set; }
        public DiscordServer Server { get; internal set; }
    }
}