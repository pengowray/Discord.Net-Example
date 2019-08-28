using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace Example.Modules
{
    public class RoarModule : ModuleBase<SocketCommandContext>
    {
        [Command("roar"), Alias("rwaor")]
        [Summary("ROAR")]
        public Task Roar()
            => ReplyAsync("Rwoar!");

    }
}
