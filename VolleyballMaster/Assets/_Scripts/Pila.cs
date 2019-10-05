using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pila : MonoBehaviour
{

    private string[] arreglo;
    private int tamano;
    private int pos;

    public Pila()
    {
        arreglo = new string[100];
        tamano = 99;
        pos = 0;

    }

    public void push(string item)
    {
        if (full())
        {
            print("la pila esta llena");
        }
        else
        {
            arreglo[pos] = item;
            pos++;
            print("Se agrego "+ item);

        }
    }


    public string pop()
    {
        int numero = this.pos;
        if (empty())
        {
            print("No hay objetos en la pila");
            return null;
        }
        else
        {
            print(" ya se expulso " + arreglo[numero - 1]);
            this.pos--;
            return arreglo[numero - 1];
        }
    }


    public bool full()
    {
        return this.pos >= this.tamano;
    }

    
    public bool empty()
    {
        return pos <= 0;
    }
}
