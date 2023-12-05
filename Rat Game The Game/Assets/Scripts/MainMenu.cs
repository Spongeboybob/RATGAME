using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    //plays game
    public void PlayGame()
    {
        SceneManager.LoadScene("KitchenScene");
    }
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }//quits game
}