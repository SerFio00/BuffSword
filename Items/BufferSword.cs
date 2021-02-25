using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;

namespace Testspada.Items
{
	public class BufferSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("critical attacks trigger a special and random buff");
		}

		public override void SetDefaults()
		{
			item.damage = 186;
			item.crit = 20;
			item.melee = true;
			item.width = 150;
			item.height = 150;
			item.scale = 2.75f;
			item.useTime = 45;
			item.useAnimation = 35;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 30000;
			item.rare = ItemRarityID.Cyan;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipetitanium = new ModRecipe(mod);
			recipetitanium.AddIngredient(ModContent.ItemType<BuffSword>());
			recipetitanium.AddIngredient(ItemID.TitaniumSword);
			recipetitanium.AddIngredient(ItemID.CrystalShard, 20);
			recipetitanium.AddIngredient(ItemID.SpellTome);
			recipetitanium.AddTile(TileID.CrystalBall);
			recipetitanium.SetResult(this);
			recipetitanium.AddRecipe();

			ModRecipe recipeadamantite = new ModRecipe(mod);
			recipeadamantite.AddIngredient(ModContent.ItemType<BuffSword>());
			recipeadamantite.AddIngredient(ItemID.AdamantiteSword);
			recipeadamantite.AddIngredient(ItemID.CrystalShard, 20);
			recipeadamantite.AddIngredient(ItemID.SpellTome);
			recipeadamantite.AddTile(TileID.CrystalBall);
			recipeadamantite.SetResult(this);
			recipeadamantite.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			//mettere pi� buffs personalizzati e potenziati
			int[] Potenziamento = { ModContent.BuffType<Buffs.SuperWrath>(), ModContent.BuffType<Buffs.TerriblyPissedOff>(), ModContent.BuffType<Buffs.Fortification>(), ModContent.BuffType<Buffs.BouncyBouncy>(), ModContent.BuffType<Buffs.UltraSwiftness>(), ModContent.BuffType<Buffs.ManaRevenge>(), ModContent.BuffType<Buffs.MageBlessing>(), ModContent.BuffType<Buffs.Regenerator>(), ModContent.BuffType<Buffs.MinionRampage>(), ModContent.BuffType<Buffs.TurretMadness>(), ModContent.BuffType<Buffs.ArmoredPersonnelCarrier>() };
			int Lunghezza = Potenziamento.Length;
			Random rnd = new Random();
			if (crit)
			{
				int i = rnd.Next(Lunghezza);
				player.AddBuff(Potenziamento[i], 20 * 60);
			}
		}
	}
}