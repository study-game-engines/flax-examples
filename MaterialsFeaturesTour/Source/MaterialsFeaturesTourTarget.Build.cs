using Flax.Build;

public class MaterialsFeaturesTourTarget : GameTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for game
        Modules.Add("MaterialsFeaturesTour");
    }
}
