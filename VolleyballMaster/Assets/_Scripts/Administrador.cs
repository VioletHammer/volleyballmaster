using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Administrador : MonoBehaviour
{
    private string nombre { get; set; }
    private long identificacion { get; set; }
    private Cola games;
    private Court canchas;

    // private List
    // Start is called before the first frame update
    void Start()
    {
        games = new Cola();  
        for(int i = 0; i<50; i++)
        {
            canchas.push("cancha "+i);
        }
    }


    public void MatchUp(string team)
    {
        games.push(team);
    }

  public string createGame()
    {
        string juego = null;
        if (games.canCreate() && !(canchas.empty()))
        {
            juego = games.pop() +"  vs  " +games.pop() + "se juagara en:  " +canchas.pop();
        }return juego;
    }

}
