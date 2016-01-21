using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class OptionController : MonoBehaviour {

	//public
	public GameObject sheep;//生成したいプレハブ

	private GameObject Btn_on;
	private GameObject Btn_off;

	private GameObject clone;
	private GameObject UI;
	private Transform cloneTransfrom;

	private Vector3 newScale;
	private Vector3 newPosition;
	private Vector3 fromPosition;
	private Vector3 toPosition;
	private uTools.uTweenPosition tweenPos;

	// Use this for initialization
	void Start () {
		Application.targetFrameRate = 60;

		UI            = GameObject.Find("UI");
		Btn_on        = GameObject.Find("Btn_on");
		Btn_off       = GameObject.Find("Btn_off");

		//音量のON/OFF
		if (PlayerPrefs.GetInt("SoundFlg") != 0) {
			AudioListener.volume = 0;
			switchButtonInteractable (Btn_off, false);
		} else {
			AudioListener.volume = 0.7f;
			switchButtonInteractable (Btn_on, false);
		}

		InvokeRepeating("CreateSheep", 2f, 12f);
	
	}


	//サウンドON
	public void clickOnBtn () {
		PlayerPrefs.SetInt("SoundFlg", 0);
		AudioListener.volume = 0.7f;
		switchButtonInteractable (Btn_on, false);
		switchButtonInteractable (Btn_off, true);
	}

	//サウンドOFF
	public void clickOffBtn () {
		PlayerPrefs.SetInt("SoundFlg", 1);
		AudioListener.volume = 0;
		switchButtonInteractable (Btn_on, true);
		switchButtonInteractable (Btn_off, false);
	}


	/*
	 * ボタンのアクティブ、非アクティブを切り替える
	 * @param {GameObject} ボタンのオブジェクト, {Bool} アクティブかどうか
	 */
	void switchButtonInteractable  (GameObject _target, bool _isInteractable) {

		_target.GetComponent <Button> () .interactable = _isInteractable;

	}


	/*
     * 公式サイトへ飛ぶ
     */
    public void GoWebSite () {    	
        Application.OpenURL("http://hitsuji-dama.com/");
    }

    /*
     * LINEストアへ飛ぶ
     */
    public void GoLineStore () { 
    	PlayerPrefs.SetInt("infoNotiFlg", 0);   	
        Application.OpenURL("http://line.me/S/shop/sticker/author/85999");
    }


	/*
     * タイトル画面へ飛ぶ
     */
    public void LoadTitleScene () {    	
        Application.LoadLevel("Title");
    }


    /*
	 * ひつじを生成する関数
	 */
	void CreateSheep(){
		clone = (GameObject)Instantiate(sheep);
		clone.transform.SetParent(UI.transform, true );

		// ひつじのデフォルトのposition, scaleを設定する
		newScale = clone.transform.localScale;
		newScale.x = 0.9f;
		newScale.y = 0.9f;
		newScale.z = 1;
		clone.transform.localScale = newScale;
		
		newPosition = clone.transform.position;
		newPosition.x = 420;
		newPosition.y = 0;
		newPosition.z = 0;
		clone.transform.position = newPosition;

		// 生成した数値をTweenPositionのy座標に設定する
		tweenPos = clone.GetComponent("uTools.uTweenPosition") as uTools.uTweenPosition;
		
		fromPosition = tweenPos.from;
		fromPosition.y = -360;
		toPosition = tweenPos.to;
		toPosition.y = -360;
		
		tweenPos.from = fromPosition;
		tweenPos.to = toPosition;

	}

}


