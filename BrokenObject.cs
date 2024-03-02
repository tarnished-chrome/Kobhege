using System;
using XRL.World.Effects;

namespace XRL.World.Parts
{
    [Serializable]
    public class KobhegeBrokenObject : IPart
    {
        public override void Register(GameObject obj)
        {
            obj.ApplyEffect(new Broken());
            obj.RemovePart(this);
        }
    }
}