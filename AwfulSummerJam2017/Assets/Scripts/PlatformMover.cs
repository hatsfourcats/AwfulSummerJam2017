﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public float startingSpeed = 10f;
    private float speed = 0f;

    void Start()
    {
        speed = 0f;
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
	
    public void ResumeGame()
    {
        speed = startingSpeed;
    }

    public void PauseGame()
    {
        speed = 0f;
    }

}
