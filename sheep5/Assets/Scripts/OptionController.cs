using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class OptionController : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}


	/*
     * タイトル画面へ飛ぶ
     */
    public void LoadTitleScene () {
        Application.LoadLevel("Title");
    }

}


