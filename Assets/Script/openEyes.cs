using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openEyes : MonoBehaviour
{
    public float openForce;
    public Rigidbody2D rb_up;

    void Start()
    {
        // set the original position
        transform.position = new Vector3(0, 7, 0);


    } 


    void Update()
    {
        //press space to "open the eyes"
        if (Input.GetKeyDown("space"))
        {
            //Debug.Log("space is pressed");
            rb_up.AddForce(new Vector2(0, openForce), ForceMode2D.Impulse);
        }



    }
}
