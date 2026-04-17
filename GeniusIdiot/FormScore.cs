using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniusIdiot
{
    public partial class FormScore : Form
    {
        public FormScore()
        {
            InitializeComponent();
        }

        public static UsersRepository ReadFromFile(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            var jsonStr = sr.ReadToEnd();
            sr.Close();
            return JsonSerializer.Deserialize<UsersRepository>(jsonStr);
        }

        private void FormScore_Load(object sender, EventArgs e)
        {
            
            label1.Text = ReadFromFile("data.json").ToString();
        }
    }
}
