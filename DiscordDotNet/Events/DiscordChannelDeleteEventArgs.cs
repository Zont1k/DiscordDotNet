using DiscordDotNet.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordDotNet.Events
{
    public class DiscordChannelDeleteEventArgs : EventArgs
    {
        public DiscordChannel ChannelDeleted { get; internal set; }
    }

    public class DiscordPrivateChannelDeleteEventArgs : EventArgs
    {
        public DiscordPrivateChannel PrivateChannelDeleted { get; internal set; }
    }
}
