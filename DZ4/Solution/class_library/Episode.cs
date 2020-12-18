using System;

namespace class_library
{

    public class Episode:ICloneable
    {
        int views;
        double score;
        double maxscore;
        Description description;
       public Description Description { get => description; }
        public override string ToString()
        {
            return $"{views},{Convert.ToString(score).Replace(',', '.')},{Convert.ToString(maxscore).Replace(',', '.')},{description.Ep},{description.Length},{description.Title}";
        }
        public Episode(int views,double score,double maxscore,Description description)
        {
            this.views = views;
            this.score = score;
            this.maxscore = maxscore;
            this.description = description;
        }
        public Episode()
        {
            views = 0;
            score = 0;
            maxscore = 0;
        }
        public Episode(Episode episode)
        {
            this.views = episode.views;
            this.score = episode.score;
            this.maxscore = episode.maxscore;
            this.description = episode.description;
        }
        public TimeSpan GetLenght()
        {
            return description.Length;
        }
        
        public void AddView(double score)
        {
            views++;
            this.score += score;
            if (maxscore < score)
            {
                maxscore = score;
            }
        }
        public double GetMaxScore()
        {
            return maxscore;
        }
        public double GetAverageScore()
        {
            return score / views;
        }
        public int GetViewerCount()
        {
            return views;
        }

        public object Clone()
        {
            return new Episode(this);
        }

        public static bool operator>(Episode lhs,Episode rhs)
        {
            return lhs.GetAverageScore() > rhs.GetAverageScore();
        }
        public static bool operator <(Episode lhs, Episode rhs)
        {
            return lhs.GetAverageScore() < rhs.GetAverageScore();
        }
        
    }
}
