using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "finishTag")
        {

            Debug.Log("You Win");
            win();

        }
    }

    void win()
    {
        Debug.Log("YOU WIN");
        SceneManager.LoadScene ("Credit");
    }
    
        
    
}
