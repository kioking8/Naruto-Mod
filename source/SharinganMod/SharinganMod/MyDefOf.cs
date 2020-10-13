using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;
using Verse.AI;

namespace SharinganMod
{
    public static class MyDefOf
    {
        public static Hediff Sharingan1Tomoe;
        public static Hediff Sharingan2Tomoe;
        public static Hediff Sharingan3Tomoe;
        static MyDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(MyDefOf));
        }
    }
}
