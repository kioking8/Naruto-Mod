using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;
using Verse.AI;

namespace SharinganMod
{
    class MentalBreakWorker_Sharingan2Tomoe : MentalBreakWorker
	{
		public override bool BreakCanOccur(Pawn pawn)
		{
			return pawn.IsColonist && pawn.Spawned && base.BreakCanOccur(pawn);
		}

		public override bool TryStart(Pawn pawn, string reason, bool causedByMood)
		{

			if (pawn.health.hediffSet.HasHediff(HediffDefOf.Sharingan1Tomoe) && !pawn.health.hediffSet.HasHediff(HediffDefOf.Sharingan2Tomoe))
			{

				BodyPartRecord part = null;
				part = pawn.RaceProps.body.GetPartsWithDef(BodyPartDefOf.Eye).ElementAt(0);
				pawn.health.AddHediff(HediffDefOf.Sharingan2Tomoe, part, null, null);

				BodyPartRecord part2 = null;
				part2 = pawn.RaceProps.body.GetPartsWithDef(BodyPartDefOf.Eye).ElementAt(1);
				pawn.health.AddHediff(HediffDefOf.Sharingan2Tomoe, part2, null, null);

				base.TrySendLetter(pawn, pawn.Name + " has gained a sharingan with 2 tomoe", reason);
				return true;

			}
			else
			{
				return false;

			}
		}
	}
}
