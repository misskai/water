using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	Vector3 startPos ;
	Vector3 endPos ;
	public float beishu=1;
	public GameObject m_scene2;
	public GameObject m_scene3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

   void OnClick()
	{
		//Debug.Log (" OnClick()  "+gameObject.name);
	}

	void OnDragStart()
	{
		startPos = gameObject.transform.localPosition;
	}


	void OnDrag(Vector2 delta)
	{
	
		Vector3 curPos1 = m_scene2.transform.localPosition;
		curPos1.x += delta.x;
		//curPos.y += delta.y;
		if (curPos1.x<=-330){
			curPos1.x=-330;
			return;
		}
		
		if (curPos1.x>=330){
			curPos1.x=330;
			return;
		}
		m_scene2.transform.localPosition = curPos1;

		Vector3 curPos3 = m_scene3.transform.localPosition;
		curPos3.x += delta.x*0.6f;
		//curPos.y += delta.y;
		if (curPos3.x<=-330){
			curPos3.x=-330;
		}
		
		if (curPos3.x>=330){
			curPos3.x=330;
		}
		m_scene3.transform.localPosition = curPos3;

		Vector3 curPos = gameObject.transform.localPosition;
		curPos.x += delta.x*0.2f;
		//curPos.y += delta.y;
		if (curPos.x<=-330){
			curPos.x=-330;
		}
		
		if (curPos.x>=330){
			curPos.x=330;
		}
		gameObject.transform.localPosition = curPos;
		Scene.isStart = false;
	}

	void OnPress(bool press)
	{
		if (press)
		{

		}
		else 
		{

		}
	}
}
