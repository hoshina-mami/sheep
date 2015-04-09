using UnityEngine;
using System.Collections;


/**
 * ひつじのプレハブを生成するクラス
 * @scene Title
 */
public class CreateSheeps : MonoBehaviour {

	//public
	public GameObject sheep;//生成したいプレハブ
	public float positonTop;//プレハブを生成したい範囲のy座標の上限
	public float positonBottom;//プレハブを生成したい範囲のy座標の下限

	//private
	private GameObject clone;
	private GameObject Sheeps;
	private Transform cloneTransfrom;


	// Use this for initialization
	void Start () {

		//プレハブ生成の際に親となるGameObjectを格納
		Sheeps = GameObject.Find("Sheeps");
	
	}


	/*
	 * ひつじの生成を開始する
	 */
	public void StartCreateSheep () {
		InvokeRepeating("CreateSheep", 0.5f, 1f);
	}


	/*
	 * ひつじの生成を停止する
	 */
	void StopCreateSheep() {
		CancelInvoke();
	}


	/*
	 * ひつじを生成する関数
	 */
	void CreateSheep(){
		clone = (GameObject)Instantiate(sheep);
		clone.transform.parent = Sheeps.transform;

		// ひつじのデフォルトのposition, scaleを設定する
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

		// y位置を指定した範囲内でランダムに生成する
		float randomNum;
		randomNum = Random.Range (positonTop, positonBottom);
		
		// 生成した数値をTweenPositionのy座標に設定する
		uTools.uTweenPosition tweenPos = clone.GetComponent("uTools.uTweenPosition") as uTools.uTweenPosition;
		
		Vector3 newFromPosition = tweenPos.from;
		newFromPosition.y = randomNum;
		Vector3 newToPosition = tweenPos.to;
		newToPosition.y = randomNum;
		
		tweenPos.from = newFromPosition;
		tweenPos.to = newToPosition;

	}
	
}
