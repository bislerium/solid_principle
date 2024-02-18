namespace solid_principle.interface_segregation.Before
{
    public class SmartDoorbell : IElectronicDevice
    {
        // Existing methods for smart doorbell...
        public void PowerOn()
        {
            // Implementation for turning on the smart doorbell.
        }

        public void PowerOff()
        {
            // Implementation for turning off the smart doorbell.
        }

        // Problem: Forced to implement Play and Pause, which don't make sense for a doorbell.
        public void Play()
        {
            // Implementation for playing a doorbell sound (which may not make sense).
        }

        public void Pause()
        {
            // Implementation for pausing a doorbell sound (which may not make sense).
        }
    }

}
