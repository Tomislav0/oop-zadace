using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace class_library
{
    public class Season : IEnumerable<Episode>, IEnumerator<Episode>

    {
        List<Episode> episodes;
        int position = -1;
        public int Num { get; private set; }
        public int Length { get; private set; }
        public Season(int num, List<Episode> episodes)
        {
            this.episodes = episodes;
            Num = num;
            Length = episodes.Count;
        }
        public Season(Season season)
        {
            List<Episode> newlist = new List<Episode>();
            for (int i = 0; i < season.episodes.Count; i++)
            {
                newlist.Add((Episode)season.episodes[i].Clone());
            }
            episodes = newlist;
            Num = season.Num;
            Length = episodes.Count;
        }
        public void Remove(string title) {
            int index = -1;
            for (int i = 0; i < episodes.Count; i++)
            {
                if (title == episodes[i].Description.Title)
                {
                    index = i;
                }
            }
            if (index == -1)  throw new TvException(title, "No such episode found.");
             episodes.RemoveAt(index);
            Length--;
        }       
        public void AddEpisode(Episode episode)
        {
            episodes.Add(episode);
            Length++;
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
        
        
        public bool MoveNext()
        {
            position++;
            return (position < episodes.Count);
        }
        public void Reset()
        {
            position = 0;

        }
        public object Current
        {
            get { return (Episode)episodes[position]; }
        }

        IEnumerator<Episode> IEnumerable<Episode>.GetEnumerator()
        {
            return ((IEnumerator<Episode>)this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)episodes;
        }

        void IDisposable.Dispose()
        {
            Reset();
        }
        Episode IEnumerator<Episode>.Current => episodes[position];
        public Episode this[int index]
        {
            get { return episodes[index]; }
        }
        public override string ToString()
        {
            string border = "=================================================";
            return $"Season {Num}:\n{border}\n{string.Join<Episode>(Environment.NewLine, episodes)}\nReport:\n{border}" +
                $"\nTotal viewers: {GetViewers()}\nTotal duration: {GetDuration()}\n{border}\n";
        }
    }
}
