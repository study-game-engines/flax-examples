using Flax.Build;

public class FirstPersonShooterTarget : GameTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for game
        Modules.Add("FirstPersonShooter");
    }
}
