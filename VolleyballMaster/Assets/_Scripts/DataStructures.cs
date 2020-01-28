using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VolleyballMaster.DS
{

    public class Cola
    {
        private int ind;
        private int tam;
        private string[] arr;
        private static int n = 10;
        private int cont { get; set; }
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
            if (!full())
            {
                arr[ind] = item;
                cont++;
                ind++;
                ind %= n;
            }
        }

        public string pop()
        {
            int x = indpop;
            
            indpop++;
            indpop %= n;
            cont--;
            return arr[x];
        }

        public string rotate()
        {
            string s = pop();
            push(s);
            return s;
        }

        public void fillQueue()
        {
            string s = "";
            int y = 0;

            for (int i = 0; i <= n; i++)
            {
                y = i + 1; 
                s = "Cancha" + y;
                push(s);
          
            }
        }

    }

    public class Pila 
    {

        private string[] arreglo;
        private int tamano;
        private int pos;

        public Pila()
        {
            arreglo = new string[2];
            tamano = 2;
            pos = 0;

        }

        public void push(string item)
        {
            if (full())
            {
                Debug.Log("Espere un momento");

            }
            else
            {
                arreglo[pos] = item;
                pos++;
                Debug.Log("Se agrego " + item);

            }
        }


        public string pop()
        {
            int numero = this.pos;
            if (empty())
            {
                Debug.Log("No hay objetos en la pila");
                return null;
            }
            else
            {
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

    public class PriorityQueue {
        private Team[] array;
        private int size;
        
         public PriorityQueue(int n)
        {
            array = new Team[n];
            this.size = 0;
        }    

        public void insertItem(Team team)
        {
            array[size] = team;
            moveUp();
            size++;
        }

        private void moveUp()
        {
            int child = size;
            int parent = (child - 1) / 2;
            Team temp = array[child];
            while(child > 0 && temp.ranking < array[parent].ranking){
                  array[child] = array[parent];
                  child =  parent;
                  parent = (child-1)/2;  
            }
            array[child] =  temp;
        }

        public Team removeMin(){
            Team min =  array[0];
            array[0] =  array[--size];
            moveDown();
            return min;
        }

        private void moveDown(){
            bool flag = false;
            Team smallest = null;
            int parent = 0;
            int child = 2*parent+1;
            Team temp = array[parent];
            while(child < size && !flag){
                smallest = array[child];
                if(child+1 < size && array[child+1].ranking < array[child].ranking){
                    smallest = array[++child];}
                if(smallest.ranking < temp.ranking){
                    array[parent] = smallest;
                    parent = child;
                } 
                else{
                    flag = true;
                }   
                child =  2*parent+1;
            }
            array[parent] = temp;
        }
    }

}
