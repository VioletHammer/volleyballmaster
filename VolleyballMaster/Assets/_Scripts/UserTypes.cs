using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VolleyballMaster.DS;

namespace VolleyballMaster.UserTypes {

    public class Entrenador
    {
        public string user;
        public string paswrd;
        public string name;
        public string team;
        private Administrador Ad;

        public Entrenador(string u, string p, string n, string t)
        {
            this.user = u;
            this.paswrd = p;
            this.name = n;
            this.team = t;
            Ad = new Administrador();
        }

        public void RequestGame(Pila p, string t, Cola c)
        {
            c.fillQueue();
            Ad.MatchUp(p,t,c);
        }


    }


    public class Administrador
    {
        private string nombre { get; set; }
        private long identificacion { get; set; }


        public void MatchUp(Pila p, string team, Cola c)
        { 
            p.push(team);
            

            if (p.full())
            {
               
                createGame(p, c);
            }
            
        }

        public void createGame(Pila p, Cola c)
        {
            Debug.Log(p.pop()+"  vs  "+ p.pop()+" se jugará en: " + c.rotate());
        }

    }



}


