using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;

namespace Testspada.Buffs
{
    public class ManaRevenge : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Mana Revenge");
            Description.SetDefault("Mana Regeneration greatly increase (5 times)");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.manaRegen = player.manaRegen+10;
        }
    }
}
