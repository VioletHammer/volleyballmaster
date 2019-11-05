using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private Court court { get; set; }
    private Place place { get; set; }
    private Team team1 { get; set; }
    private Team team2 { get; set; }
    private System.DateTime date { get; set; }

    public Game(Court court, Place place, Team team1, Team team2, DateTime date)
    {
        this.court = court ?? throw new ArgumentNullException(nameof(court));
        this.place = place ?? throw new ArgumentNullException(nameof(place));
        this.team1 = team1 ?? throw new ArgumentNullException(nameof(team1));
        this.team2 = team2 ?? throw new ArgumentNullException(nameof(team2));
        this.date = date;
    }
}
