using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace Testspada.Weapons
{
	public class BookOfBuffs : ModItem
	{
		public override void SetStaticDefaults() 
        {
            DisplayName.SetDefault("Lucky MP5");
			Tooltip.SetDefault("Shoot a mix of all the debuff possible, use with caution");
		}

		public override void SetDefaults() {
			item.damage = 230;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can hold the weapon [Important]
			item.mana = 16;
			item.rare = ItemRarityID.Purple;
			item.width = 28;
			item.height = 30;
			item.useTime = 16;
			item.UseSound = SoundID.Item13;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.shootSpeed = 14f;
			item.useAnimation = 16;
			item.shoot = RainbowRodBullet;
			item.value = Item.sellPrice(silver: 3);
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<BufferSword>());
            recipe.AddIngredient(ModContent.ItemType<LuckyMP5>());
			recipe.AddTile(TileID.AncientManipolator);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
