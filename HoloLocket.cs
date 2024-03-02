using System;
using XRL.UI;

namespace XRL.World.Parts
{
    [Serializable]
    public class KobhegeHoloLocket : IPart
    {
        public override bool WantEvent(int ID, int cascade)
        {
            return ID == GetInventoryActionsEvent.ID || ID == InventoryActionEvent.ID;
        }

        public override bool HandleEvent(GetInventoryActionsEvent E)
        {
            E.AddAction(
                Name: "Activate",
                Key: 'a',
                Display: "{{W|a}}ctivate",
                Command: "Activate"
            );
            return true;
        }

        public override bool HandleEvent(InventoryActionEvent E)
        {
            if (E.Command == "Activate")
            {
                Popup.Show("You press the recessed button on the bracelet and a small hologram of your late spouse appears in your hand. After a few moments you sigh and turn off the bracelet, but the feeling of loss lingers.");
            }
            return true;
        }
    }
}