using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;

namespace Testspada.Buffs
{
    public class ArmoredPersonnelCarrier : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Armored Personnel Carrier");
            Description.SetDefault("An APC has arrived: Minion limit Canceled");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.maxMinions *= 20;
        }
    }
}