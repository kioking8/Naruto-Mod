using System;
using System.Reflection.Emit;
using RimWorld;
using Verse;
using Verse.AI;

namespace SharinganMod
{
    public class MentalBreakWorker_Sharingan1Tomoe : MentalBreakWorker
    {
		HediffDef hediffSharingan1Tomoe = DefDatabase<HediffDef>.GetNamed("Sharingan1Tomoe");
		public override bool BreakCanOccur(Pawn pawn)
		{
			return pawn.IsColonist && pawn.Spawned && base.BreakCanOccur(pawn);
		}

		public override bool TryStart(Pawn pawn, string reason, bool causedByMood)
		{
			pawn.health.AddHediff(hediffSharingan1Tomoe, null, null, null);
			base.TrySendLetter(pawn, "LetterSharingan1Get", reason);
			return true;
		}
	}
}
