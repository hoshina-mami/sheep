using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SheepSpriteAnim : MonoBehaviour {
	
	public Sprite sprite1;
	public Sprite sprite2;

	// Use this for initialization
	void Start () {

		InvokeRepeating("ChangeSprite", 0f, 0.5f);
	
	}

	void ChangeSprite () {
		if (GetComponent<Image> ().sprite == sprite1) {

			GetComponent<Image> ().sprite = sprite2;

		} else {

			GetComponent<Image> ().sprite = sprite1;

		}
	}
	
	void StopChangeSprite() {
		CancelInvoke();
	}
}
