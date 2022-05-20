using System;
using DiscordDotNet.Objects;

namespace DiscordDotNet
{
    public class DiscordBanRemovedEventArgs : EventArgs
    {
        public DiscordServer Guild { get; internal set; }
        public DiscordMember MemberStub { get; internal set; }
    }
}