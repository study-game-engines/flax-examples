using Flax.Build;

public class ParticlesFeaturesTourTarget : GameTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for game
        Modules.Add("ParticlesFeaturesTour");
    }
}
