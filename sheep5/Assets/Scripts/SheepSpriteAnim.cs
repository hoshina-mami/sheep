using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SheepSpriteAnim : MonoBehaviour {

	private GameObject  sheep;

	SpriteRenderer spriteRenderer;
	public Sprite sprite1;

	// Use this for initialization
	void Start () {

		sheep = this.gameObject;

		sheep.GetComponent<Image> ().sprite = sprite1;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
