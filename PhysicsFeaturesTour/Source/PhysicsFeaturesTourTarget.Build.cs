using Flax.Build;

public class PhysicsFeaturesTourTarget : GameTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for game
        Modules.Add("PhysicsFeaturesTour");
    }
}
