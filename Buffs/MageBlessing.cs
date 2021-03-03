using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;

namespace Testspada.Buffs
{
    public class MageBlessing : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Mage Blessing");
            Description.SetDefault("a Mage bless you: Mana usage -10");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.manaCost -= 10;
        }
    }
}
