﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMove : MonoBehaviour
{
    float speed = 2.0f;

    void Update()
    {
        this.transform.Translate(0, 0, Time.deltaTime);
    }
}
