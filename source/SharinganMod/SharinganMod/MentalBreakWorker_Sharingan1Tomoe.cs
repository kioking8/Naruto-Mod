using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
			BodyPartRecord part = null;
			part = pawn.RaceProps.body.GetPartsWithDef(BodyPartDefOf.Eye).ElementAt(0);
			pawn.health.AddHediff(hediffSharingan1Tomoe, part, null, null);

			BodyPartRecord part2 = null;
			part2 = pawn.RaceProps.body.GetPartsWithDef(BodyPartDefOf.Eye).ElementAt(1);
			pawn.health.AddHediff(hediffSharingan1Tomoe, part2, null, null);

			base.TrySendLetter(pawn, "LetterSharingan1Get", reason);
			return true;
		}
	}
}
