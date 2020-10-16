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
		public override bool BreakCanOccur(Pawn pawn)
		{
			return pawn.IsColonist && pawn.Spawned && base.BreakCanOccur(pawn);
		}

		public override bool TryStart(Pawn pawn, string reason, bool causedByMood)
		{

			if (!pawn.health.hediffSet.HasHediff(HediffDefOf.Sharingan1Tomoe) && !pawn.health.hediffSet.HasHediff(HediffDefOf.Sharingan2Tomoe) && pawn.story.traits.HasTrait(TraitDefOf.Uchiha) || pawn.story.traits.HasTrait(TraitDefOf.UchihaProdigy) || pawn.story.traits.HasTrait(TraitDefOf.UchihaGenius) || pawn.story.traits.HasTrait(TraitDefOf.UchihaLegend))
            {

				BodyPartRecord part = null;
				part = pawn.RaceProps.body.GetPartsWithDef(BodyPartDefOf.Eye).ElementAt(0);
				pawn.health.AddHediff(HediffDefOf.Sharingan1Tomoe, part, null, null);

				BodyPartRecord part2 = null;
				part2 = pawn.RaceProps.body.GetPartsWithDef(BodyPartDefOf.Eye).ElementAt(1);
				pawn.health.AddHediff(HediffDefOf.Sharingan1Tomoe, part2, null, null);

				base.TrySendLetter(pawn, pawn.Name + " has gained a sharingan with 1 tomoe", reason);
				return true;

            }
            else
            {
				return false;

            }
		}
	}
}
