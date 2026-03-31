using System;

namespace MusicPlayer
{
    public class MusicTrack
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public TimeSpan? Duration { get; set; }
        public string Genre { get; set; }
        public int FileSize { get; set; }
        public int PlayCount { get; set; }
        public DateTime DateAdded { get; set; }

        public string DisplayName =>
            $"{Title} - {Artist} ({Duration?.ToString(@"mm\:ss")})";
    }
}