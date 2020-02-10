using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tournament : MonoBehaviour
{
    private List<Game> games { get; set; }
    public Team[] Teams { get; set; }
    private List<Court> courts { get; set; }
    private ColaCourt colaC;


    private class ColaCourt
    {
        private int ind;
        private int tam;
        private Court[] arr;
        private int n=9;
        private int cont { get; set; }
        private int indpop;

        public ColaCourt(int n)
        {
            ind = 0;
            arr = new Court[n];
            indpop = 0;
        }

        public bool empty()
        {
            return cont <= 0;
        }

        public bool full()
        {
            return cont >= n;
        }

        public void push(Court item)
        {
            if (!full())
            {
                arr[ind] = item;
                cont++;
                ind++;
                ind %= n;
            }
        }

        public Court pop()
        {
            int x = indpop;

            indpop++;
            indpop %= n;
            cont--;
            return arr[x];
        }

        public Court rotate()
        {
            Court s = pop();
            push(s);
            return s;
        }

        /*public void fillQueue()
        {
            string s = "";
            int y = 0;

            for (int i = 0; i <= n; i++)
            {
                y = i + 1;
                s = "Cancha" + y;
                push(s);

            }
        }*/

    }

    public Tournament(Team[] teams, List<Court> courts)
    {
        this.Teams = teams;
        this.games = games ?? throw new ArgumentNullException(nameof(games));
        this.courts = courts;
        this.colaC = new ColaCourt(courts.Count);
        foreach (Team team in Teams)
        {
            TeamT nuevo = new TeamT(team, 0);
        }

        foreach (Court court in courts)
        {
            colaC.push(court);
        }
    }


    public class TeamT {
        public Team team { get; set; }
        public int state { get; set; }

        public TeamT(Team team, int state)
        {
            this.team = team;
            this.state = state;
        }
    }

    public Court apartCourt()
    {
        bool res = true;
        Court temp = null;
        while (res)
        {
            temp = colaC.pop();
            if (temp.ocupado)
            {
                colaC.push(temp);
            }
            else
                res = false;
        }

        return temp;
    }

    public void createGame(Team team1, Team team2)
    {
        Court courtAct = apartCourt();
        if (courtAct == null)
        {
            Debug.Log("No hay campos disponbles para los partidos");
            return;
        }
        else
        {
            games.Add(new Game(courtAct, team1, team2));
        }
    }

    // Falta crear un juego para cada uno de los partidos que se estan creando

    
  
}
