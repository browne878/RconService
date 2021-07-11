namespace Rcon.Services.Commands.Choices.CommandOptions
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DSharpPlus.Entities;
    using DSharpPlus.SlashCommands;

    public class PermissionsOptions : IChoiceProvider
    {
        public async Task<IEnumerable<DiscordApplicationCommandOptionChoice>> Provider()
        {
            return new[]
                   {
                       new DiscordApplicationCommandOptionChoice("Add Player to a Group", "Permissions.Add"),
                       new DiscordApplicationCommandOptionChoice("Remove Player from a Group", "Permissions.Remove"),
                       new DiscordApplicationCommandOptionChoice("Add Player to a Timed Group", "Permissions.AddTimed"),
                       new DiscordApplicationCommandOptionChoice("Remove Player from a Timed Group", "Permissions.RemoveTimed"),
                       new DiscordApplicationCommandOptionChoice("List a Players Groups", "Permissions.PlayerGroups"),
                       new DiscordApplicationCommandOptionChoice("Adds Tribe to a Group", "Permissions.AddTribe"),
                       new DiscordApplicationCommandOptionChoice("Remove Tribe from a Group", "Permissions.RemoveTribe"),
                       new DiscordApplicationCommandOptionChoice("Add Tribe to a Timed Group", "Permissions.AddTribeTimed"),
                       new DiscordApplicationCommandOptionChoice("Remove Tribe from a Timed Group", "Permissions.RemoveTribeTimed"),
                       new DiscordApplicationCommandOptionChoice("List a Tribe's Groups", "Permissions.TribeGroups"),
                       new DiscordApplicationCommandOptionChoice("Adds a Group", "Permissions.AddGroup"),
                       new DiscordApplicationCommandOptionChoice("Removes a Group", "Permissions.RemoveGroup"),
                       new DiscordApplicationCommandOptionChoice("Gives a Permission to a Group", "Permissions.Grant"),
                       new DiscordApplicationCommandOptionChoice("Removes a Permission from a Group", "Permissions.Revoke"),
                       new DiscordApplicationCommandOptionChoice("List the Permissions for a Group", "Permissions.GroupPermissions"),
                       new DiscordApplicationCommandOptionChoice("List the Groups", "Permissions.ListGroups")
                   };
        }
    }
}
