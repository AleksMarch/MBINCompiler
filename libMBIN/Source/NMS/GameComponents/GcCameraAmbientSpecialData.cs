﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x711D55B308F4783B)]
    public class GcCameraAmbientSpecialData : NMSTemplate       // size: 0x28
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Animation;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string DroneAnimation;
        /* 0x20 */
        public int CameraOrigin;
		public enum OriginEnum { ExternalBase }
		public OriginEnum Origin;

        /* 0x24 */ public bool UseLookAt;
        /* 0x25 */ public bool AvoidTerrain;

        [NMS(Size = 0x2, Ignore = true)]
        /* 0x26 */ public byte[] EndPadding;
    }
}
