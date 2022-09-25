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
        } else
        {
            this.gameObject.tag = "Untagged";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Untagged" && this.gameObject.tag == "Focus")
        {
            this.gameObject.tag = "Unused";
            collision.gameObject.tag = "Focus";
            Debug.Log(collision.gameObject.transform.name);
        }
        else if (collision.gameObject.tag == "Untagged" && this.gameObject.tag == "Untagged")
        {
            Debug.Log("N/A");
        }
        else if (collision.gameObject.tag == "Focus" && this.gameObject.tag == "Focus")
        {
            Debug.Log("N/A");
        }
        else if (this.gameObject.tag == "Focus" && collision.gameObject.tag == "Focus")
        {
            Debug.Log("N/A");
        }
    }
}
