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
    public GameObject MMA;
    public GameObject MMC;
    public GameObject MMP;
    public GameObject PlayerTeamView;
    public GameObject CoachTeamView;
    public GameObject AdminTeamView;
    public GameObject PlayerMatchView;
    public GameObject CoachMatchView;
    public GameObject AdminMatchView;
    public GameObject PlayerTournView;
    public GameObject CoachTournView;
    public GameObject AdminTournView;

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
        MMA.SetActive(false);
        MMC.SetActive(false);
        MMP.SetActive(false);

    }

    //Log in Functions

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

    public void FinalLogIn()
    {

        if (Input.text == e.user && Password.text == e.paswrd)
        {
            MatchMaker.SetActive(true);

        }
    }

    
    
    //Sign Up Fuctions
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



    //Button functions

        //Coach--------------------------------------------
    public void QueueUp()
    {
        e.RequestGame(teamStack, e.team, courtQ);
    }
    public void SeeMatchesC()
    {
        CoachTeamView.SetActive(false);
        CoachTournView.SetActive(false);
        CoachMatchView.SetActive(true);
        // Add overlay matches panel    
    }
    public void SeeTeamsC()
    {
        CoachTournView.SetActive(false);
        CoachMatchView.SetActive(false);
        CoachTeamView.SetActive(true);
        // Add overlay teams panel    
    }
    public void SeeTournC()
    {
        CoachTeamView.SetActive(false);
        CoachMatchView.SetActive(false);
        CoachTournView.SetActive(true);
        // Add overlay tournaments panel    
    }

    //Player-------------------------------------------------

    public void SeeMatchesP()
    {
        PlayerTeamView.SetActive(false);
        PlayerTournView.SetActive(false);
        PlayerMatchView.SetActive(true);
        // Add overlay matches panel    
    }
    public void SeeTeamsP()
    {
        PlayerTournView.SetActive(false);
        PlayerMatchView.SetActive(false);
        PlayerTeamView.SetActive(true);
        // Add overlay teams panel    
    }
    public void SeeTournP()
    {
        PlayerTeamView.SetActive(false);
        PlayerMatchView.SetActive(false);
        PlayerTournView.SetActive(true);
        // Add overlay tournaments panel    
    }

    //Admin--------------------------------------------------

    public void SeeMatchesA()
    {
        AdminTeamView.SetActive(false);
        AdminTournView.SetActive(false);
        AdminMatchView.SetActive(true);
        // Add overlay matches panel    
    }
    public void SeeTeamsA()
    {
        AdminTournView.SetActive(false);
        AdminMatchView.SetActive(false);
        AdminTeamView.SetActive(true);
        // Add overlay teams panel    
    }
    public void SeeTournA()
    {
        AdminTeamView.SetActive(false);
        AdminMatchView.SetActive(false);
        AdminTournView.SetActive(true);
        // Add overlay tournaments panel    
    }




}
