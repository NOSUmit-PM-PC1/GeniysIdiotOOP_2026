using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace GeniusIdiot
{
    public partial class FormSaveScore : Form
    {
        double score;
        public FormSaveScore()
        {
            InitializeComponent();
        }

        public FormSaveScore(double score)
        {
            InitializeComponent();
            this.score = score;
        }

        private void buttonSaveScore_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            if (string.IsNullOrEmpty(userName))
                MessageBox.Show("Введите имя");
            else
            {
                User user = new User();
                user.Name = userName;
                //user.SetScore(200);
                user.Score = this.score;
                var UsersRep = FormScore.ReadFromFile("data.json");
                UsersRep.Add(user);
                string json = JsonSerializer.Serialize(UsersRep);
                //string json = JsonSerializer.Serialize(user);
                StreamWriter sr = new StreamWriter("data.json");
                sr.Write(json);
                sr.Close();
                MessageBox.Show(json);
            }
        }
    }
}
