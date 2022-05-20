using Newtonsoft.Json.Linq;
using System;
using DiscordDotNet.Objects;
namespace DiscordDotNet
{
    public class DiscordGuildRoleDeleteEventArgs : EventArgs
    {
        public DiscordRole DeletedRole { get; internal set; }
        public DiscordServer Guild { get; internal set; }
        public JObject RawJson { get; internal set; }
    }
}