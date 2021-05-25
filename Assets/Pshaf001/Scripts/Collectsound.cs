using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectsound : MonoBehaviour
{
   public AudioClip Diamondsound;// Setting the game object audioclip to diamond sound can be changed in the inspector
    
    private void OnTriggerEnter(Collider other)//if the diamond collides with anything
    {
        AudioSource.PlayClipAtPoint(Diamondsound, transform.position);// play the audio at the postion of the diamond
    }

}
