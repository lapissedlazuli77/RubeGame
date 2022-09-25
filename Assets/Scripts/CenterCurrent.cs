using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterCurrent : MonoBehaviour
{
    public bool currentfocus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.currentfocus != true)
        {
            this.currentfocus = false;
            collision.gameObject.transform.currentfocus = true;
        }
    }
}
