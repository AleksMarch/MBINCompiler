﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x77FEDB97E0BE4867)]
    public class GcMissionConditionHasTechnology : NMSTemplate
    {
        public GcTechnologyTableEnum Technology;
    }
}
