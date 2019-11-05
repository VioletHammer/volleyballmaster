using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatisticsTeam : Statistics
{
    private int win { get; set; }
    private int losed { get; set; }
    private int played { get; set; }

    public StatisticsTeam(int win, int losed, int played)
    {
        this.win = win;
        this.losed = losed;
        this.played = played;
    }
}
