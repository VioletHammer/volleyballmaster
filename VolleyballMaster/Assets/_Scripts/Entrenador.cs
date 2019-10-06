using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrenador : MonoBehaviour
{
    private string user;
    private string paswrd;
    private string name;
    private string team;
    private Administrador Ad;

    public Entrenador(string u, string p, string n, string t)
    {
        this.user = u;
        this.paswrd = p;
        this.name = n;
        this.team = t;
        Ad = new Administrador();
    }
     
    public void RequestGame()
    {
        Ad.MatchUp(this.team);
    }

  
}
