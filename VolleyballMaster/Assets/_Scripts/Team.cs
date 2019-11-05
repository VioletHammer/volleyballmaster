using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : MonoBehaviour
{
    private string name { get; set; }
    private List <Player> players { get; set; }
    private StatisticsTeam statistics { get; set; }
    private Coach coach { get; set; }

    public Team(string name, List<Player> players, StatisticsTeam statistics, Coach coach)
    {
        this.name = name;
        this.players = players;
        this.statistics = statistics;
        this.coach = coach;
    }
}
