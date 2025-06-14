﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour
{
    public TextMesh Text;
    public ParticleSystem SparksParticles;

    private List<string> textToDisplay = new();

    private float RotatingSpeed;
    private float TimeToNextText;

    private int CurrentText;

    // Start is called before the first frame update
    void Start()
    {
        TimeToNextText = 0.0f;
        CurrentText = 0;

        Text = GetComponent<TextMesh>();

        RotatingSpeed = 1.0f;

        textToDisplay.Add("Congratulation");
        textToDisplay.Add("All Errors Fixed");

        Text.text = textToDisplay[0];

        SparksParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        TimeToNextText += Time.deltaTime;

        if (TimeToNextText > 1.5f)
        {
            TimeToNextText = 0.0f;

            CurrentText++;
            if (CurrentText >= textToDisplay.Count)
            {
                CurrentText = 0;
            }

            Text.text = textToDisplay[CurrentText];
        }
    } 
}