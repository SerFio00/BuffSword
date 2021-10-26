using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;

namespace Testspada.Buffs
{
    public class MP5Rampage : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("MP5 RAMPAGE");
            Description.SetDefault("MP5 bless: damage slightly up");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.rangedDamage *= 2;
        }
    }
}