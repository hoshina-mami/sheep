using UnityEngine;
using System.Collections;

public class CreateSheeps : MonoBehaviour {

	//public
	public GameObject sheep;//object created
	//private
	private GameObject clone;
	private GameObject Sheeps;
	private Transform cloneTransfrom;

	// Use this for initialization
	void Start () {

		Sheeps = GameObject.Find("Sheeps");
	
	}


	 //start to create sheeps
	public void StartCreateSheep () {
		InvokeRepeating("CreateSheep", 0.5f, 1f);
	}

	//stop to create sheeps
	void StopCreateSheep() {
		CancelInvoke();
	}

	//create sheep object
	void CreateSheep(){
		clone = (GameObject)Instantiate(sheep);
		clone.transform.parent = Sheeps.transform;

		// set sheep's base scale and position
		Vector3 newScale = clone.transform.localScale;
		newScale.x = 1;
		newScale.y = 1;
		newScale.z = 1;
		clone.transform.localScale = newScale;
		
		Vector3 newPosition = clone.transform.position;
		newPosition.x = 200;
		newPosition.y = 0;
		newPosition.z = 0;
		clone.transform.position = newPosition;

		// set random value for tweenPosition.y
		float randomNum;
		randomNum = Random.Range (0, -350);
		
		uTools.uTweenPosition tweenPos = clone.GetComponent("uTools.uTweenPosition") as uTools.uTweenPosition;
		
		Vector3 newFromPosition = tweenPos.from;
		newFromPosition.y = randomNum;
		Vector3 newToPosition = tweenPos.to;
		newToPosition.y = randomNum;
		
		tweenPos.from = newFromPosition;
		tweenPos.to = newToPosition;

	}
	
}
