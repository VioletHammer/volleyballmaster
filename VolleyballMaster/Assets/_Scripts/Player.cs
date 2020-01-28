using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : User
{
    private Team equipo { get; set; }
    private StatisticsPlayer statistics { get; set; }
    private int tshirtNumber { get; set; }

    public Player(Team equipo, StatisticsPlayer statistics, int tshirtNumber)
    {
        this.equipo = equipo;
        this.statistics = statistics;
        this.tshirtNumber = tshirtNumber;
    }

}