using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;
using Microsoft.Xna.Framework;

namespace Testspada.Items
{
	public class BuffSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("BuffSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Critical attacks trigger a random buff ");
		}

		public override void SetDefaults() 
		{
			item.damage = 34;
			item.crit = 10;
			item.melee = true;
			item.width = 50;
			item.height = 50;
			item.useTime = 30;
			item.scale = 1.50f;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 4;
			item.value = 20000;
			item.rare = ItemRarityID.Pink;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<Projectiles.BuffSwordSpear>();
			item.shootSpeed = 10f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipeplatinumb = new ModRecipe(mod);
			recipeplatinumb.AddIngredient(ItemID.PlatinumBroadsword, 1);
			recipeplatinumb.AddIngredient(ItemID.Daybloom, 5);
			recipeplatinumb.AddIngredient(ItemID.Moonglow, 5);
			recipeplatinumb.AddIngredient(ItemID.Blinkroot, 5);
			recipeplatinumb.AddIngredient(ItemID.Deathweed, 5);
			recipeplatinumb.AddIngredient(ItemID.Waterleaf, 5);
			recipeplatinumb.AddIngredient(ItemID.Fireblossom, 5);
			recipeplatinumb.AddIngredient(ItemID.Shiverthorn, 5);
			recipeplatinumb.AddTile(TileID.Bottles);
			recipeplatinumb.SetResult(this);
			recipeplatinumb.AddRecipe();

			ModRecipe recipegoldb = new ModRecipe(mod);
			recipegoldb.AddIngredient(ItemID.GoldBroadsword, 1);
			recipegoldb.AddIngredient(ItemID.Daybloom, 5);
			recipegoldb.AddIngredient(ItemID.Moonglow, 5);
			recipegoldb.AddIngredient(ItemID.Blinkroot, 5);
			recipegoldb.AddIngredient(ItemID.Deathweed, 5);
			recipegoldb.AddIngredient(ItemID.Waterleaf, 5);
			recipegoldb.AddIngredient(ItemID.Fireblossom, 5);
			recipegoldb.AddIngredient(ItemID.Shiverthorn, 5);
			recipegoldb.AddTile(TileID.Bottles);
			recipegoldb.SetResult(this);
			recipegoldb.AddRecipe();

			ModRecipe recipeplatinuma = new ModRecipe(mod);
			recipeplatinuma.AddIngredient(ItemID.PlatinumBroadsword, 1);
			recipeplatinuma.AddIngredient(ItemID.Daybloom, 5);
			recipeplatinuma.AddIngredient(ItemID.Moonglow, 5);
			recipeplatinuma.AddIngredient(ItemID.Blinkroot, 5);
			recipeplatinuma.AddIngredient(ItemID.Deathweed, 5);
			recipeplatinuma.AddIngredient(ItemID.Waterleaf, 5);
			recipeplatinuma.AddIngredient(ItemID.Fireblossom, 5);
			recipeplatinuma.AddIngredient(ItemID.Shiverthorn, 5);
			recipeplatinuma.AddTile(TileID.AlchemyTable);
			recipeplatinuma.SetResult(this);
			recipeplatinuma.AddRecipe();

			ModRecipe recipegolda = new ModRecipe(mod);
			recipegolda.AddIngredient(ItemID.GoldBroadsword, 1);
			recipegolda.AddIngredient(ItemID.Daybloom, 5);
			recipegolda.AddIngredient(ItemID.Moonglow, 5);
			recipegolda.AddIngredient(ItemID.Blinkroot, 5);
			recipegolda.AddIngredient(ItemID.Deathweed, 5);
			recipegolda.AddIngredient(ItemID.Waterleaf, 5);
			recipegolda.AddIngredient(ItemID.Fireblossom, 5);
			recipegolda.AddIngredient(ItemID.Shiverthorn, 5);
			recipegolda.AddTile(TileID.AlchemyTable);
			recipegolda.SetResult(this);
			recipegolda.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
			int[] Potenziamento = { BuffID.AmmoReservation, BuffID.Archery, BuffID.Battle, BuffID.Builder, BuffID.Endurance, BuffID.Flipper, BuffID.Gills, BuffID.Gravitation, BuffID.Heartreach, BuffID.Hunter, BuffID.Inferno, BuffID.Invisibility, BuffID.Ironskin, BuffID.Lifeforce, BuffID.MagicPower, BuffID.ManaRegeneration, BuffID.Mining, BuffID.NightOwl, BuffID.ObsidianSkin, BuffID.Panic, BuffID.Rage, BuffID.RapidHealing, BuffID.Regeneration, BuffID.Shine, BuffID.Sonar, BuffID.Spelunker, BuffID.Swiftness, BuffID.Thorns, BuffID.Titan, BuffID.Warmth, BuffID.WaterWalking, BuffID.WellFed, BuffID.Wrath, BuffID.Summoning };
            int Lunghezza = Potenziamento.Length;
			Random rnd = new Random();
            if (crit)
            {
				int i = rnd.Next(Lunghezza);
				player.AddBuff(Potenziamento[i], 40 * 60);
            }
		}
	}
}