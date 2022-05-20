using Newtonsoft.Json.Linq;
using System;
using DiscordDotNet.Objects;

namespace DiscordDotNet.Events
{
    public class UnknownMessageEventArgs : EventArgs
    {
        public JObject RawJson { get; internal set; }
    }
}
