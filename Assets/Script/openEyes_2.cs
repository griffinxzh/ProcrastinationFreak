using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openEyes_2 : MonoBehaviour
{
    public float openForce2;
    public Rigidbody2D rb_up2;

    void Start()
    {
        // set the original position
        transform.position = new Vector3(0, -4, 0);


    }


    void Update()
    {

        //press space to "open the eyes"
        if (Input.GetKeyDown("space"))
        {
            //Debug.Log("space2 is pressed");
            rb_up2.AddForce(new Vector2(0, openForce2), ForceMode2D.Impulse);
        }



    }
}
