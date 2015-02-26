using UnityEngine;
using System.Collections;

public class Mani : MonoBehaviour {
	public UISprite m_sprite;
	// Use this for initialization
	int frame=1;
	public int maxFrame=10;
	public float dtime=0.2f;
	float  time=0;
	void Start () {
		time = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - time > dtime) {
			m_sprite.spriteName = "x" + frame;
			frame=frame+1;
			if (frame>maxFrame) {
				frame=1;
			}
			time=Time.time;
		}
	}
}
