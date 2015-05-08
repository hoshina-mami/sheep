using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class OptionController : MonoBehaviour {

	private GameObject Btn_on;
	private GameObject Btn_off;

	// Use this for initialization
	void Start () {

		Btn_on            = GameObject.Find("Btn_on");
		Btn_off           = GameObject.Find("Btn_off");

		//音量のON/OFF
		if (PlayerPrefs.GetInt("SoundFlg") != 0) {
			AudioListener.volume = 0;
			switchButtonInteractable (Btn_off, false);
		} else {
			AudioListener.volume = 0.7f;
			switchButtonInteractable (Btn_on, false);
		}
	
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
     * タイトル画面へ飛ぶ
     */
    public void LoadTitleScene () {    	
        Application.LoadLevel("Title");
    }

}


