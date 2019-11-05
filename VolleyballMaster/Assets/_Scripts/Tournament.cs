using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tournament : MonoBehaviour
{
   private Administrator admin { get; set; }
   private List<Game> games { get; set; }

    public Tournament(Administrator admin, List<Game> games)
    {
        this.admin = admin ?? throw new ArgumentNullException(nameof(admin));
        this.games = games ?? throw new ArgumentNullException(nameof(games));
    }
}
