using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {
	
	//private
	private GameObject TitleScript;
	private GameObject Background;
	private GameObject Logo;
	private GameObject Btn_start;
	private GameObject Btn_record;
	private GameObject Btn_option;
	private GameObject[] clouds;
	private GameObject[] sheeps;

	// Use this for initialization
	void Start () {
		 
		TitleScript = GameObject.Find("TitleScript");
		Background  = GameObject.Find("Background");
		Logo        = GameObject.Find("Logo");
		Btn_start   = GameObject.Find("Btn_start");
		Btn_record  = GameObject.Find("Btn_record");
		Btn_option  = GameObject.Find("Btn_option");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// called from onRelease Event of GameObject"Btn_start"
	void ClickStartBtn () {
		//makes object's alpha 0
		Logo.GetComponent<TweenAlpha> ().enabled = true;
		Btn_start.GetComponent<TweenAlpha> ().enabled = true;
		Btn_record.GetComponent<TweenAlpha> ().enabled = true;
		Btn_option.GetComponent<TweenAlpha> ().enabled = true;
		Background.GetComponent<TweenPosition> ().enabled = true;

		//remove clouds
		GameObject[] clouds = GameObject.FindGameObjectsWithTag("cloud");
		foreach(GameObject cloud in clouds) {
			Destroy(cloud);
		}

		//remove sheeps
		GameObject[] sheeps = GameObject.FindGameObjectsWithTag("sheep");
		foreach(GameObject sheep in sheeps) {
			Destroy(sheep);
		}

		//TODO stop to create sheeps
	}

	// called from TweenPosition of GameObject"Background"
	void LoadMainScene () {
		Application.LoadLevel("Main");
	}
}
