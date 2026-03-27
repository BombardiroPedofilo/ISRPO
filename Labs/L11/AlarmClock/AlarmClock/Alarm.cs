using System;

namespace AlarmClock
{
    public class Alarm
    {
        public int Id { get; set; }
        public TimeSpan Time { get; set; }   
        public bool IsActive { get; set; }
        public bool RepeatDaily { get; set; }
        public string Label { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}