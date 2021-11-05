using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;

namespace Testspada.Buffs
{
    public class TurtleShell : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Turtle Shell");
            Description.SetDefault("Movement Speed Down and Defense increased by 100");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed *= 0.5f;
            player.statDefense += 100;
        }
    }
}