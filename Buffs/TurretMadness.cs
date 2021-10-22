using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;

namespace Testspada.Buffs
{
    public class TurretMadness : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Turret Madness");
            Description.SetDefault("The Tower Defense Mania pervades you: Turret limit canceled");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.maxTurrets *= 50;
        }
    }
}