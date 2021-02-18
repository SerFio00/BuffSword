using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;

namespace Testspada.Buffs
{
    public class Fortification : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Fortification");
            Description.SetDefault("Doubles your Defense");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense *= 2;
        }
    }
}
