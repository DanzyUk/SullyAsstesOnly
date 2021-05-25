using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextlevel : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D other)// Checks if any object hits the Chest 
    {
        Debug.Log("Player hit chest");// Will let me the developer know that the player hit the chest
        SceneManager.LoadScene("Level2");// Using Unity Scnce Manager I will load the next level.
    }
}
