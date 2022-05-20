using Newtonsoft.Json.Linq;
using System;
using DiscordDotNet.Objects;
namespace DiscordDotNet
{
    public class DiscordGuildMemberUpdateEventArgs : EventArgs
    {
        public DiscordMember MemberUpdate { get; internal set; }
        public DiscordServer ServerUpdated { get; internal set; }
        public JObject RawJson { get; internal set; }
    }
}