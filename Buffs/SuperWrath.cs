using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;

namespace Testspada.Buffs
{
    public class SuperWrath : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Super Wrath");
            Description.SetDefault("Doubles The Damage");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.allDamage *= 2;
        }
    }
}
