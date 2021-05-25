using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public AudioClip CollectSound;
    
    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(CollectSound, transform.position);
    }
}
