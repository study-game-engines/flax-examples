using Flax.Build;

public class MaterialsFeaturesTourEditorTarget : GameEditorTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for editor
        Modules.Add("MaterialsFeaturesTour");
    }
}
