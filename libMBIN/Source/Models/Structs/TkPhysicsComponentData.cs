﻿using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x70)]
    public class TkPhysicsComponentData : NMSTemplate       // used in a global?
    {
        public TkPhysicsData Data;
        /* 0x018 */ public NMSTemplate RagdollData;
        /* 0x060 */ public TkVolumeTriggerType VolumeTriggerType;
        /* 0x064 */ public int SurfaceProperties;
        public string[] SurfacePropertiesValues()
        {
            return new[] { "None", "Glass" };
        }
        /* 0x068 */ public bool TriggerVolume;
        
        /* 0x069 */ public bool Climbable;
        /* 0x06A */ public bool IgnoreModelOwner;
        /* 0x06B */ public bool NoVehicleCollision;
        /* 0x06C */ public bool CameraInvisible;
        [NMS(Size = 3, Ignore = true)]
        /* 0x06D */ public byte[] EndPadding;
        
    }
}
