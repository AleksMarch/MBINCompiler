﻿namespace libMBIN.Models.Structs
{
    public class GcCreatureInfo : NMSTemplate
    {
        public int Age;
        public string[] AgeValues()
        {
            return new[] { "Regular", "Weird" };
        }

        [NMS(Size = 0x80)]
        public string Gender1;
        [NMS(Size = 0x80)]
        public string Gender2;
        [NMS(Size = 0x80)]
        public string Temperament;
        [NMS(Size = 0x80)]
        public string Diet;
        [NMS(Size = 0x80)]
        public string Weight1;
        [NMS(Size = 0x80)]
        public string Height1;
        [NMS(Size = 0x80)]
        public string Weight2;
        [NMS(Size = 0x80)]
        public string Height2;

        public float Weight1Float;
        public float Height1Float;
        public float Weight2Float;
        public float Height2Float;

        public GcRarity Rarity;
    }
}
