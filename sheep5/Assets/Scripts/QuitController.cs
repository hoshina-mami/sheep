using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class QuitController : MonoBehaviour {

    private GameObject Quit;

	// Use this for initialization
	void Start () {
        Quit = GameObject.Find("Quit");
        Quit.SetActive(false);
	}
	
	//ゲーム終了ボタンを押したときの処理
    public void ClickQuitBtn () {
        // アプリケーション終了
        Application.Quit();
        return;
    }
    //ゲーム継続ボタンを押したときの処理
    public void ClickContinueBtn () {
        Quit.SetActive(false);
    }
}
