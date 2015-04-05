using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainController : MonoBehaviour {

	private int  _StageNum;

	//GameObjects
	private GameObject Btn_plus;
	private GameObject Btn_minus;

	// Use this for initialization
	void Start () {

		Btn_plus  = GameObject.Find("Btn_plus");
		Btn_minus = GameObject.Find("Btn_minus");

		//get stageNum
		_StageNum = PlayerPrefs.GetInt("StageNum");

//		Debug.Log (_StageNum);

		//make buttons unenable
		switchButtonInteractable (Btn_plus, false);
		switchButtonInteractable (Btn_minus, false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	//function switch button's interactable
	void switchButtonInteractable  (GameObject _target, bool _isInteractable) {

		_target.GetComponent <Button> () .interactable = _isInteractable;

	}
}
