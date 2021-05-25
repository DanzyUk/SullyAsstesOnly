using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LevelStatus : MonoBehaviour
{
    public GameObject[] ScoreDiamond; //GameObject for Number of diamonds
    public GameObject[] replaybutton; //Gameobject for replay button
    public GameObject[] nextlevelbutton; //Gameobject for Nextlevel button
    private int diamondcount;// Int for diamondcount

    // Start is called before the first frame update
    void Start()
    {
        diamondcount = GameObject.FindGameObjectsWithTag("Diamond").Length;//Checking how many game object there are with the tag Diamond
    }
    public void diamondachived()// diamond achived function
    {
        int diamondleft = GameObject.FindGameObjectsWithTag("Diamond").Length; //Setting how many diamonds are to diamond left
        int diamondcollected = diamondcount - diamondleft;//Calculating how diamond have been collected by take away the ahcived by the left

        float percentage = float.Parse(diamondcollected.ToString()) / float.Parse(diamondcount.ToString()) * 100f; // Working out a percentage out of 100 of how many diamond have been collected

        if (percentage < 33f)// if the percentage is below 33
        {
            replaybutton[0].SetActive(true);// it will see the gameobject replaybutton setactive to true which will show it
            nextlevelbutton[0].SetActive(false);// it will see the gameobject Nextlevel button setactive to false which will hid it
        }// This will stop the player from going to the next level without collecting enough diamonds
        
        if (percentage >= 33f && percentage < 66)// if the percentage is between or equal 33 & 66 percent
        {
            ScoreDiamond[0].SetActive(true);// It will only show 1 diamond by setting the gameobject to ture 
        }

        else if (percentage >= 66 && percentage < 70)// if the percentage is between or equal 66 & 70 percent
        {
            ScoreDiamond[0].SetActive(true);// It will only show 2 diamond by setting the gameobject to ture 
            ScoreDiamond[1].SetActive(true);//indicating to the player how well they done the level.
        }
        else if (percentage >= 70)// if the percentage is more or equal 70 percent
        {
            ScoreDiamond[0].SetActive(true);// It will show all 3 diamond by setting the gameobject to ture 
            ScoreDiamond[1].SetActive(true);//The max the player can get.
            ScoreDiamond[2].SetActive(true);
        }
    }
}
