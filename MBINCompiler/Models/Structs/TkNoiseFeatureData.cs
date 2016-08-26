﻿namespace MBINCompiler.Models.Structs
{
    public class TkNoiseFeatureData : NMSTemplate
    {
        public bool Active;
        public int MaximumLOD;
        public bool Subtract;
        public bool Trench;
        public TkNoiseVoxelTypeEnum NoiseVoxelType;
        public int FeatureType;
        public string[] FeatureTypeValues()
        {
            return new[] { "Tube", "Blob" };
        }
        public float Width;
        public float Height;
        public int Octaves;
        public float RegionSize;
        public float Ratio;
        public float HeightVarianceAmplitude;
        public float HeightVarianceFrequency;
        public float HeightOffset;
        public TkNoiseOffsetEnum OffsetType;
        public float SmoothRadius;
        public int SeedOffset;
    }
}
