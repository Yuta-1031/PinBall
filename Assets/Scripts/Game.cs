using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {
	public Text PointText;
	private int point = 0;

	// Use this for initialization
	void Start () {
		PointText = GameObject.Find("PointText").GetComponent<Text>();
		PointText.text = "POINT:" + point;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void AddPoint(int score)
    {
		point = point + score;
		PointText.text = "POINT:" + point;
    }
}
