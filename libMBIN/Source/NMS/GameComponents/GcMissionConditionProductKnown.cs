﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xEEC8B4F0162029E5, Broken = true)]
    public class GcMissionConditionProductKnown : NMSTemplate
    {
        public GcProductTableEnum Product;
    }
}
