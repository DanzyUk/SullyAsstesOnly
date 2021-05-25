using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameISPause = false;// Creating a public variable and setting it to false using bool so it can only be True or False 
    public GameObject pauseMenuUI;// The game Object PauseMenuUI

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))// If Escape button is pressed it will do the following.
        {
            if (GameISPause)// If the game is already paused it will resume the game.
            {
                Resume();// Resume Command below.
            }
            else// If the game is playing it will Pause the game.
            {
                Pause();//Pause command Below.
            }
               
                
           
        }

        
    }
    public void Resume()// The  void for Resume so we can use the command again without writting out the whole code again. 
        //It is made public so in Unity Inspector we can use the onclick and set it to the following code
    {
        pauseMenuUI.SetActive(false);//sets the Pause menu UI to false so when the resume buttom is selected it will hide the UI
        Time.timeScale = 1f;// Reset the Time in the game to 1
        GameISPause = false;// So that the player can repause the game it resets the gameisPause to false
    }

    public void Pause()// The  void for Pause so we can use the command again without writting out the whole code again.
    //It is made public so in Unity Inspector we can use the onclick and set it to the following code
    {
        pauseMenuUI.SetActive(true);//sets the Pause menu UI to True so when the Escape is pressed it will show the UI
        Time.timeScale = 0f;// Using the timescale it freeze in game time.
        GameISPause = true;// Sets the Game is pause to true
    }
    public void LoadMenu()
    //It is made public so in Unity Inspector we can use the onclick and set it to the following code
    {
        SceneManager.LoadScene("MainMenu");//Using UNity scenemanger it loads the Mainmenu scene
        Time.timeScale = 1f;// Resets Timesclase so when you come back into the game it is still not frozen.

    }
    
}
