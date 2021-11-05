using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace Testspada.Potion
{
	public class Munitio : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Potio Temporaria Munitio ");
            Tooltip.SetDefault("Gives the Fortification buffs, Ironskin? tsk, DIAMOND SKIN.");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 26;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 15;
            item.useTime = 15;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = ItemRarityID.Rainbow;
            item.value = Item.buyPrice(gold: 10);
            item.buffType = ModContent.BuffType<Fortification>(); //Specify an existing buff to be applied when used.
            item.buffTime = 5400; //The amount of time the buff declared in item.buffType will last in ticks. 5400 / 60 is 90, so this buff will last 90 seconds.
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronskinPotion, 30);
            recipe.AddIngredient(ItemID.HolyWater, 100);
			recipe.AddIngredient(ItemID.SpellTome);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
