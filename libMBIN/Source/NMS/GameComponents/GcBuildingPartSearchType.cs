﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x5F076FE1D69F1B0B)]
    public class GcBuildingPartSearchType : NMSTemplate
    {
		public enum BuildPartSearchTypeEnum { Base, Freighter, AllPlayerOwned, OtherPlayerBase }
		public BuildPartSearchTypeEnum BuildPartSearchType;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        public List<GcPersistentBaseTypes> BaseSearchFilters;
        public bool IncludeOnlyOverlappingBases;
        public bool IncludeGlobalBaseObjects;
        [NMS(Size = 0x6, Ignore = true)]
        public byte[] EndPadding;
    }
}
