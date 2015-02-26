using UnityEngine;
using System.Collections;

public class Bullt1 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	public float speed;
	public float dtime;
	bool isfall=false;
	static public float ctime;
	// Update is called once per frame
	void Update () {
		if (Bullt.isStart && gameObject.name!="Sprite") {
			float time=Time.time;
			if ((time-ctime)<=dtime){
				return;
			}
			Vector3 curPos = gameObject.transform.localPosition;
			curPos.x -= 5*Mathf.Cos(120);
			curPos.y += speed*Mathf.Sin(120);
			gameObject.transform.localPosition = curPos;
		}
	}
	
}
