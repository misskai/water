using UnityEngine;
using System.Collections;

public class Bullt : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public float speed;
	public float speedx;
	public static bool isStart=false;
	public float dtime;
	bool isfall=false;
	public int type;
	static public int curtype;
	// Update is called once per frame
	void Update () {
		if (curtype != type) {
			return;
		}
		if (isStart && gameObject.name!="Sprite") {
			Vector3 curPos = gameObject.transform.localPosition;
			curPos.x += speedx*Mathf.Cos(120);
			if (curPos.y >=220&&isfall==false){
				isfall=true;

			}
	
			if (isfall){
				Vector3 r=Vector3.zero;
				r.z=-110;
				curPos.y -= speed*Mathf.Sin(120);
				gameObject.transform.localEulerAngles=r;
				float time=Time.time;
				if (time>=dtime){
					gameObject.SetActive(false);
				}

			}else{
				curPos.y += speed*Mathf.Sin(120);
			}
			gameObject.transform.localPosition = curPos;
		}
	}

	void OnClick()
	{
		curtype=type;
		if (isStart) {
			isStart=false;
			Scene.isStart=false;
		}else{
			isStart=true;
			Bullt1.ctime = Time.time;
			Scene.isStart=true;
		}
	}

}
