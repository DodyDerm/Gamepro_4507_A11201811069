using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Enemy : MonoBehaviour
{
    

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "enemyTag")
        {
            Debug.Log("Game Over");
            Die();
    
        }
    }

    void Die()
    {
        Debug.Log("GAME OVER");
        SceneManager.LoadScene ("Retry");
    }


}
