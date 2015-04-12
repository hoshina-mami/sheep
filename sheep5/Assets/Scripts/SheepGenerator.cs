using UnityEngine;
using System.Collections;

public class SheepGenerator : MonoBehaviour {

	//public
	public float positonTop;
	public float positonBottom;
	public float incidence;//出現率(%)

	//private
	private MainController MainController;
	private GameObject sheep;//object created
	private GameObject clone;
	private GameObject Sheeps;
	private Transform cloneTransfrom;

	private Vector3 newScale;
	private Vector3 newPosition;
	private Vector3 fromPosition;
	private Vector3 toPosition;
	private uTools.uTweenPosition tweenPos;

	private bool isFirstSheep;


	// Use this for initialization
	void Start () {

		MainController = GameObject.Find("MainController").GetComponent<MainController>();
		Sheeps = GameObject.Find("Sheeps");

		//ひつじの出現率をStageDataから設定
		incidence = MainController.GetStageIncidence();

		//少なくとも1匹はひつじを出すためのフラグを立てておく
		isFirstSheep = true;
	
	}

	/*
	 * ひつじの初期化
	 */
	public void InitSheep (int sheepId) {

		//ひつじのプレハブをSheepDataから設定
		sheep = (GameObject)Resources.Load("Sheep" + sheepId);

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

		//ひつじの生成開始
		StartCreateSheep();

	}



	/*
	 * ひつじの生成を開始する
	 */
	void StartCreateSheep () {

		InvokeRepeating("CreateSheep", 0.5f, 0.5f);

		//5秒後に停止する
		Invoke("StopCreateSheep",  5.0f);

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


		//一定の確率で出現
		if (isFirstSheep || randomIncidence <= incidence) {
			
			isFirstSheep = false;

			clone = (GameObject)Instantiate(sheep);
			clone.transform.SetParent(Sheeps.transform, true );

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

			//ひつじの出現数をプラス
			MainController.CountSheepNum();

		}

	}
	
}
