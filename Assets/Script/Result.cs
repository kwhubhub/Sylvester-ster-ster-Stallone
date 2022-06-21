using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    //画面上部に　結果：○スタと表示
    public Text countResult;

    //画面下部に○の数字分だけスタを表示
    public Text textResult;

    //countの数だけ「スタ」を繋げて格納する変数
    public string sterString = "";

    //Start is called before the first frame update
    void Start()
    {
        ShowResult();
    }

    void setString()
    {
        //countの数だけスタを繋げてsterStringに格納
        for(int i = 0; i < GameDirector.count; i++)
        {
            sterString += "スタ";
        }
    }

    //結果を表示する関数
    void ShowResult()
    {
        setString();
        countResult.text = "結果：" + GameDirector.count + "スタ";
        textResult.text = "シルベスタ" + sterString + "ローン";
    }

}
