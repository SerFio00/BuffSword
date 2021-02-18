using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;

namespace Testspada.Buffs
{
    public class BouncyBouncy : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Bouncy!");
            Description.SetDefault("Bouncy Bouncy Bouncy");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.jumpBoost = true;
            player.jumpSpeedBoost += 10;
            player.autoJump = true;
            player.noFallDmg = true;
            Player.jumpHeight = 10;
        }
    }
}
