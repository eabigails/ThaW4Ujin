using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

internal class Preset
{
    public Team Persebaya()
    {
        String[] Playername = { "Satria Tama","I Gede Dida Dyatmika", "Ernando Ari Sutaryadi", "Leo Lelis", "Rizky Ridho Ramadhani","Althariz Ballah","Muhammad Hidayat", "Marselino Ferdinan","Andre Oktaviansyah","Paulo Victor", "Ahmad Nufiandani","Muhammad Supriadi"};
        String[] Playernumber = { "89","72","21","4","32","37","96","7","8","9","17","11" };
        String[] Pos = { "GK", "GK", "GK", "DF", "DF", "DF", "MF", "MF", "MF", "FW", "FW", "FW"  };
        Team team = new Team();
        team.teamname = "Persebaya";
        team.Country = "Indonesia";
        team.City = "Surabaya";
        team.PlayerList = new List<Player>();
        for (int i = 0; i < Playername.Count(); i++)
        {
            Player player = new Player();
            player.pname = Playername[i];
            player.pnum = Playernumber[i];
            player.position = Pos[i];
            team.PlayerList.Add(player);
            team.PlayerList.OrderBy(o => o.pnum).ToList();
        }
        return team;
    }
    public Team MU()
    {
        String[] Playername = { "Stefan Ortega", "Ederson", "Scott Carson", "Kyle Walker", "Rúben Dias", "John Stones", "Nathan Aké", "Kalvin Phillips", "Ilkay Gündogan", "Rodri", "Kevin De Bruyne", "Erling Haaland", "Julián Álvarez", "Riyad Mahrez" };
        String[] Playernumber = { "18", "31", "33", "02", "03", "05", "06", "04", "08", "14", "17", "09", "19", "26" };
        String[] Pos = { "GK", "GK", "GK", "DF", "DF", "DF", "DF", "MF", "MF", "MF", "MF", "FW", "FW", "FW" };
        Team team = new Team();
        team.teamname = "Manchester City Squad";
        team.Country = "United Kingdom";
        team.City = "Manchester";
        team.PlayerList = new List<Player>();
        for (int i = 0; i < Playername.Count(); i++)
        {
            Player player = new Player();
            player.pname = Playername[i];
            player.pnum = Playernumber[i];
            player.position = Pos[i];
            team.PlayerList.Add(player);
            team.PlayerList.OrderBy(o => o.pnum).ToList();
        }
        return team;
    }
    public Team Chelsea()
    {
        String[] Playername = {"Manuel Neuer","Dayot Upamecano", "Matthijs de Ligt", "Benjamin Pavard", "Josua Kimmich", "Serge Gnabry" , "Leon Goretzka", "Leroy Sane" , "Paul Wanner", "Lucas Hemandez" , "Thomas Muller" };
        String[] Playernumber = { "01", "02", "04", "05", "06", "07", "08", "10", "14", "21", "25" };
        String[] Pos = { "GK","DF","DF","DF","MF","FW","MF","FW","MF","DF","FW" };
        Team team = new Team();
        team.teamname = "Chelsea";
        team.Country = "United Kingdom";
        team.City = "London";
        team.PlayerList = new List<Player>();
        for (int i = 0; i < Playername.Count(); i++)
        {
            Player player = new Player();
            player.pname = Playername[i];
            player.pnum = Playernumber[i];
            player.position = Pos[i];
            team.PlayerList.Add(player);
            team.PlayerList.OrderBy(o => o.pnum).ToList();
        }
        return team;
    }

}