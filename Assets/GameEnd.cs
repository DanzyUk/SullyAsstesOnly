using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D other)// Checks if any object hits the Chest 
    {
        Debug.Log("Player hit chest");// Will let me the developer know that the player hit the chest
        SceneManager.LoadScene("Complete");// Using Unity Scnce Manager It will load the Complete Scene.
    }
}