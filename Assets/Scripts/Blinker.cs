﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Blinker : MonoBehaviour
{

    private GameObject PressSpaceKey; //点滅させたい文字

    private float nextTime;
    public float interval = 0.8f; //点滅周期


    // Use this for initialization
    void Start()
    {
       PressSpaceKey = GameObject.Find("PressSpaceKey");

        nextTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //一定時間ごとに点滅
        if (Time.time > nextTime)
        {
            float alpha = PressSpaceKey.GetComponent<CanvasRenderer>().GetAlpha();
            if (alpha == 1.0f)
                PressSpaceKey.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
            else
                PressSpaceKey.GetComponent<CanvasRenderer>().SetAlpha(1.0f);

            nextTime += interval;
        }

    }
}