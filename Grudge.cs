using System;
using XRL.World;

namespace XRL.World.Effects
{
    [Serializable]
    public class KobhegeGrudge : Effect
    {
        private int MinimumXp = 150;
        private string Species = "goatfolk";

        public KobhegeGrudge()
        {
            base.DisplayName = "{{r|Grudge}}";
            base.Duration = 1;
        }

        public override bool WantEvent(int ID, int cascade)
        {
            return ID == AwardingXPEvent.ID;
        }

        public override bool HandleEvent(AwardingXPEvent E)
        {
            if (E.Actor.IsPlayer() && E.Kill?.GetSpecies() == Species)
            {
                E.Minimum = MinimumXp;
            }
            return true;
        }

        public override string GetDetails()
        {
            return $"You always receive at least {MinimumXp} XP for killing {Species}.";
        }
    }
}