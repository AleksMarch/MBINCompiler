﻿namespace MBINCompiler.Models.Structs
{
    public class GcScanData : NMSTemplate       // possibly used in a global
    {
	  /* 0x000 */ public int ScanType;
	  public string[] ScanTypeValues()
        {
            return new[] { "Tool", "Beacon", "RadioTower", "Observatory", "DistressSignal", "Waypoint", "Ship", "DebugPlanet", "DebugSpace" };
        }
	  /* 0x004 */ public float PulseRange;          // 41200000h
	  /* 0x008 */ public float PulseTime;           // 41200000h
	  /* 0x00C */ public bool PlayAudioOnMarkers;   // 1
	  /* 0x010 */ public float ChargeTime;          // 40800000h
    }
}
