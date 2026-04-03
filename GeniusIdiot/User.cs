using System;

namespace GeniusIdiot
{
    [Serializable]
    class User
    {
        // поля
        
        private int timeSecond;
        private double score;  // процент выполнения теста

        // свойства - обертка защищенные, доступные для изменения поля
        public string Name { get; set; }

        //string name;
        //public string Name {
        //    get { return name; }
        //    set { name = value; }
        //}

        public int TimeSecond { get; }
        public double Score
        {
            get { return Math.Round(score, 2); }
            set
            {
                if (value >= 0 && value <= 100)
                    score = value;
            }
        }

        public User() 
        { 
            timeSecond = 0;
        }
        public User(string name, int timeSecond)
        {
            this.Name = name;
            this.timeSecond = timeSecond;
            this.Score = 200;
            //this.score = 200;
        }


        public void Update(User user)
        {
            if (this.score > user.score)
            { 
                this.Score = user.score;
                this.timeSecond = user.TimeSecond;
            }
        }
        //public void SetScore(double x)
        //{ 
        //    if (x >= 0 && x <= 100)
        //        score = x;
        //}

        public override string ToString()
        {
            return $"{Name} - за время {TimeSecond} секунд выполнил тест на {Score}%";
        }
    }
}
