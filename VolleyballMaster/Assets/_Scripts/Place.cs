using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour
{
    private string address { get; set; }
    private int capacity { get; set; }
    private List<Court> courts { get; set; }

    public Place(string address, int capacity, List<Court> courts)
    {
        this.address = address ?? throw new ArgumentNullException(nameof(address));
        this.capacity = capacity;
        this.courts = courts ?? throw new ArgumentNullException(nameof(courts));
    }
    //Creo que no hace falta el atributo de partidos


}
