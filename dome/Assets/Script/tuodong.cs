using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class tuodong : MonoBehaviour {

	Vector3 startPos ;
	Vector3 endPos ;
	public GameObject a;
	public GameObject b;
	public UILabel c;

	public ArrayList m_arr;
	public GameObject ttt;
	public GameObject tttt;
	public GameObject rock;
	Vector3 rockPos;
	// Use this for initialization
	void Start () {

		rockPos = rock.transform.localPosition;
	}


	void OnDragStart()
	{


		if ( m_arr == null) 
		{
			Debug.Log ("hehhahkfhawkehk");
			m_arr = new ArrayList();
			for (int i=0;i<80; i++){

				GameObject aa =(GameObject) GameObject.Instantiate(tttt, new Vector3(i * 2, 0, 0), Quaternion.identity);
				aa.transform.parent = a.transform.parent;
				Vector3 curPos = a.transform.localPosition;
				curPos.x = curPos.x+i*15 ;
				curPos.y = -(curPos.x)*(curPos.x)/1000  ;
				aa.transform.localPosition=curPos;
				aa.transform.localScale = tttt.transform.localScale;
				m_arr.Add(aa);
			}
		}
		ttt.SetActive (true);
		startPos = ttt.transform.localPosition;
	}
	
	static float yxishu=0;
	static float m_vy=0;
	static float m_r=0;
	void OnDrag(Vector2 delta)
	{
		
		Vector3 curPos = ttt.transform.localPosition;
		curPos.x += delta.x ;
		curPos.y += delta.y;
		ttt.transform.localPosition = curPos;
		float offy = curPos.y - startPos.y;
		float offx = curPos.x - startPos.x;

			Vector3 r=Vector3.zero;
			Vector3 aa=Vector3.zero;
			aa.z =Mathf.Atan2(-offy,-offx)*180/Mathf.PI;
			
			if (aa.z > 0 && aa.z < 90) {
				a.transform.localEulerAngles = aa;
				b.transform.localEulerAngles = r;
			}
		if (aa.z >= 0 && aa.z <= 90) {
			float xs=1.0f;
			if (offx <= -20 && offx >= -100) {
				
				c.text = (-(int)offx) + "%";
				xs=(50-offx)/100;
			}

			float ay=xs*30*40*Mathf.Sin(Mathf.PI/180* aa.z)/1600;
			for (int i=0;i<80; i++)
			{
				Vector3 curPosT = a.transform.localPosition;
				curPosT.x = curPosT.x+xs*30*i*Mathf.Abs(Mathf.Cos(Mathf.PI/180* aa.z));
				curPosT.y = curPosT.y+xs*30*i*Mathf.Abs(Mathf.Sin(Mathf.PI/180* aa.z))-ay*i*i/2 ;
				((GameObject)m_arr[i]).transform.localPosition = curPosT;
			}
			if (offx <= -20 && offx >= -100) {

				c.text = (-(int)offx) + "%";
			}
			yxishu=xs;
			m_vy=ay;
			m_r=aa.z;
		} 
	}
	void OnClick()
	{

	}
	int index=1;
	bool bisStart=false;
	float time;
	void Update () {
		if (bisStart && index<=80) {
			if (Time.time - time > 0.1f) {
				Vector3 cpos=rock.transform.localPosition;
				cpos.x = rockPos.x+yxishu*30*index*Mathf.Abs(Mathf.Cos(Mathf.PI/180* m_r));
				cpos.y = rockPos.y+yxishu*30*index*Mathf.Abs(Mathf.Sin(Mathf.PI/180* m_r))-m_vy*index*index/2 ;
				rock.transform.localPosition=cpos;
				index+=1;
				time=Time.time;
				Vector3 mrockr=Vector3.zero;
				float px=rockPos.x+yxishu*30*(index-1)*Mathf.Abs(Mathf.Cos(Mathf.PI/180* m_r));
				float py=rockPos.x+yxishu*30*(index-1)*Mathf.Abs(Mathf.Cos(Mathf.PI/180* m_r));
				mrockr.z=Mathf.Atan2(py-cpos.y,px-cpos.x ) * Mathf.Rad2Deg;
				rock.transform.localEulerAngles=mrockr;
			}
		}
	}

	void OnPress(bool press)
	{
		if (!press) {
			ttt.transform.localPosition = startPos;
			ttt.SetActive (false);
			bisStart = true;
		} else {
			bisStart = false;
			rock.transform.localPosition=rockPos;
			index=1;
		}
	}
}
