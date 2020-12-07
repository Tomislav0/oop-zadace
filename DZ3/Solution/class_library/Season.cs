using System;
using System.Collections.Generic;
using System.Text;

namespace class_library
{
    public class Season
    {
        Episode[] episodes;
        public int Num { get; private set; }
        public int Length { get; private set; }
        public Season(int num,Episode[] episodes)
        {
            this.episodes = episodes;
            Num = num;

            Length = episodes.Length;
        }
        private int GetViewers()
        {
            int viewers = 0;
            foreach(Episode episode in episodes)
            {
                viewers += episode.GetViewerCount();
            }
            return viewers;
        }
        private TimeSpan GetDuration()
        {
            TimeSpan totalDuration = TimeSpan.Parse("0"); 
            foreach (Episode episode in episodes)
            {
                totalDuration += episode.GetLenght();
            }
            return totalDuration;
        }
        public Episode this[int index]
        {
            get {
                return episodes[index];
            }

        }
        
        public override string ToString()
        {
            string border = "=================================================";
            return $"Season {Num}:\n{border}\n{string.Join<Episode>(Environment.NewLine, episodes)}\nReport:\n{border}" +
                $"\nTotal viewers: {GetViewers()}\nTotal duration: {GetDuration()}\n{border}\n";
        }

    }
}
