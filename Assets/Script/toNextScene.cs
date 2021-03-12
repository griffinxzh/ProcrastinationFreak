using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toNextScene : MonoBehaviour
{
    private void OnMouseDown()
    {
        
        //Debug.Log("mouse key is pressed");
        SceneManager.LoadScene(1);
    }


    
}
