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

        private void FormScore_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("data.json");
            var jsonStr = sr.ReadToEnd();
            sr.Close();
            var users = JsonSerializer.Deserialize<UsersRepository>(jsonStr);
            label1.Text = users.ToString();
        }
    }
}
