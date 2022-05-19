using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeScript : MonoBehaviour
{
  public bool isCutting=false;
    Rigidbody2D rb;
    Camera cam;
    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = GetComponent<Camera>();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StartCutting();
        }
        else if(Input.GetMouseButtonUp(0))
        {
            StopCutting();
        }
        if(isCutting)
        {
            UpdateCut();
        }
    }

    public void UpdateCut()
    {
        rb.position = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    public void StartCutting()
    {
        isCutting = true;
    }
    public void StopCutting()
    {
        isCutting = false;
    }
}
