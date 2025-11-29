using NAudio.Wave;

namespace WarCardGameProject
{
    public static class MusicManager
    {
        private static WaveOutEvent output;
        private static AudioFileReader reader;

        public static bool MusicOn = true;

        // Keep the last file path and volume for restarting
        private static string lastPath = "";
        private static float lastVolume = 0.5f;

        public static void Play(string path, float volume = 0.5f)
        {
            lastPath = path;
            lastVolume = volume;

            Stop();

            reader = new AudioFileReader(path);
            reader.Volume = volume;

            output = new WaveOutEvent();
            output.Init(reader);
            output.Play();

            output.PlaybackStopped += (s, e) =>
            {
                if (!MusicOn) return;

                if (reader != null)
                {
                    reader.Position = 0;
                    output.Play();
                }
            };
        }

        public static void Stop()
        {
            try
            {
                output?.Stop();
                output?.Dispose();
                reader?.Dispose();
            }
            catch { }
        }

        public static void Toggle()
        {
            Set(!MusicOn);
        }

        public static void Set(bool on)
        {
            MusicOn = on;

            if (on)
                Resume();
            else
                Pause();
        }

        public static void Pause()
        {
            try { output?.Pause(); } catch { }
        }

        public static void Resume()
        {
            try
            {
                if (reader == null || output == null)
                {
                    // Restart track if it was disposed
                    Play(lastPath, lastVolume);
                    return;
                }

                output.Play();
            }
            catch { }
        }
    }
}
