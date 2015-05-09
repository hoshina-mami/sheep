using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class RecordSheepBtn : MonoBehaviour {

    private GameObject RecordControllerObj;
    private RecordController RecordController;
    private Text sheepIdText;
    private int sheepId;

	// Use this for initialization
	void Start () {

        RecordControllerObj = GameObject.Find("RecordController");
        RecordController = RecordControllerObj.GetComponent<RecordController>();
	
	}
	
	/*
     * ポップアップを開く
     */
    public void showSheepPopup () {

        RecordControllerObj.GetComponent<AudioSource>().Play();

        //notiを消す
        this.transform.FindChild("Pic_noti").gameObject.SetActive(false);

        //ひつじIdを取得
        sheepIdText = GetComponentInChildren<Text>();
        sheepId = int.Parse(sheepIdText.text);

        //今後notiが出ないよう設定
        PlayerPrefs.SetInt("SheepCheckedFlg_" + sheepId, 1);

        RecordController.showSheepPopup(sheepId);

    }

}
