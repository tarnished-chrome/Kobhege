using XRL;
using XRL.World;
using XRL.World.Effects;

[PlayerMutator]
public class KobhegePlayerMutator : IPlayerMutator
{
    public void mutate(GameObject player)
    {
        player.ApplyEffect(new KobhegeGrudge());
    }
}