using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterCurrent : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        if (this.transform.name == "Circle")
        {
            this.gameObject.tag = "Focus";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Untagged")
        {
            this.gameObject.tag = "Untagged";
            collision.gameObject.tag = "Focus";
        }
    }
}
