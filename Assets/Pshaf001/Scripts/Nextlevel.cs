using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextlevel : MonoBehaviour
{
    public GameObject Levelstatus;// Selecting gameobject which is the chest
    private void OnTriggerEnter2D(Collider2D other)// Checks if any object hits the Chest 
    {
        Levelstatus.SetActive (true);// activating game object levelstatus
        GetComponent<LevelStatus>().diamondachived();//Running code from Levelstatus from the function diamondachived
    }
}
