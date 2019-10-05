using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cola : MonoBehaviour
{
    private int ind;
    private int tam;
    private string[] arr;
    private static int n = 4;
    private int cont;
    private int indpop;

    public Cola()
    {
        ind = 0;
        arr = new string[n];
        indpop = 0;
    }

    public bool empty()
    {
        return cont <= 0;
    }

    public bool full()
    {
        return cont >= n;
    }

    public void push(string item)
    {
        if (full())
            print("el Arreglo esta lleno");
        arr[ind] = item;
        cont++;
        ind++;
        ind %= n;
    }

    public string pop()
    {
        int x = indpop;
        if (empty())
            print("el Arreglo esta vacio");
        indpop++;
        indpop %= n;
        cont--;
        return arr[x];
    }
}
