using System;

namespace class_library
{
    
    public class Episode
    {
        int views;
        double score;
        double maxscore;
        
        public Episode(int views,double score,double maxscore)
        {
            this.views = views;
            this.score = score;
            this.maxscore = maxscore;
        }
        public Episode()
        {
            views = 0;
            score = 0;
            maxscore = 0;
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
    }
}
