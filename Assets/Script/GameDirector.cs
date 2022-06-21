using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    //TextUIを取得
    public Text label;

    //ボタンクリック回数
    public static int count;

    //プレイヤーの持ち時間
    public float startTime = 5.0f;

    //時間経過をカウントダウン表示するテキスト
    public Text countDownText;

    public Button btn;

    void Start()
    {
        //ボタンをアクティブにする
        btn.interactable = true;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //時間をカウントダウンする
        startTime -= Time.deltaTime;

        //時間を表示する。f0は小数点なしという意味
        countDownText.text = startTime.ToString("f0");

        //startTimeが0以下になったときの処理
        if (startTime <= 0)
        {
            countDownText.text = "終了！";
            btn.interactable = false;

            //3秒後にResult画面に遷移する
            Invoke("ResultTransition", 3f);
        }
    }

    //ボタンをクリックしたらcountを1増やす
    public void Click()
    {
        count++;
        
        //ボタンがクリックされたらlabelを更新
        label.text = count.ToString();
    }

    //Result画面に遷移させる関数
    public void ResultTransition()
    {
        SceneManager.LoadScene("ResultScene");
    }
}
