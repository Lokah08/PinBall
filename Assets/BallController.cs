using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    //ボールが見える可能性のあるz軸の最小値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    //課題：スコアを表示するテキスト
    private GameObject scoreText;

    //課題：得点の値の変数を初期化
    private int score = 0;

 
    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");


        //課題：シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");

        //test
        Debug.Log("Score:" + score);
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";

            //練習：this.gameoverText.GetComponent<Text> ().text = "Game Over";の右辺の文字列を変更すると
            //GameOvreTextの表示が変わることを確認してみましょう。
            //this.gameoverText.GetComponent<Text>().text = "アウトです";
        }
    }


    //課題：衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 3;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 5;
        }
        else if (other.gameObject.tag == "LargeStarTag" || other.gameObject.tag == "LargeCloudTag")
        {
            score += 10;
        }
        this.scoreText.GetComponent<Text>().text = "Score:" + score;
    }
}
