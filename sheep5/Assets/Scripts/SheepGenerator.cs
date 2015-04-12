using UnityEngine;
using System.Collections;

public class SheepGenerator : MonoBehaviour {

	//public
	public GameObject sheep;//object created
	public float positonTop;
	public float positonBottom;
	public float incidence;//出現率(%)
	public float duration;//アニメーション所要時間

	//private
	private GameObject clone;
	private GameObject Sheeps;
	private Transform cloneTransfrom;

	private Vector3 newScale;
	private Vector3 newPosition;
	private uTools.uTweenPosition tweenPos;
	private Vector3 fromPosition;
	private Vector3 toPosition;

	// Use this for initialization
	void Start () {

		Sheeps = GameObject.Find("Sheeps");

		//cloneのscaleのデフォルト値を用意
		newScale = sheep.transform.localScale;
		newScale.x = 1;
		newScale.y = 1;
		newScale.z = 1;

		//cloneのpositionのデフォルト値を用意
		newPosition = sheep.transform.position;
		newPosition.x = 200;
		newPosition.y = 0;
		newPosition.z = 0;

		//cloneのy座標設定のためuTweenPositionを取得しておく
		tweenPos = sheep.GetComponent("uTools.uTweenPosition") as uTools.uTweenPosition;
		fromPosition = tweenPos.from;
		toPosition = tweenPos.to;

		//ひつじの回転スピードをSheepDataから設定

		//ひつじのスプライトをSheepDataから設定

		//ひつじの速度をSheepDataから設定

		

		//ひつじの生成開始
		StartCreateSheep();
	
	}


	/*
	 * ひつじの生成を開始する
	 */
	public void StartCreateSheep () {
		InvokeRepeating("CreateSheep", 0.5f, 0.5f);
	}

	/*
	 * ひつじの生成を止める
	 */
	void StopCreateSheep() {
		CancelInvoke();
	}

	/*
	 * ひつじを生成する
	 */
	void CreateSheep(){

		float randomIncidence;
		randomIncidence = Random.Range (0, 100);


		if (randomIncidence <= incidence) {
			clone = (GameObject)Instantiate(sheep);
			clone.transform.parent = Sheeps.transform;

			// デフォルトのscaleとpositionをセット
			clone.transform.localScale = newScale;
			clone.transform.position = newPosition;

			// y座標を指定した範囲内からランダムで生成
			float randomNum;
			randomNum = Random.Range (positonTop, positonBottom);
						
			fromPosition.y = randomNum;
			toPosition.y = randomNum;
			
			tweenPos.from = fromPosition;
			tweenPos.to = toPosition;

			//ひつじが転がる速さを設定
			tweenPos.duration = duration;
		}

	}
	
}
