﻿using RoR2;
using UnityEngine;
using EnforcerPlugin;
using EntityStates.Enforcer.NeutralSpecial;

namespace EntityStates.Enforcer {
    public class SuperShotgun : RiotShotgun
    {
        public new float damageCoefficient = EnforcerModPlugin.superDamage.Value;
        public new float procCoefficient = 0.75f;
        public new float beefDurationNoShield = 0.15f;
        public new float beefDurationShield { 
            get {
                return Mathf.Max(EnforcerModPlugin.superBeef.Value, 0.2f); //fuck you lol
            } 
        }
        public static float bulletForce = 100f;
        public static int bulletCount = 15;
        public new float bulletSpread = EnforcerModPlugin.superSpread.Value;// 21f;
        public new float baseDuration = EnforcerModPlugin.superDuration.Value;// 2f;
        public new float baseShieldDuration;// = 1.5f;

        private bool droppedShell;

        public override void OnEnter() {

            baseShieldDuration = baseDuration * 0.75f;

            //if (EnforcerModPlugin.soup) {
            //    beefDurationNoShield = 0;
            //    beefDurationShield = 0.25f;
            //    damageCoefficient = 0.8f;
            //    bulletSpread = 18f;
            //    baseDuration = 1.5f;
            //    baseShieldDuration = 1.3f;
            //}
            base.OnEnter();
            this.droppedShell = false;

            if (base.HasBuff(EnforcerPlugin.Modules.Buffs.protectAndServeBuff) || base.HasBuff(EnforcerPlugin.Modules.Buffs.energyShieldBuff))
            {
                this.duration = this.baseShieldDuration / this.attackSpeedStat;
                this.attackStopDuration = Mathf.Max(this.beefDurationShield, 0.2f) / this.attackSpeedStat;

                base.PlayAnimation("Gesture, Override", "ShieldFireShotgun", "FireShotgun.playbackRate", this.duration);
            }
            else
            {
                this.duration = this.baseDuration / this.attackSpeedStat;
                this.attackStopDuration = this.beefDurationNoShield / this.attackSpeedStat;

                base.PlayAnimation("Gesture, Override", "FireShotgun", "FireShotgun.playbackRate", this.duration);
            }

            this.fireDuration = 0.05f * this.duration;
        }

        public override void FixedUpdate()
        {
            if (base.fixedAge >= 0.55f * this.duration && !this.droppedShell)
            {
                this.droppedShell = true;

                var poopy = base.GetComponent<EnforcerWeaponComponent>();
                poopy.DropShell(-base.GetModelBaseTransform().transform.right * -Random.Range(6, 16));
                poopy.DropShell(-base.GetModelBaseTransform().transform.right * -Random.Range(6, 16));
                //if (!this.isStormtrooper && !this.isEngi)
            }

            base.FixedUpdate();
        }

        public override void FireBullet()
        {
            if (!this.hasFired)
            {
                this.hasFired = true;

                this.muzzleString = "Muzzle";

                string soundString = "";

                bool isCrit = base.RollCrit();

                soundString = !isCrit ? EnforcerPlugin.Sounds.FireSuperShotgun : EnforcerPlugin.Sounds.FireSuperShotgunCrit;

                if (EnforcerPlugin.EnforcerModPlugin.classicShotgun.Value) soundString = EnforcerPlugin.Sounds.FireClassicShotgun;

                //if (base.characterBody.skinIndex == EnforcerPlugin.EnforcerPlugin.doomGuyIndex) soundString = EnforcerPlugin.Sounds.FireSuperShotgunDOOM;
                //if (this.isStormtrooper) soundString = EnforcerPlugin.Sounds.FireBlasterShotgun;
                //if (this.isEngi) soundString = EnforcerPlugin.Sounds.FireBungusSSG;

                Util.PlayAttackSpeedSound(soundString, base.gameObject, this.attackSpeedStat);

                float recoilAmplitude = RiotShotgun.bulletRecoil;

                if (base.HasBuff(EnforcerPlugin.Modules.Buffs.protectAndServeBuff) || base.HasBuff(EnforcerPlugin.Modules.Buffs.energyShieldBuff)) recoilAmplitude = RiotShotgun.shieldedBulletRecoil;

                base.AddRecoil(-0.4f * recoilAmplitude, -0.8f * recoilAmplitude, -0.3f * recoilAmplitude, 0.3f * recoilAmplitude);
                base.characterBody.AddSpreadBloom(4f);
                EffectManager.SimpleMuzzleFlash(Commando.CommandoWeapon.FireBarrage.effectPrefab, base.gameObject, this.muzzleString, false);

                if (base.isAuthority)
                {
                    float damage = this.damageCoefficient * this.damageStat;

                    GameObject tracerEffect = EnforcerPlugin.EnforcerModPlugin.bulletTracerSSG;

                    //if (this.isStormtrooper) tracerEffect = EnforcerPlugin.EnforcerPlugin.laserTracer;
                    //if (this.isEngi) tracerEffect = EnforcerPlugin.EnforcerPlugin.bungusTracer;

                    Ray aimRay = base.GetAimRay();

                    BulletAttack bulletAttack = new BulletAttack {
                        aimVector = aimRay.direction,
                        origin = aimRay.origin,
                        damage = damage,
                        damageColorIndex = DamageColorIndex.Default,
                        damageType = DamageType.Generic,
                        falloffModel = BulletAttack.FalloffModel.DefaultBullet,
                        maxDistance = 156,
                        force = SuperShotgun.bulletForce,
                        hitMask = LayerIndex.CommonMasks.bullet,
                        //minSpread = 0,
                        //maxSpread = this.bulletSpread,
                        //bulletCount = (uint)this.projectileCount,
                        isCrit = isCrit,
                        owner = base.gameObject,
                        muzzleName = muzzleString,
                        smartCollision = false,
                        procChainMask = default(ProcChainMask),
                        procCoefficient = this.procCoefficient,
                        radius = 0.4f,
                        sniper = false,
                        stopperMask = LayerIndex.CommonMasks.bullet,
                        weapon = null,
                        tracerEffectPrefab = tracerEffect,
                        spreadPitchScale = 1f,  //old: 21 spread 0.3f
                        spreadYawScale = 1f,    //old: 21 spread 0.7f
                        queryTriggerInteraction = QueryTriggerInteraction.UseGlobal,
                        hitEffectPrefab = Commando.CommandoWeapon.FireShotgun.hitEffectPrefab,//ClayBruiser.Weapon.MinigunFire.bulletHitEffectPrefab,
                        HitEffectNormal = ClayBruiser.Weapon.MinigunFire.bulletHitEffectNormal
                    };

                    //if (EnforcerModPlugin.soup) {

                    //    bulletAttack.minSpread = 0;
                    //    bulletAttack.maxSpread = this.bulletSpread;
                    //    bulletAttack.bulletCount = (uint)this.bulletCount;
                    //    bulletAttack.falloffModel = BulletAttack.FalloffModel.Buckshot;

                    //    bulletAttack.Fire();
                    //    return;
                    //}

                    float spread = this.bulletSpread;

                    int bullets = SuperShotgun.bulletCount;

                    bullets -= 1;
                    bulletAttack.bulletCount = 1;
                    bulletAttack.minSpread = 0f;
                    bulletAttack.maxSpread = 0f;
                    bulletAttack.Fire();

                    bullets -= 7;
                    bulletAttack.bulletCount = 7;
                    bulletAttack.minSpread = 0f;
                    bulletAttack.maxSpread = this.bulletSpread;
                    bulletAttack.Fire();

                    if (bullets > 0)
                    {
                        bulletAttack.spreadPitchScale = 1f;
                        bulletAttack.spreadYawScale = 2.3f;
                        bulletAttack.minSpread = this.bulletSpread / bulletAttack.spreadYawScale;
                        bulletAttack.maxSpread = this.bulletSpread;
                        bulletAttack.Fire();
                    }

                    /*bulletAttack.minSpread = 0;
                    bulletAttack.maxSpread = spread * 0.25f;// RAD2;
                    bulletAttack.bulletCount = (uint)Mathf.CeilToInt((float)bulletCount / 4f);
                    bulletAttack.Fire();

                    bulletAttack.minSpread = spread * 0.25f;// RAD2;
                    bulletAttack.maxSpread = spread  * 0.5f;
                    bulletAttack.bulletCount = (uint)Mathf.FloorToInt((float)bulletCount / 4f);
                    bulletAttack.Fire();

                    bulletAttack.minSpread = spread * 0.5f;// RAD2;
                    bulletAttack.maxSpread = spread * 0.75f;
                    bulletAttack.bulletCount = (uint)Mathf.FloorToInt((float)bulletCount / 4f);
                    bulletAttack.Fire();

                    bulletAttack.minSpread = spread  * 0.75f;// RAD2;
                    bulletAttack.maxSpread = spread;
                    bulletAttack.bulletCount = (uint)Mathf.FloorToInt((float)bulletCount / 4f);
                    bulletAttack.Fire();*/
                }
            }
        }

        public virtual void PlayGunAnim(string animString)
        {
            if (this.GetModelChildLocator().FindChild("SuperShotgunModel"))
            {
                Animator anim = this.GetModelChildLocator().FindChild("SuperShotgunModel").GetComponent<Animator>();
                anim.SetFloat("SuperShottyFire.playbackRate", this.attackSpeedStat);
                anim.SetTrigger(animString);
            }
        }
    }
}