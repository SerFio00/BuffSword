using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;

namespace Testspada.Items
{
	public class BuffSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("BuffSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("critical attacks trigger a random buff ");
		}

		public override void SetDefaults() 
		{
			item.damage = 16;
			item.crit = 5;
			item.melee = true;
			item.width = 150;
			item.height = 150;
			item.useTime = 25;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipeplatinum = new ModRecipe(mod);
			recipeplatinum.AddIngredient(ItemID.PlatinumBroadsword, 1);
			recipeplatinum.AddIngredient(ItemID.Daybloom, 5);
			recipeplatinum.AddIngredient(ItemID.Moonglow, 5);
			recipeplatinum.AddIngredient(ItemID.Blinkroot, 5);
			recipeplatinum.AddIngredient(ItemID.Deathweed, 5);
			recipeplatinum.AddIngredient(ItemID.Waterleaf, 5);
			recipeplatinum.AddIngredient(ItemID.Fireblossom, 5);
			recipeplatinum.AddTile(TileID.AlchemyTable);
			recipeplatinum.AddTile(TileID.Bottles);
			recipeplatinum.SetResult(this);
			recipeplatinum.AddRecipe();

			ModRecipe recipegold = new ModRecipe(mod);
			recipegold.AddIngredient(ItemID.GoldBroadsword, 1);
			recipegold.AddIngredient(ItemID.Daybloom, 5);
			recipegold.AddIngredient(ItemID.Moonglow, 5);
			recipegold.AddIngredient(ItemID.Blinkroot, 5);
			recipegold.AddIngredient(ItemID.Deathweed, 5);
			recipegold.AddIngredient(ItemID.Waterleaf, 5);
			recipegold.AddIngredient(ItemID.Fireblossom, 5);
			recipegold.AddTile(TileID.AlchemyTable);
			recipegold.AddTile(TileID.Bottles);
			recipegold.SetResult(this);
			recipegold.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
			int[] Potenziamento = { BuffID.AmmoReservation, BuffID.Archery, BuffID.Battle, BuffID.Builder, BuffID.Endurance, BuffID.Flipper, BuffID.Gills, BuffID.Gravitation, BuffID.Heartreach, BuffID.Hunter, BuffID.Inferno, BuffID.Invisibility, BuffID.Ironskin, BuffID.Lifeforce, BuffID.MagicPower, BuffID.ManaRegeneration, BuffID.Mining, BuffID.NightOwl, BuffID.ObsidianSkin, BuffID.Panic, BuffID.Rage, BuffID.RapidHealing, BuffID.Regeneration, BuffID.Shine, BuffID.Sonar, BuffID.Spelunker, BuffID.Swiftness, BuffID.Thorns, BuffID.Titan, BuffID.Warmth, BuffID.WaterWalking, BuffID.WellFed, BuffID.Wrath };
            int Lunghezza = Potenziamento.Length;
			Random rnd = new Random();
            if (crit)
            {
				int i = rnd.Next(Lunghezza);
				player.AddBuff(Potenziamento[i], 30 * 60);
            }

        }
	}
}