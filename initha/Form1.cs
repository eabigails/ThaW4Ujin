using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace W4_Homework
{
    public partial class Form1 : Form
    {
        List<Team> teamlist = new List<Team>();
        public string selected_player = "";
        public Form1()
        {
            InitializeComponent();
            Preset preset = new Preset();
            teamlist.Add(preset.MU());
            teamlist.Add(preset.Chelsea());
            teamlist.Add(preset.Persebaya());
            Comboboxupdate();
        }

        private void button_add_team_Click(object sender, EventArgs e)
        {
            bool added = false;
            foreach (Team teamism in teamlist)
            {
                if (teamism.teamname == tbox_team_name.Text)
                {
                    MessageBox.Show("Team already exist");
                    added = true;
                }
            }
            if (added == false)
            {
                combobox_team.Items.Clear();
                Team team = new Team();
                team.Country = tbox_team_country.Text;
                team.teamname = tbox_team_name.Text;
                team.City = tbox_team_city.Text;
                team.PlayerList = new List<Player>();
                teamlist.Add(team);
                Comboboxupdate();
                tbox_team_country.Text = "";
                tbox_team_name.Text = "";
                tbox_team_city.Text = "";
            }
        }
     
        private void button_add_player_Click(object sender, EventArgs e)
        {
            if (tbox_player_name.Text != "" && tbox_player_number.Text != "" && combobox_position.SelectedIndex != -1)
            {
                bool added = false;
                bool numbered = false;
                
                foreach (Team team in teamlist)
                {
                    for (int i = 0; i < team.PlayerList.Count; i++)
                    {
                        if (team.PlayerList[i].pname == tbox_player_name.Text)
                        {
                            added = true;
                        }
                    }
                    for (int i = 0; i < team.PlayerList.Count; i++)
                    {
                        if (team.PlayerList[i].pnum == tbox_player_number.Text)
                        {
                            numbered = true;
                        }
                    }
                    if (added)
                    {
                        MessageBox.Show("Player already exist");
                        break;
                    }
                    if (numbered)
                    {
                        MessageBox.Show("Number already added");
                        break;
                    }

                    

                    if (team.teamname == combobox_team.SelectedItem.ToString() && added == false)
                    {
                        Player player = new Player();
                        player.pname = tbox_player_name.Text;
                        player.pnum = tbox_player_number.Text;
                        player.position = this.combobox_position.GetItemText(this.combobox_position.SelectedItem);
                        team.PlayerList.Add(player);
                        team.PlayerList.OrderBy(o => o.pnum).ToList();
                        playerupdate();
                        tbox_player_name.Text = "";
                        tbox_player_number.Text = "";
                        combobox_position.SelectedIndex = -1;
                       

                    }
                    


                }
            }
            else
            {

                MessageBox.Show("Please fill all the content", "Error", MessageBoxButtons.OK);
                

            }

        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            foreach (Team team in teamlist)
            {
                if (team.teamname == combobox_team.SelectedItem.ToString())
                {
                    if (team.PlayerList.Count <= 11)
                    {
                        MessageBox.Show("Too Little Players");
                        break;
                    }
                    for (int i = 0; i < team.PlayerList.Count; i++)
                    {
                        if ($"[{team.PlayerList[i].pnum}]{team.PlayerList[i].pname},{team.PlayerList[i].position}" == selected_player)
                        {
                            team.PlayerList.RemoveAt(i);
                            i--;
                            playerupdate();
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void lbox_value_change(object sender, EventArgs e)
        {
            selected_player = lbox_player.SelectedItem.ToString();
        }

        private void lbox_player_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Comboboxupdate()
        {
            cbox_country.Items.Clear();
            foreach (Team team in teamlist)
            {
                if (!cbox_country.Items.Contains(team.Country))
                {
                    cbox_country.Items.Add(team.Country);
                }
            }
        }
        private void comboteamupdate()
        {
            combobox_team.Items.Clear();
            foreach (Team team in teamlist)
            {
                if (team.Country == cbox_country.SelectedItem.ToString())
                {
                    combobox_team.Items.Add(team.teamname);
                }
            }
        }
        public void playerupdate()
        {
            lbox_player.Items.Clear();
            foreach (Team team in teamlist)
            {
                if (team.teamname == combobox_team.SelectedItem.ToString())
                {
                    foreach (Player player in team.PlayerList)
                    {
                        lbox_player.Items.Add($"[{player.pnum}]{player.pname},{player.position}");
                    }
                }
            }
            lbox_player.Sorted = true;
        }

        private void Country_Selected(object sender, EventArgs e)
        {
            lbox_player.Items.Clear();
            comboteamupdate();
        }

        private void Team_Selected(object sender, EventArgs e)
        {
            playerupdate();
        }
    }
}