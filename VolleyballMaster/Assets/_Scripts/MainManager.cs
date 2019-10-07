using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using VolleyballMaster.DS;
using VolleyballMaster.UserTypes;

public class MainManager : MonoBehaviour
{
    public GameObject FirstScreen;
    public GameObject LogInScreen;
    public GameObject MatchMaker;
    public InputField Input;
    public InputField Password;
    public Entrenador e = new Entrenador("u1", "123", "Pedro García", "Los Tigres del Volley");
    public Pila teamStack = new Pila();
    public Cola courtQ = new Cola();

    void Start()
    {
        MatchMaker.SetActive(false);
        LogInScreen.SetActive(false);
        FirstScreen.SetActive(true);
        


    }
    public void LogIn()
    {
        FirstScreen.SetActive(false);
        LogInScreen.SetActive(true);
    }

    public void SignUp()
    {
    }

    public void FinalLogIn()
    {
        
        if (Input.text == e.user && Password.text== e.paswrd)
        {
            MatchMaker.SetActive(true);

        }
    }

    public void QueueUp()
    {
        e.RequestGame(teamStack, e.team, courtQ);
    }

    

}
