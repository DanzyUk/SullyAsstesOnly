using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playaudio : MonoBehaviour
{
    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pickup")
        {
            sound.Play();
            Debug.Log("Collect Sound palyed");
        }
    }
}
