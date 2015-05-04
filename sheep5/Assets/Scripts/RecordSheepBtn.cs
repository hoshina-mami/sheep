using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class RecordSheepBtn : MonoBehaviour {

    private RecordController RecordController;
    private Text sheepIdText;
    private int sheepId;

	// Use this for initialization
	void Start () {

        RecordController = GameObject.Find("RecordController").GetComponent<RecordController>();
	
	}
	
	/*
     * ポップアップを開く
     */
    public void showSheepPopup () {

        //ひつじIdを取得
        sheepIdText = GetComponentInChildren<Text>();
        sheepId = int.Parse(sheepIdText.text);

        RecordController.showSheepPopup(sheepId);

    }

}
