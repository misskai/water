using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour 
{
	Transform rocket;
	Transform potPanel;
	Transform potPrefab;


	// Use this for initialization
	void Awake () 
	{
		rocket = transform.FindChild ("rocket");
		potPanel = transform.FindChild ("potPanel");
		potPrefab = transform.FindChild ("potPrefab");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnEnable()
	{
		if(potPanel!=null)
		{
			Util.DeleteChild(potPanel);
		}
		if(potPrefab!=null)
		{
			potPrefab.gameObject.SetActive(false);
		}
	}

}
