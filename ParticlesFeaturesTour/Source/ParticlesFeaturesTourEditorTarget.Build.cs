using Flax.Build;

public class ParticlesFeaturesTourEditorTarget : GameEditorTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for editor
        Modules.Add("ParticlesFeaturesTour");
    }
}
