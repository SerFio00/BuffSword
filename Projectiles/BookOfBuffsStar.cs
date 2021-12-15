using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Terraria.Audio;
using System;

namespace Testspada.Projectiles
{
    public class BookOfBuffsStar : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Book Of Buffs Star");     //The English name of the projectile
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;    //The length of old position to be recorded
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;        //The recording mode
        }

        public override void SetDefaults()
        {
            projectile.width = 26;               //The width of projectile hitbox
            projectile.height = 26;              //The height of projectile hitbox
            projectile.aiStyle = 9;             //The ai style of the projectile, please reference the source code of Terraria
            projectile.friendly = true;         //Can the projectile deal damage to enemies?
            projectile.hostile = false;         //Can the projectile deal damage to the player?
            projectile.ranged = false;           //Is the projectile shoot by a ranged weapon?
            projectile.penetrate = 5;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
            projectile.timeLeft = 6000;          //The live time for the projectile (60 = 1 second, so 600 is 600 seconds)
            projectile.alpha = 1;             //The transparency of the projectile, 255 for completely transparent. (aiStyle 1 quickly fades the projectile in) Make sure to delete this if you aren't using an aiStyle that fades in. You'll wonder why your projectile is invisible.
            projectile.light = 3f;            //How much light emit around the projectile
            projectile.ignoreWater = true;          //Does the projectile's speed be influenced by water?
            projectile.tileCollide = true;          //Can the projectile collide with tiles?
            projectile.extraUpdates = 1;            //Set to above 0 if you want the projectile to update multiple time in a frame
            aiType = ProjectileID.UnholyTridentFriendly;           //Act exactly like default Bullet
        }

        public override void Kill(int timeLeft)
        {
            Main.PlaySound(new LegacySoundStyle(2, 28, Terraria.Audio.SoundType.Sound), (int)projectile.position.X, (int)projectile.position.Y); // Play a death sound
            Vector2 usePos = projectile.position; // Position to use for dusts
            // Declaring a constant in-line is fine as it will be optimized by the compiler
            // It is however recommended to define it outside method scope if used elswhere as well
             // They are useful to make numbers that don't change more descriptive
            const int NUM_DUSTS = 20;
            for (int i = 0; i < NUM_DUSTS; i++)
            {
                // Create a new dust
                Dust dust = Dust.NewDustDirect(usePos, projectile.width, projectile.height, 164);
                dust.position = (dust.position + projectile.Center) / 2f;
                dust.velocity *= 0.5f;
                dust.noGravity = true;
            }
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 600);
            target.AddBuff(BuffID.Electrified, 600);
            target.AddBuff(BuffID.Venom, 600);
            target.AddBuff(BuffID.CursedInferno, 600);
            target.AddBuff(BuffID.Poisoned, 600);
            target.AddBuff(BuffID.Confused, 600);
            target.AddBuff(BuffID.Slow, 600);
            target.AddBuff(BuffID.Ichor, 600);
            target.AddBuff(BuffID.Midas, 600);
            target.AddBuff(BuffID.Wet, 600);
            target.AddBuff(BuffID.ShadowFlame, 600);
        }
    }
}
