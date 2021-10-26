using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;

namespace Testspada.Buffs
{
    public class MP5Revenge : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("MP5 REVENGE");
            Description.SetDefault("MP5 bless: the Crit chance slightly up");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.rangedCrit += 50;
        }
    }
}
