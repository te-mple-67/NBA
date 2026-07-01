using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA
{
    public partial class Form1 : Form
    {
        private ApiClient api;
        private List<Team> teams;
        public Form1()
        {
            InitializeComponent();
            api = new ApiClient();
        }

        private void btnLoadTeams_Click(object sender, EventArgs e)
        {
            teams = api.GetTeams();
            listBoxTeams.Items.Clear();

            foreach (var team in teams)
            {
                listBoxTeams.Items.Add(team);
            }
            MessageBox.Show($"Загружено {teams.Count} команд", "Готово");
        }

        private void listBoxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxTeams.SelectedIndex;
            if (index >= 0 && teams != null)
            {
                Team selectedTeam = teams[index];
                var players = api.GetPlayers(selectedTeam.id);

                listBoxPlayers.Items.Clear();
                foreach (var player in players)
                {
                    listBoxPlayers.Items.Add(player);
                }
            }
        }
    }
}
