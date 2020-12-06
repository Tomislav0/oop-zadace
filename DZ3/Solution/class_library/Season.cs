using System;
using System.Collections.Generic;
using System.Text;

namespace class_library
{
    public class Season
    {
        Episode[] episodes;
        public int Num { get; private set; }
        int viewers=0;
        TimeSpan totalDuration=TimeSpan.Parse("0");
        public int Length { get; private set; }
        public Season(int num,Episode[] episodes)
        {
            this.episodes = episodes;
            Num = num;
            foreach(Episode episode in episodes)
            {
                viewers += episode.GetViewerCount();
                totalDuration += episode.GetLenght();
            }
            Length = episodes.Length;
        }
        public Episode this[int index]
        {
            get {
                viewers++;
                return episodes[index];
            }

        }
        public void AddView(int viewers)
        {
            this.viewers += viewers;
        }
        public override string ToString()
        {
            string border = "=================================================";
            return $"Season {Num}:\n{border}\n{string.Join<Episode>(Environment.NewLine, episodes)}\nReport:\n{border}" +
                $"\nTotal viewers: {viewers}\nTotal duration: {totalDuration}\n{border}\n";
        }

    }
}
