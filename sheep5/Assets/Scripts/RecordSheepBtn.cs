using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class RecordSheepBtn : MonoBehaviour {

    private RecordController RecordController;

	// Use this for initialization
	void Start () {

        RecordController = GameObject.Find("RecordController").GetComponent<RecordController>();
	
	}
	
	/*
     * ポップアップを開く
     */
    public void showSheepPopup () {

        RecordController.showSheepPopup();

    }

}
