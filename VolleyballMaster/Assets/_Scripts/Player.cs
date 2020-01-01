using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    private Team equipo { get; set; }
    private StatisticsPlayer statistics { get; set; }
    private int tshirtNumber { get; set; }

    public Player(Team equipo, StatisticsPlayer statistics, int tshirtNumber)
    {
        this.equipo = equipo ?? throw new ArgumentNullException(nameof(equipo));
        this.statistics = statistics ?? throw new ArgumentNullException(nameof(statistics));
        this.tshirtNumber = tshirtNumber;
    }
}
