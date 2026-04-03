using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniusIdiot
{
    [Serializable]
    class User
    {
        // поля
        //string name;
        private int timeSecond;
        private double score;  // процент выполнения теста

        // свойства - обертка защищенные, доступные для изменения поля

        public string Name { get; set; }

        //public string Name {
        //    get { return name; }
        //    set { name = value; }
        //}

        public int TimeSecond { get; }
        public double Score
        {
            get { return score; }
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
            this.score = 200;
        }

        public void SetScore(double x)
        { 
            if (x >= 0 && x <= 100)
                score = x;
        }

        public string ToString()
        {
            return $"{Name} - за время {TimeSecond} секунд выполнил тест на {Score}%";
        }
    }
}
