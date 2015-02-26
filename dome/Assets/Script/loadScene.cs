using UnityEngine;
using System.Collections;

public class loadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnClick()
	{
		Scene.isStart=false;
		Bullt.isStart=false;
		Bullt1.ctime = Time.time;
		Application.LoadLevel("Test") ;
	}
}
