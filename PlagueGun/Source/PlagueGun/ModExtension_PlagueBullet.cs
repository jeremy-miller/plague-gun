using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace JM_PlagueGun
{
    public class ModExtension_PlagueBullet : DefModExtension
    {
        public float addHediffChance = 0.05f;
        public HediffDef hediffToAdd;
    }
}
