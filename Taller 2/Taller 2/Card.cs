using System;
using System.Collections.Generic;
using System.Text;


namespace Taller_2
{
    public enum Affinity
    {
        Knight,
        Mage,
        Undead,
        All
    }

    public enum TargetAtribute
    {
        AP,
        RP,
        ALL
    }

    public enum EffectType
    {
        ReduceAP,
        ReduceRP,
        ReduceAll,
        DestroyEquip,
        RestoreRP
    }

    public enum Rarety
    {
        Common,
        Rare,
        SuperRare,
        UltraRare,
    }
    public abstract class Card
    {
        public string name;
        public int cP;
        public Random rnd = new Random();
    }
}
