namespace solid_principle.interface_segregation.After
{
    public class Television : IElectronicDevice, IVideoPlayable
    {
        // Existing methods for television...
        public void PowerOn()
        {
            // Implementation for turning on the television.
        }

        public void PowerOff()
        {
            // Implementation for turning off the television.
        }

        public void Play()
        {
            // Implementation for playing a television show.
        }

        public void Pause()
        {
            // Implementation for pausing a television show.
        }
    }
}
