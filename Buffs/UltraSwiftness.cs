using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;

namespace Testspada.Buffs
{
    public class UltraSwiftness : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Ultra Swiftness");
            Description.SetDefault("Your Legs are more powerful now!");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.runAcceleration *= 6;
            player.moveSpeed *= 5f;
            player.noKnockback = true;
        }
    }
}
