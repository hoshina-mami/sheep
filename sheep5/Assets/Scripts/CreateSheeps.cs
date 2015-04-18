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

	private Vector3 newScale;
	private Vector3 newPosition;
	private Vector3 fromPosition;
	private Vector3 toPosition;
	private uTools.uTweenPosition tweenPos;


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
		clone.transform.SetParent(Sheeps.transform, true );

		// ひつじのデフォルトのposition, scaleを設定する
		newScale = clone.transform.localScale;
		newScale.x = 1;
		newScale.y = 1;
		newScale.z = 1;
		clone.transform.localScale = newScale;
		
		newPosition = clone.transform.position;
		newPosition.x = 200;
		newPosition.y = 0;
		newPosition.z = 0;
		clone.transform.position = newPosition;

		// y位置を指定した範囲内でランダムに生成する
		float randomNum;
		randomNum = Random.Range (positonTop, positonBottom);
		
		// 生成した数値をTweenPositionのy座標に設定する
		tweenPos = clone.GetComponent("uTools.uTweenPosition") as uTools.uTweenPosition;
		
		fromPosition = tweenPos.from;
		fromPosition.y = randomNum;
		toPosition = tweenPos.to;
		toPosition.y = randomNum;
		
		tweenPos.from = fromPosition;
		tweenPos.to = toPosition;

	}
	
}
