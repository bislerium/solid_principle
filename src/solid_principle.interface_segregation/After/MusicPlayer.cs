namespace solid_principle.interface_segregation.After
{
    public class MusicPlayer : IElectronicDevice, IAudioPlayable
    {
        // Existing methods for music player...
        public void PowerOn()
        {
            // Implementation for turning on the music player.
        }

        public void PowerOff()
        {
            // Implementation for turning off the music player.
        }

        public void Play()
        {
            // Implementation for playing a music track.
        }

        public void Pause()
        {
            // Implementation for pausing a music track.
        }
    }
}
