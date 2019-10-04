using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipo : MonoBehaviour
{
    private string nombre { get; set; }
    private string caracteristica { get; set; }

    public Equipo(string nombre, string caracteristica)
    {
        this.nombre = nombre;
        this.caracteristica = caracteristica;
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
