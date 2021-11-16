using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNum;

    
    // Start is called before the first frame update
    public void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "COINS : " +ScoreNum;
    }

    public void OnTriggerEnter2D(Collider2D Coin){

        if(Coin.tag =="Coin"){

        ScoreNum += 1;
        Destroy(Coin.gameObject);
        MyscoreText.text = "COINS " +ScoreNum;

        }
    }

    
}
