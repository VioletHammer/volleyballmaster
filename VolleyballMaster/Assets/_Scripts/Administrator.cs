using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VolleyballMaster.DS;

public class Administrator: User
{
    private long id { get; set; }
    private string organization { get; set; }
    public List<Team> Teams { get; set; }
    public List<Court> Courts { get; set; }



    public Administrator(string name, string lastName, string password, string email, long id) : base(name, lastName, password, email, id)
    {
        Teams = new List<Team>();
    }


   public bool insertUser(string name, string lastName, string password, string email, long id)
    {
        bool result = false;
        


        return result;
    }
    // Torneos

    public PriorityQueue_Ranking pQueue = new PriorityQueue_Ranking(31);


    public void insertTeam(Team team)
    {
        bool result = true;
        foreach(Team team1 in Teams)
        {
            if (Equals(team.name, team1.name))
            {
                result = false;
                break;
            }
            else
            {
                result = true;
            }
        }
        if (result)
        {
            Teams.Add(team);
            Debug.Log("El equipo se creo correcto");
        }
       
    }


    public void createTournament()
    {
        if (Teams.Count >= 16)
        {
            for (int i = 0; i < Teams.Count; i++)
            {
                pQueue.insertItem(Teams[i]);
            }

            Team[] selectedTeams = new Team[16];
            foreach(Team teams in Teams)
            {
                pQueue.insertItem(teams);
            }
            for(int i =0; i < 16; i++)
            {
                selectedTeams[i] = pQueue.removeMin();
            }

            Tournament torneo = new Tournament(selectedTeams, Courts);
        }
        else
            Debug.Log("No hay suficientes equipos para el torneo");
    }

     public void createCourt(string name)
    {
        Courts.Add(new Court(name));
    }
 

}
