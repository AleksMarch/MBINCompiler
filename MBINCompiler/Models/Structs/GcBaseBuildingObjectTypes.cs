﻿using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcBaseBuildingObjectTypes : NMSTemplate
    {
        public int BaseBuildingObjectType;
        public string[] BaseBuildingObjectTypeValues()
        {
            return new[] { "Building", "BuildingFoundation", "BuildingDecoration", "Decoration", "Foundation" };
        }
    }
}
