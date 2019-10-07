using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Court :Cola 
{
    private string nombre;
    private bool ocupado;   // no creo que se nesesite

    public Court(string nombre, bool ocupado)
    {
        this.nombre = nombre;
        this.ocupado = ocupado;
    }

    public Court()
    {
    }
}
