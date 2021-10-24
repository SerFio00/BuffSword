using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Testspada.Items
{
	public class LuckyMP5 : ModItem
	{

        public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("Lucky MP5");
			Tooltip.SetDefault("Yeah, i know, it isn't a mp5, but it has high critical chance and critical damage");
		}

		public override void SetDefaults() 
		{
			item.damage = 10;
            Item.crit = 40;
			item.ranged = true;
            Item.melee = false;
			item.width = 40;
			item.height = 30;
			item.useTime = 8;
			item.useAnimation = 8;
			item.shootSpeed = 8;
            item.useStyle = 5;
            item.knockBack = 4;
			item.value = 50000;
			item.rare = ItemRarityID.Lightred;
            item.UseSound = SoundID.Item31;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Bullet;
			item.shoot = ProjectileID.Bullet;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipecorruption.AddIngredient(itemID.ironbar, 8);
            recipecorruption.anyIronBar = true;
			recipecorruption.AddIngredient(ItemID.Bone, 10);
			recipecorruption.AddIngredient(ModContent.ItemType<CorruptedDebuffBow>());
			recipecorruption.AddIngredient(ItemID.ShadowScale, 5);
			recipecorruption.AddTile(TileID.HellForge);
			recipecorruption.SetResult(this);
			recipecorruption.AddRecipe();

			recipe = new ModRecipe(mod);
			recipecrimson.AddIngredient(itemID.ironbar, 8);
            recipecrimson.anyIronBar = true;
			recipecrimson.AddIngredient(ItemID.Bone, 10);
			recipecrimson.AddIngredient(ModContent.ItemType<DisgustingDebuffBow>());
			recipecrimson.AddIngredient(ItemID.TissueSample, 5);
			recipecrimson.AddTile(TileID.HellForge);
			recipecrimson.SetResult(this);
			recipecrimson.AddRecipe();
		}
    }
}