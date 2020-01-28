using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : MonoBehaviour
{
    private string name1;

    private string Getname()
    {
        return name1;
    }

    private void Setname(string value)
    {
        name1 = value;
    }

    private List <Player> players { get; set; }
    private StatisticsTeam statistics { get; set; }
    private Coach coach { get; set; }
    public int ranking { get; set; }

    public Team(string name, List<Player> players, StatisticsTeam statistics, Coach coach)
    {
        this.Setname(name);
        this.players = players;
        this.statistics = statistics;
        this.coach = coach;
        this.ranking = 0;
    }
}
