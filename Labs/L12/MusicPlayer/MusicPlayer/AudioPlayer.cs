using NAudio.Wave;
using System.IO;

namespace MusicPlayer
{
    public class AudioPlayer
    {
        private WaveOutEvent output;
        private Mp3FileReader reader;

        public void Play(byte[] data)
        {
            var ms = new MemoryStream(data);
            reader = new Mp3FileReader(ms);

            output = new WaveOutEvent();
            output.Init(reader);
            output.Play();
        }

        public void Resume()
        {
            output?.Play();
        }

        public void Pause()
        {
            output?.Pause();
        }

        public void Stop()
        {
            output?.Stop();
            reader?.Dispose();
            reader = null;
            output = null;
        }

        public void SetVolume(float volume)
        {
            if (output != null)
                output.Volume = volume;
        }

        public double GetTotalSeconds()
        {
            return reader?.TotalTime.TotalSeconds ?? 0;
        }

        public double GetCurrentSeconds()
        {
            return reader?.CurrentTime.TotalSeconds ?? 0;
        }

        public void SetPosition(double seconds)
        {
            if (reader != null)
                reader.CurrentTime = System.TimeSpan.FromSeconds(seconds);
        }
    }
}