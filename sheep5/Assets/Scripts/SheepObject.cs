using UnityEngine;
using System.Collections;

public class SheepObject : MonoBehaviour {

	private MainController MainController;
	private bool isMainScene;

	// Use this for initialization
	void Start () {

		isMainScene = checkMainController();

		if (isMainScene) {
			MainController = GameObject.Find("MainController").GetComponent<MainController>();
		}
	
	}
	
	bool checkMainController () {
		if (GameObject.Find("MainController") != null) {
			// ある
			return true;
		} else {
			// ない
			return false;
		}
	}

	void DestroySheep() {
		//動き終わったひつじを消す
		Destroy (gameObject);
		//消したひつじをカウント
		if (isMainScene) {
			MainController.CountDetroySheepNum();
		}
	}
}
