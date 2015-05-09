using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SheepSpriteAnim : MonoBehaviour {

	public Sprite sprite1;
	public Sprite sprite2;

	private Image sheepImage;

	// Use this for initialization
	void Start () {

		sheepImage = GetComponent<Image> ();

		InvokeRepeating("ChangeSprite", 0f, 0.5f);
	
	}

	void ChangeSprite () {
		if (sheepImage.sprite == sprite1) {

			sheepImage.sprite = sprite2;

		} else {

			sheepImage.sprite = sprite1;

		}
	}
	
	void StopChangeSprite() {
		CancelInvoke();
	}
}
