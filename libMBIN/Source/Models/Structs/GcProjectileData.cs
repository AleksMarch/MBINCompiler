﻿using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x3A0)]
    public class GcProjectileData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        /* 0x010 */ public GcResourceElement Model;
        /* 0x2B8 */ public GcAudioWwiseEvents FireAudioEvent;
        /* 0x2BC */ public GcAudioWwiseEvents OverheatAudioEvent;
        /* 0x2C0 */ public float Scale;
        /* 0x2C4 */ public bool isAutonomous;
        /* 0x2C8 */ public float Radius;
        /* 0x2CC */ public float Speed;
        /* 0x2D0 */ public float Gravity;
        /* 0x2D4 */ public float Life;
        /* 0x2D8 */ public float Offset;
        /* 0x2DC */ public float RagdollPush;
        /* 0x2E0 */ public int Damage;
        /* 0x2E4 */ public GcDamageType DamageType;
        /* 0x2E8 */ public int Bounces;
        /* 0x2EC */ public float BounceMaxSpeed;
        /* 0x2F0 */ public float BounceDamping;
        /* 0x2F4 */ public float BounceFinalStopTime;
        /* 0x2F8 */ public bool HitOnBounce;
        [NMS(Size = 7, Ignore = true)]
        /* 0x2F9 */ public byte[] Padding2F9;

        [NMS(Size = 0x10)]
        /* 0x300 */ public string PlayerDamage;
        /* 0x310 */ public bool UseCustomBulletData;
        /* 0x314 */ public GcProjectileLineData CustomBulletData;
        /* 0x33C */ public bool UseDamageNumberData;
        /* 0x340 */ public float DamageImpactMergeTime;
        /* 0x344 */ public float DamageImpactTimeBetweenNumbers;
        /* 0x348 */ public float DamageImpactMinDistance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x34C */ public byte[] Padding33C;
        /* 0x350 */ public Colour Colour;

        public int BehaviourFlags;
        /* 0x360 */ public Dictionary<int, string> BehaviourFlagsDict()
        {
            return new Dictionary<int, string>
            {
                {0x00, "None"},
                {0x01, "DestroyTerrain"},
                {0x02, "DestroyAsteroids"},
                {0x04, "GatherResources"},
                {0x08, "Homing"},
                {0x10, "HomingLaser"},
                {0x20, "ScareCreatures"},
                {0x40, "ExplosionForce"}
            };
        }

		public enum ClassEnum { Player, PlayerShip, Ship, Robot }
		public ClassEnum Class;

        

        [NMS(Size = 0x10)]
        /* 0x368 */ public string DefaultImpact;
        [NMS(Size = 0x10)]
        /* 0x378 */ public string CriticalImpact;
        /* 0x388 */ public List<GcProjectileImpactData> Impacts;
        [NMS(Size = 8, Ignore = true)]
        /* 0x398 */ public byte[] EndPadding;
    }
}
