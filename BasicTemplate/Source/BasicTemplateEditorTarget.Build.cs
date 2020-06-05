using Flax.Build;

public class BasicTemplateEditorTarget : GameEditorTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for editor
        Modules.Add("BasicTemplate");
    }
}
