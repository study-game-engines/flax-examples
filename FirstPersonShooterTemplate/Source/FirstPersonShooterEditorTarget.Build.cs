using Flax.Build;

public class FirstPersonShooterEditorTarget : GameEditorTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for editor
        Modules.Add("FirstPersonShooter");
    }
}
