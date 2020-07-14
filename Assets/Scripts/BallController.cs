using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {
	private float visiblePosZ = -6.5f;
	private GameObject gameoverText;
	public Text point;
	public int num = 0;

	// Use this for initialization
	void Start () {
		this.gameoverText = GameObject.Find("GameOverText");
		num = 0;
		SetPoint();
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.z < this.visiblePosZ)
        {
			this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
	}

    void OnCollisionEnter(Collision collision)
    {
		string tag = collision.gameObject.tag;
		if (tag == "SmallStarTag" || tag == "SmallCloudTag")
		{
			num += 10;
		}
		else if(tag == "LargeStarTag"||tag=="LargeCloudTag")
		{
			num += 20;
		}
		SetPoint();
    }
	void SetPoint()
    {
		point.text = string.Format("POINT:{0}", num);
    }
   
}
