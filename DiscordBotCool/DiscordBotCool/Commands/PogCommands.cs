using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

namespace DiscordBotCool.Commands
{
    public class PogCommands : BaseCommandModule
    {

        [Command("memo")]
        [Description("Memoooo guck mal da")]

        public async Task Memo(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();
            var emoji = DiscordEmoji.FromName(ctx.Client, ":flushed:");
            await ctx.RespondAsync($"{emoji} https://www.youtube.com/watch?v=XlTYgTOo_PQ");
            
        }

        [Command("bruder")]
        [Description("All hail the people's republic of China")]
        public async Task Help(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();
            var emoji = DiscordEmoji.FromName(ctx.Client, ":flushed:");
            await ctx.RespondAsync($"{emoji} Bruder muss los");
        }

        [Command("sum")]
        [Description("Calculates the checksum of your given numbers")]
        public async Task SumOfNumbers(CommandContext ctx, [Description("Whole numbers which add to the checksum")] params int[] args)
        {
            await ctx.TriggerTypingAsync();
            var sum = args.Sum();
            await ctx.RespondAsync($"The checksum of these numbers is: {sum.ToString("#,##0")}");
        }

        [Command("ping")]
        [Description("Returns Pong and your Ping")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();
            var emoji = DiscordEmoji.FromName(ctx.Client, ":ping_pong:");
            await ctx.RespondAsync($"{emoji} Pong! {ctx.Client.Ping}ms");
        }

        [Command("random")]
        [Description("Generates a random number between the two numbers you chose")]
        public async Task Random(CommandContext ctx,[Description("Your first number")] int min,[Description("Your second number")] int max)
        {
            var rnd = new Random();
            await ctx.RespondAsync($"Your random Number is: {rnd.Next(min, max)}");
        }

        [Command("hi")]
        [Description("Mentions you and responds Hi")]
        public async Task Hi(CommandContext ctx)
        {
            await ctx.RespondAsync($"👋 Hi, {ctx.User.Mention}!");
        }

    }
}
