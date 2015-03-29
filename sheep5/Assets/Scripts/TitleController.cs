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
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
