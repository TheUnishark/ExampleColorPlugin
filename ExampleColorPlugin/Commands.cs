using BrokeProtocol.API;
using BrokeProtocol.Entities;
using ColorSystem;
using System;

namespace ExampleColorPlugin
{
    internal class Commands : IScript
    {
        public Commands()
        {
            // Commands with "ecp.color" permission to change player's current vehicle colors
            CommandHandler.RegisterCommand("color1", new Action<ShPlayer, byte, byte, byte>(Color1), null, "color");
            CommandHandler.RegisterCommand("color2", new Action<ShPlayer, byte, byte, byte>(Color2), null, "color");
        }

        // Color commands takes 3 bytes [0-255] arguments for red, green, and blue
        private void Color1(ShPlayer player, byte red, byte green, byte blue)
        {
            // Check if the player is driving a vehicle
            if (!player.IsMountController || !(player.curMount is ShTransport transport))
            {
                // Send a message to the player if they are not driving a vehicle and do not execute the command
                player.svPlayer.SendGameMessage("&4You must be driving a vehicle to use this command!");
                return;
            }

            // Set primary color of the player's vehicle
            transport.SetColor1(red, green, blue);
            // Send a message to the player with the new primary color
            player.svPlayer.SendGameMessage($"&aColor 1 set to <color={Utils.RGB2HEX(red, green, blue)}>{red}, {green}, {blue}</color>");
        }

        private void Color2(ShPlayer player, byte red, byte green, byte blue)
        {
            if (!player.IsMountController || !(player.curMount is ShTransport transport))
            {
                player.svPlayer.SendGameMessage("&4You must be driving a vehicle to use this command!");
                return;
            }

            // Set secondary color of the player's vehicle
            transport.SetColor2(red, green, blue);
            // Send a message to the player with the new secondary color
            player.svPlayer.SendGameMessage($"&aColor 2 set to <color={Utils.RGB2HEX(red, green, blue)}>{red}, {green}, {blue}</color>");
        }
    }
}
