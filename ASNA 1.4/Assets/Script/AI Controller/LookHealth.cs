﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookHealth : MonoBehaviour
{
    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(Camera.main.transform);
        transform.Rotate(360, 360, 360);
    }
}
