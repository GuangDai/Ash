using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour{
     public void PlayGame(){
        Debug.Log("Start");  
        SceneManager.LoadScene("Test");
    }

    public void ExitGame(){
        Application.Quit();
        Debug.Log("Quit!"); 
    }

    public void Settings(){
       SceneManager.LoadScene("Settings");

    }
    
}