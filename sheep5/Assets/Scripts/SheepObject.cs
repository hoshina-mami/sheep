using UnityEngine;
using System.Collections;

public class SheepObject : MonoBehaviour {

	private MainController MainController;

	// Use this for initialization
	void Start () {

		MainController = GameObject.Find("MainController").GetComponent<MainController>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void DestroySheep() {
		//動き終わったひつじを消す
		Destroy (gameObject);
		//消したひつじをカウント
		MainController.CountDetroySheepNum();
	}
}
