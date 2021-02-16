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
			item.damage = 20;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 30;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddIngredient(ItemID.Wood, 1);
			recipe.anyWood = true;
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
			int[] Potenziamento = { BuffID.AmmoReservation, BuffID.Archery, BuffID.Battle, BuffID.Builder };
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