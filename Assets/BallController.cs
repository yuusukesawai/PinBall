﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

    //ボールが見えるZ軸の最大値
    private float visiblePosz = -6.5f;

    private GameObject gameoverText;

	// Use this for initialization
	void Start () {
        //シーン中のGameOverTextを取得
        this.gameoverText = GameObject.Find("GameOverText");
		
	}
	
	// Update is called once per frame
	void Update () {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosz)
        {
            //ゲームオーバーテキストを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
		
	}
}
