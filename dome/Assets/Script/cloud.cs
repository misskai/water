using UnityEngine;
using System.Collections;

public class cloud : MonoBehaviour {

	public int step;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 curPos = gameObject.transform.localPosition;
		if (curPos.x < -100) {
			curPos.x += step * Time.deltaTime;
		} else {
			curPos.x -= step*Time.deltaTime ;
		}

		gameObject.transform.localPosition = curPos;
	}
}
