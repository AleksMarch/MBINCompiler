﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3D75143BE008F7FF)]
    public class GcObjectPlacementComponentData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string GroupNodeName;

		public enum ActivationTypeEnum { GroupNode, Locator }
		public ActivationTypeEnum ActivationType;
        public float FractionOfNodesActive;
        public int MaxNodesActivated;
        public int MaxGroupsActivated;
        public bool UseRaycast;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding31;
    }
}
