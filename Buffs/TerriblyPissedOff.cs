using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;

namespace Testspada.Buffs
{
    public class TerriblyPissedOff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Terribly Pissed Off");
            Description.SetDefault("You are really Angry! Significantly increases the critical hit.");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.magicCrit += 30;
            player.meleeCrit += 30;
            player.rangedCrit += 30;
            player.thrownCrit += 30;
        }
    }
}
