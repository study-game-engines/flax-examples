using Flax.Build;

public class GraphicsFeaturesTourTarget : GameTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for game
        Modules.Add("GraphicsFeaturesTour");
    }
}
