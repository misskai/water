using UnityEngine;
using System.Collections;

public class Util 
{

	public static void DeleteChild(Transform parent)
	{
		for(int i=0;i<parent.childCount;)
		{
			GameObject.DestroyImmediate(parent.GetChild(i));
		}

	}
}
