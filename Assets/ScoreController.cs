using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    //スコアを0で初期化
    int GameObject = 0;

    //スコアを表示するテキスト
    private GameObject ScoreText;


    // Use this for initialization
    void Start()
    {
        this.ScoreText = UnityEngine.GameObject.Find("ScoreText");

    }



    // Update is called once per frame
    void Update() { }
    


    void OnCollisionEnter(Collision collision)
    {

        string yourTag = collision.gameObject.tag;

        if (yourTag == "SmallStarTag")
        {
            GameObject += 10;
        } else if (yourTag == "LargeStarTag")
        {
            GameObject += 20;
        } else if (yourTag == "SmallCloudTag")
        {
            GameObject += 5;
        }else if (yourTag == "LargeCloudTag")
        {
            GameObject += 15;
        }
        

        SetScore();

    }

    void SetScore()
    {
        this.ScoreText.GetComponent<Text>().text = "Score : " + GameObject.ToString();
    }
}


