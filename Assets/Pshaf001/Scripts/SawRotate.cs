﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawRotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0f,0f,100f) * Time.deltaTime); //Animation of the saw spining on z axis
    }
}
