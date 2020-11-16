using System;
using System.Collections.Generic;
using System.Text;

namespace class_library
{
    public static class TvUtilities
    {
        
        public static Episode Parse(string episode)
        {
            int views = Convert.ToInt32(episode.Split(',')[0]);
            double score = Convert.ToDouble(episode.Split(',')[1]);
            double maxscore = Convert.ToDouble(episode.Split(',')[2]); ;
            int ep= Convert.ToInt32(episode.Split(',')[3]); ;
            TimeSpan lenght = TimeSpan.Parse(episode.Split(',')[4]);
            string title = episode.Split(',')[5];
            Description description=new Description(ep,lenght,title);
            return new Episode(views,score,maxscore,description);
        }
        public static void Sort(in Episode[] episode)
        {
            Episode temp;
            for (int i = 0; i < episode.Length-1; i++)
            {
                for (int j = i+1; j < episode.Length; j++)
                {
                    if (episode[i] < episode[j])
                    {
                        temp = episode[i];
                        episode[i] = episode[j];
                        episode[j] = temp;
                    }
                }
            }
        }
        public static class Randomiser
        {
            public static double GetRandomScore()
            {
                Random rand = new Random();
                return rand.NextDouble() * 10;
            }
        }
    }
}
