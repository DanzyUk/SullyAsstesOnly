using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// Scene Manger for the following commands.
public class NextLevelButton : MonoBehaviour
{
    public void loadlevel2() //If Nextlevel  button is selected it will load the next level 2
    {
       SceneManager.LoadScene("Level2");  
    }
    public void loadlevel3() //If Nextlevel  button is selected it will load the next level 3
    {
       SceneManager.LoadScene("Level3");
    }
    public void loadlevel4() //If Nextlevel  button is selected it will load the next level 4
    {
       SceneManager.LoadScene("Level4");
    }
    public void loadlevel5() //If Nextlevel  button is selected it will load the next level 5
    {
       SceneManager.LoadScene("Level5");
    }
    public void Gamewon() //If Nextlevel  button is selected it will load the Game Complete screen
    {
       SceneManager.LoadScene("Complete");
    }
    public void Replay() //If Replay button is pressed it will be restart the current scene
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);// Using Unity scene manager to restart the current scene
    }
}