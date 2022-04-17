using MoreMountains.NiceVibrations;

public static class HapticManager
{
    public static void SoftImpact()
    {
        MMVibrationManager.Haptic(HapticTypes.SoftImpact);
    }
    public static void HeavyImpact()
    {
        MMVibrationManager.Haptic(HapticTypes.HeavyImpact);
    }
    public static void FailImpact()
    {
        MMVibrationManager.Haptic(HapticTypes.Failure);
    }
    public static void MediumImpact()
    {
        MMVibrationManager.Haptic(HapticTypes.MediumImpact);
    }
    public static void WarningImpact()
    {
        MMVibrationManager.Haptic(HapticTypes.Warning);
    }
}
