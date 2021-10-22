using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using System;
using Microsoft.Xna.Framework;

namespace Testspada.Items
{
	public class DisgustingDebuffBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Disgusting Debuff Bow");
			Tooltip.SetDefault("Shoot 2 Arrow: one random arrow and an arrow that give random debuff to the enemy");
		}

		public override void SetDefaults()
		{
			item.damage = 18;
			item.melee = false;
			item.ranged = true;
			item.width = 12;
			item.height = 24;
			item.useTime = 26;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 0.5f;
			item.value = 3500;
			item.rare = ItemRarityID.LightRed;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = ModContent.ProjectileType<Projectiles.DisgustingArrow>();
			item.shootSpeed = 7;
		}

		public override void AddRecipes()
		{
			ModRecipe recipecrimson = new ModRecipe(mod);
			recipecrimson.AddIngredient(ItemID.TendonBow);
			recipecrimson.AddIngredient(ItemID.Gel, 100);
			recipecrimson.AddIngredient(ItemID.PinkGel, 20);
			recipecrimson.AddIngredient(ItemID.Stinger, 5);
			recipecrimson.AddIngredient(ItemID.Vertebrae, 10);
			recipecrimson.AddTile(TileID.Anvils);
			recipecrimson.SetResult(this);
			recipecrimson.AddRecipe();
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			int[] Depotenziamento = { BuffID.Poisoned, BuffID.Confused, BuffID.Slow, BuffID.Frozen, BuffID.Burning, BuffID.Midas, BuffID.Slimed, BuffID.Wet, BuffID.OnFire, BuffID.Electrified, BuffID.Stoned, BuffID.WitheredArmor, BuffID.WitheredWeapon, BuffID.Frostburn, BuffID.Ichor, BuffID.CursedInferno };
			int Lunghezza = Depotenziamento.Length;
			Random rnd = new Random();
			int i = rnd.Next(Lunghezza);
			target.AddBuff(Depotenziamento[i], 10 * 60);
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 Speed = new Vector2(speedX, speedY);
			type = Projectile.NewProjectile(position, Speed, ModContent.ProjectileType<Projectiles.DisgustingArrow>(), damage, knockBack, player.whoAmI);
			return true;
		}
	}
}

