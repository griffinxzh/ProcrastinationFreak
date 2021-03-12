using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public float count = 5.0f;
    public float curTime;
    public float countSpeed;

    

    void Start()
    {
        curTime = count;
    }



    

  
    void Update()
    {
        if (curTime>0)
        {
            curTime -= countSpeed * Time.deltaTime;
        }
        else
        {

            timeEnded();
        }

        Debug.Log(curTime);
    }

    void OnMouseDown()
    {

        /* original time + snooze delay time. 
         
         delaytime is in snooze.cs*/
        curTime = count + 5.0f;


        
    }


    //If the player failed to stop the clock within certain amount of time, lose.
    void timeEnded()
    {
        //Debug.Log("you lose!");
        SceneManager.LoadScene(2);
    }


}
