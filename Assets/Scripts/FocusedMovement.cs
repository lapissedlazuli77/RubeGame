using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusedMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform targetFocus;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(targetFocus.gameObject.transform.currentfocus != true)
        {

        }
        this.transform.position = new Vector3(targetFocus.position.x, targetFocus.position.y, this.transform.position.z);
    }
}
