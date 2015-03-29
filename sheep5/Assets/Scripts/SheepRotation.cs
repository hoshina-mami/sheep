using UnityEngine;
using System.Collections;

public class SheepRotation : MonoBehaviour {

	private GameObject  sheep;
	public float speed = 10;

	// Use this for initialization
	void Start () {

		sheep = this.gameObject;
	
	}
	
	// Update is called once per frame
	void Update () {
		RotateSheep(sheep);
	}
	
	void RotateSheep(GameObject target)
	{
		Quaternion rotation = Quaternion.AngleAxis(speed, Vector3.forward);
		// 回転
		target.transform.rotation =  target.transform.rotation * rotation;
	}
}
