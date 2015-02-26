using UnityEngine;
using System.Collections;

public class BulltAni : MonoBehaviour {

	TweenPosition posAni;
	TweenRotation rotAni;
	Transform bomb;
	Transform rocket;
	TweenScale scaleAni;

	int maxX;
	// Use this for initialization
	void Awake () 
	{
	
		posAni = GetComponent<TweenPosition> ();
		rotAni = GetComponent<TweenRotation> ();
		posAni.from = transform.localPosition;
//		posAni.to = new Vector3 (1513,-30,0);
		posAni.SetOnFinished (ShowBomb);
		posAni.duration = 10;
		rotAni.duration = 10;
		bomb = transform.FindChild ("Bomb");
		rocket = transform.FindChild ("rocket");
		scaleAni = bomb.GetComponent<TweenScale> ();
		maxX =(int) Random.Range(posAni.to.x-800, posAni.to.x);

	}
	
	// Update is called once per frame
	void Update ()
	{ 
		if(enabled)
		{
			if(transform.localPosition.x > maxX)
			{
				ShowBomb();
			}
		}
	}
	void ShowBomb()
	{
		rocket.gameObject.SetActive (false);
		posAni.enabled = false;
		rotAni.enabled = false;
		bomb.gameObject.SetActive (true);
	}
	void OnEnable()
	{
		if(bomb!=null)
		{
			bomb.gameObject.SetActive (false);
		}
		if(rocket!=null)
		{
			rocket.gameObject.SetActive(true);
		}
		if(posAni!=null)
		{
			posAni.enabled = true;
		}
		if(rotAni!=null)
		{
			rotAni.enabled = true;
		}
	}
}
