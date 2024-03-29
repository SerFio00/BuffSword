using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace Testspada.Potion
{
	public class PotioIrae : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Potio Irae");
            Tooltip.SetDefault("Gives the Terribly Pissed Off buff, Ira fluit in sanguine tuo");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 26;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 15;
            item.useTime = 15;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = ItemRarityID.Purple;
            item.value = Item.buyPrice(gold: 10);
            item.buffType = ModContent.BuffType<Buffs.TerriblyPissedOff>(); //Specify an existing buff to be applied when used.
            item.buffTime = 3600; //The amount of time the buff declared in item.buffType will last in ticks. 5400 / 60 is 90, so this buff will last 90 seconds.
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RagePotion, 30);
            recipe.AddIngredient(ItemID.Deathweed, 100);
			recipe.AddIngredient(ItemID.InfernoPotion, 30);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
