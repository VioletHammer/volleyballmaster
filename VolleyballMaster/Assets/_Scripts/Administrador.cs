using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Administrador : MonoBehaviour
{
    private string nombre { get; set; }
    private long identificacion { get; set; }
    private Cola games;

    // private List
    // Start is called before the first frame update
    void Start()
    {
        games = new Cola();   
    }

    public void MatchUp(string team)
    {
        games.push(team);
    }

    

}
