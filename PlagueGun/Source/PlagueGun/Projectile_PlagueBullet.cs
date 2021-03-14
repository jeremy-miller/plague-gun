using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace JM_PlagueGun
{
    public class Projectile_PlagueBullet : Bullet
    {
        public ModExtension_PlagueBullet Props => def.GetModExtension<ModExtension_PlagueBullet>();

        protected override void Impact(Thing hitThing)
        {
            base.Impact(hitThing);
            if (Props != null && hitThing != null && hitThing is Pawn hitPawn)
            {
                float rand = Rand.Value;
                if (rand <= Props.addHediffChance)
                {
                    Messages.Message("JM_PlagueBullet_SuccessMessage".Translate(this.launcher.Label, hitPawn.Label), MessageTypeDefOf.NeutralEvent);
                    Hediff plagueOnPawn = hitPawn.health?.hediffSet?.GetFirstHediffOfDef(Props.hediffToAdd);
                    float randomSeverity = Rand.Range(0.15f, 0.30f);
                    if (plagueOnPawn != null)
                    {
                        plagueOnPawn.Severity += randomSeverity;
                    }
                    else
                    {
                        Hediff hediff = HediffMaker.MakeHediff(Props.hediffToAdd, hitPawn);
                        hediff.Severity = randomSeverity;
                        hitPawn.health.AddHediff(hediff);
                    }
                }
                else
                {
                    MoteMaker.ThrowText(hitThing.PositionHeld.ToVector3(), hitThing.MapHeld, "JM_PlagueBullet_FailureMote".Translate(Props.addHediffChance), 12f);
                }
            }
        }
    }
}
