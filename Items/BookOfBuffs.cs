using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using terraria.audio;
using Microsoft.Xna.Framework;

namespace Testspada.Items
{
	public class BookOfBuffs : ModItem
	{
		public override void SetStaticDefaults() 
        {
            DisplayName.SetDefault("Book of Buffs");
			Tooltip.SetDefault("Shoot a mix of all the debuff possible, use with caution");
		}

		public override void SetDefaults() {
			item.damage = 380;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can hold the weapon [Important]
			item.mana = 36;
			item.rare = ItemRarityID.Purple;
			item.width = 28;
			item.height = 30;
			item.useTime = 16;
			item.UseSound = SoundID.Item13;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.shootSpeed = 14f;
			item.useAnimation = 16;
			item.shoot = ModContent.ProjectileType<Projectiles.BookOfBuffsStar>();
			item.value = Item.sellPrice(silver: 80);
			Main.PlaySound(2, (int)position.X, (int)position.Y, 28);
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<BufferSword>());
            recipe.AddIngredient(ModContent.ItemType<LuckyMP5>());
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
