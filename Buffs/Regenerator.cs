using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;

namespace Testspada.Buffs
{
    public class Regenerator : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Regenerator");
            Description.SetDefault("Life regeneration is immensely increased");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen *= 3;
        }
    }
}
