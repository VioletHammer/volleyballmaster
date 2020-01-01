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
    public GameObject MainMenu;
    public GameObject SUPlayer;
    public GameObject SUCoach;
    public GameObject SUAdmin;
    public GameObject SUFirstScreen;
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
        SUPlayer.SetActive(false);
        SUCoach.SetActive(false);
        SUAdmin.SetActive(false);
        SUFirstScreen.SetActive(false);

    }
    public void LogIn()
    {
        FirstScreen.SetActive(false);
        LogInScreen.SetActive(true);
    }

    public void SignUp()
    {
        FirstScreen.SetActive(false);
        SUFirstScreen.SetActive(true);
    }

    public void CoachSignUp()

    {
        MainMenu.SetActive(false);
        SUFirstScreen.SetActive(false);
        SUCoach.SetActive(true);
    }

    public void PlayerSignUp()

    {
        MainMenu.SetActive(false);
        SUFirstScreen.SetActive(false);
        SUPlayer.SetActive(true);
    }
    public void AdminSignUp()
    {
        MainMenu.SetActive(false);
        SUFirstScreen.SetActive(false);
        SUAdmin.SetActive(true);
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
