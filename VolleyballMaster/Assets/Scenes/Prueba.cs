using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prueba : MonoBehaviour
{
    private InputField iput;
    private Equipo[] equipos;
    private int n;

    public Prueba()
    {
        this.equipos = new Equipo[10];
        
    }
    
    public void getInput(string s)
    {

    }

    public bool click()
    {
        return GameObject.Find("BotonAceptar");
    }

    public void cEquipo(string nombre, string caracteristica)
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(equipos.Length < 10)
            {
               
            }
        }
    }

    public bool enter()
    {
        return Input.GetKeyDown(KeyCode.B);
    }

    // Start is called before the first frame update
    void Start()
    {
        print("Hola mundo");
    }

    // Update is called once per frame
    void Update()
    {
        if (enter())
        {
            print(" Busted oprimios la tecla b");
        }
        if (Input.GetMouseButtonDown(0))
        {
            print("Actualización del numero" + n++);
        }

        if (Input.GetMouseButtonDown(1))
        {
            print("Actualización del numero" + n--);
        }

        if (click())
        {
            print("imprimio aceptar");
        }

    }
}
