using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// Scene Manger for the following commands.

public class MainMenu : MonoBehaviour
{
    public void PlayGame() //If Play is button is selected it will load Level 1 
    {
        SceneManager.LoadScene("Level1");//Using Unity SceneManger it loads the scene called Level1
        
           
    }

    public void Howtoplay() // If How to play is selected it will load the scence how to play.
    {
        SceneManager.LoadScene("Howtoplay");//Using Unity SceneManger it loads the scene called Howtoplay
    }

   public void Exitgame()// If Exits selected it will exit the game.
    {
        Application.Quit();//quites the application 
    }
}
