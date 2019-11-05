using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coach : User
{
   private List<Team> teams { get; set; }

    public Coach(List<Team> teams)
    {
        this.teams = teams ?? throw new ArgumentNullException(nameof(teams));
    }
}
