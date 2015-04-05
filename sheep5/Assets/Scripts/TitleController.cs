using UnityEngine;
using System.Collections;

public class TitleController : MonoBehaviour {

	//private
	private GameObject TitleControllerObj;
	private GameObject Background;
	private GameObject Logo;
	private GameObject Btn_start;
	private GameObject Btn_record;
	private GameObject Btn_option;

	// Use this for initialization
	void Start () {

		TitleControllerObj = GameObject.Find("TitleControllerObj");
		Background         = GameObject.Find("Background");
		Logo               = GameObject.Find("Logo");
		Btn_start          = GameObject.Find("Btn_start");
		Btn_record         = GameObject.Find("Btn_record");
		Btn_option         = GameObject.Find("Btn_option");

		//init PlayerPrefs
		PlayerPrefs.SetInt("StageNum" ,  1);
//		PlayerPrefs.SetInt("HighScoreStageNum" , 0);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// called from onRelease Event of GameObject"Btn_start"
	void ClickStartBtn () {
		//makes object's alpha 0
		Logo.GetComponent<uTools.uTweenAlpha> ().enabled = true;
		Btn_start.GetComponent<uTools.uTweenAlpha> ().enabled = true;
		Btn_record.GetComponent<uTools.uTweenAlpha> ().enabled = true;
		Btn_option.GetComponent<uTools.uTweenAlpha> ().enabled = true;
		Background.GetComponent<uTools.uTweenPosition> ().enabled = true;
		
		//remove clouds
		GameObject[] clouds = GameObject.FindGameObjectsWithTag("cloud");
		foreach(GameObject cloud in clouds) {
			cloud.GetComponent<uTools.uTweenAlpha> ().enabled = true;
		}
		
		//remove sheeps
		GameObject[] sheeps = GameObject.FindGameObjectsWithTag("sheep");
		foreach(GameObject sheep in sheeps) {
			sheep.GetComponent<uTools.uTweenAlpha> ().enabled = true;
		}
	}
	
	// called from TweenPosition of GameObject"Background"
	void LoadMainScene () {
		Application.LoadLevel("Main");
	}
}
