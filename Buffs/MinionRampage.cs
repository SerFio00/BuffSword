using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;

namespace Testspada.Buffs
{
    public class MinionRampage : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Minion Rampage");
            Description.SetDefault("Oh, your minions are so Angry...");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.minionDamage *= 3;
            player.minionKB *= 2;
        }
    }
}