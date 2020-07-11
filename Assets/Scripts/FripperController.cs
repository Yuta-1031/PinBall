using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FripperController : MonoBehaviour
{
	private HingeJoint myHingeJoint;
	private float defaultAngle = 20;
	private float flickAngle = -20;
	// Use this for initialization
	void Start()
	{
		this.myHingeJoint = GetComponent<HingeJoint>();
		SetAngle(this.defaultAngle);
	}
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
		{
			SetAngle(this.flickAngle);
		}
		if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
		{
			SetAngle(this.flickAngle);
		}
		if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
		{
			SetAngle(this.defaultAngle);
		}
		if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
		{
			SetAngle(this.defaultAngle);
		}


		var touchCount = Input.touchCount;
			
			for (int i = 0; i < touchCount; i++)
			{
			Touch touch = Input.GetTouch(i);

				if (touch.position.x <= Screen.width / 2)
				{
					if (touch.phase == TouchPhase.Began && tag == "LeftFripperTag")
					{
						SetAngle(this.flickAngle);
					}
					else if (touch.phase == TouchPhase.Ended && tag == "LeftFripperTag")
					{
						SetAngle(this.defaultAngle);
					}
				}
				if (touch.position.x >= Screen.width / 2)
				{
					if (touch.phase == TouchPhase.Began && tag == "RightFripperTag")
					{
						SetAngle(this.flickAngle);
					}
					else if (touch.phase == TouchPhase.Ended && tag == "RightFripperTag")
					{
						SetAngle(this.defaultAngle);
					}
				}
			}
		}
	
	public void SetAngle(float Angle)
	{
		JointSpring jointSpr = this.myHingeJoint.spring;
		jointSpr.targetPosition = Angle;
		this.myHingeJoint.spring = jointSpr;
	}
}