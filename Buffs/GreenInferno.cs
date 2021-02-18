using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;

namespace Testspada.Buffs
{
    public class GreenInferno : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Green Inferno");
            Description.SetDefault("Ignites with cursed flame nearby enemies");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.AddBuff(BuffID.Inferno, 15);
        }

        public override bool ReApply(NPC npc, int time, int buffIndex)
        {
            npc.AddBuff(BuffID.CursedInferno, 7);
            return true;
        }
    }
}