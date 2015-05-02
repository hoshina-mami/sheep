using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BtnStageNumController : MonoBehaviour {

    private int _StageNum;
    private Text btnNum;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /*
     * ステージ選択ボタンを押した時の処理
     */
    public void ClickStageNumBtn () {

        //ステージ番号をセット
        btnNum = GetComponentInChildren<Text>();
        _StageNum = int.Parse(btnNum.text);
        PlayerPrefs.SetInt("StageNum" ,  _StageNum);

        //ステージボタンを消す
        GameObject[] btns = GameObject.FindGameObjectsWithTag("stageNumBtn");
        foreach(GameObject btn in btns) {
            btn.GetComponent<uTools.uTweenAlpha> ().enabled = true;
        }

        //メイン画面へ飛ぶ
        Invoke("LoadMainScene",  0.7f);
        
    }

    /*
     * メイン画面へ飛ぶ
     */
    void LoadMainScene () {
        Application.LoadLevel("Main");
    }
}
