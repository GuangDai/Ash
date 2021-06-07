using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Settings : MonoBehaviour{
     public void Back(){
        Debug.Log("Start");  
        SceneManager.LoadScene("Start");
    }

}