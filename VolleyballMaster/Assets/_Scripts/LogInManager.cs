using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogInManager : MonoBehaviour
{
    public GameObject FirstScreen;
    public GameObject LogInScreen;
    public InputField Input;
    public InputField Password;


    void Start()
    {

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
        if (Input.text == "u1" && Password.text=="123")
        {
            SceneManager.LoadScene("MatchMaker");
        }
    }
        
}
