using UnityEngine;
using System.Collections;

public class acti8ve : MonoBehaviour {
	public GameObject c;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnClick()
	{
		c.SetActive(true);
	}
}
