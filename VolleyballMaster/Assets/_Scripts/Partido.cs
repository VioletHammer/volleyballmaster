using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Partido : MonoBehaviour
{
    private Equipo[] equipos { get; set; }
    private System.DateTime fecha { get; set; }

    public Partido()
    {
        this.equipos = new Equipo[2];
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
