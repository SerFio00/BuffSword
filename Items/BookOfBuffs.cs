using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Terraria.Audio;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System;

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
			item.damage = 280;
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
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<BufferSword>());
            recipe.AddIngredient(ModContent.ItemType<LuckyMP5>());
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		public virtual void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
            target.AddBuff(BuffID.OnFire, 10);
            target.AddBuff(BuffID.Electrified, 10);
            target.AddBuff(BuffID.Venom, 10);
            target.AddBuff(BuffID.CursedInferno, 10);
            target.AddBuff(BuffID.Poisoned, 10);
            target.AddBuff(BuffID.Confused, 10);
            target.AddBuff(BuffID.Slow, 10);
            target.AddBuff(BuffID.Ichor, 10);
            target.AddBuff(BuffID.Midas, 10);
            target.AddBuff(BuffID.Wet, 10);
            target.AddBuff(BuffID.ShadowFlame, 10);
		}
	}
}
