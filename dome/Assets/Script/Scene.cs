using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour {

	public static bool isStart=false;
	// Use this for initialization
	void Start () {
	
	}
	public int MSPEED=3;
	// Update is called once per frame
	void Update () {
		if (Scene.isStart ) {
			Vector3 curPos = gameObject.transform.localPosition;
			if (curPos.x<=-330){
				curPos.x=-330;
			}
			curPos.x -= MSPEED;
			gameObject.transform.localPosition = curPos;
		}
	}
}
