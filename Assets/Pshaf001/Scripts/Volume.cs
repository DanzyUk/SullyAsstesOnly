using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;//Audio Library 

public class Volume : MonoBehaviour
{
    public AudioMixer audioMixer; // Audio Mixer
    public void Setvolume (float Volume)
    {
        audioMixer.SetFloat("Volume", Volume);//Matching the Slider value with the Mainmixer named Volume
    }
}
//For the setting Volume slider
