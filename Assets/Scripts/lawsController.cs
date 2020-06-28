using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lawsController : MonoBehaviour
{
	public bool SRename;

	void Start()
	{
		Rename();
	}

	void Update()
	{
		if(SRename==true)
		{
			Rename();
		}
	}

	public void Rename()
	{
		for (int i = 0; i < transform.childCount; i++)
		{	
			int numLvl = i + 1;
			transform.GetChild(i).gameObject.name = numLvl.ToString();
			SRename=false;
		}
	}
}
