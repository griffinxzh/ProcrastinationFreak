using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class snooze : MonoBehaviour
{


    /*only stopBtn leads to win scene*/
    GameObject snoozeBtn;
    GameObject stopBtn;
    GameObject stopBtn2;

    GameObject eyelid_top;
    GameObject eyelid_bottom;

    public GameObject instructionText;
    public GameObject snoozeText;

    public SpriteRenderer spriteRenderer;
    public Sprite snoozeSprite;
    public Sprite clockSprite;

    bool snoozeToggle;

    public float delayTime;


    /*snooze sprite*/
    void ChangeSprite()
    {
        spriteRenderer.sprite = snoozeSprite;
    }



    /*alarm clock sprite*/
    void ChangeSprite2()
    {
        spriteRenderer.sprite = clockSprite;
    }






    void Start()
    {
        snoozeToggle = false;

        snoozeBtn = GameObject.Find("[btn]snooze");
        stopBtn = GameObject.Find("[btn]stop");
        stopBtn2 = GameObject.Find("[btn]stop2");

        eyelid_top = GameObject.Find("eyelid");
        eyelid_bottom = GameObject.Find("eyelid2");

        stopBtn2.SetActive(false);

        instructionText.SetActive(true);
        snoozeText.SetActive(false);
    }




    void Update()
    {
        //Debug.Log("snooze: " + snoozeToggle);



    }




    void OnMouseDown()
    {
        //countDown.curTime = 5.0f;

        if (snoozeToggle == false)
        {


            /*if "snooze" button is clicked, 
             * 
             * 1️⃣deactivate the stop btn, disable the snooze btn sprite & collider */
            stopBtn.SetActive(false);
            stopBtn2.SetActive(false);
            snoozeBtn.GetComponent<BoxCollider2D>().enabled = false;
            snoozeBtn.GetComponent<SpriteRenderer>().enabled = false;


            


            /*call ChangeSprite function*/
            ChangeSprite();


            /* 2️⃣disable the eyelid */
            eyelid_top.GetComponent<openEyes>().enabled = false;
            eyelid_bottom.GetComponent<openEyes_2>().enabled = false;


            /* 3️⃣change UI text*/
            instructionText.SetActive(false);
            snoozeText.SetActive(true);


            snoozeToggle = true;

        }
        else
        {
            snoozeToggle = false;
            
        }



        /*restart the alarm clock in seconds*/
        Invoke("RestartClock", delayTime);

    }


    public void RestartClock()
    {

        //SceneManager.LoadScene(3);

     

        /* revive btns */
        snoozeBtn.GetComponent<BoxCollider2D>().enabled = true;
        snoozeBtn.GetComponent<SpriteRenderer>().enabled = true;
        stopBtn2.SetActive(true);


        snoozeToggle = false;


        ChangeSprite2();


        /* 3️⃣change UI text*/
        instructionText.SetActive(true);
        snoozeText.SetActive(false);

        /* re-enable the eyelid */
        eyelid_top.GetComponent<openEyes>().enabled = true;
        eyelid_bottom.GetComponent<openEyes_2>().enabled = true;
    }
}
