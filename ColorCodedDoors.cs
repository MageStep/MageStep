using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCodedDoors : MonoBehaviour
{
	public int redKey = 0;
	void OnTriggerEnter(Collider other)
	{
		Debug.Log(other.tag);
		if(other.gameObject.CompareTag("redKey"))
		{
			redKey += 1;
			Destroy(other.gameObject);
		}
		if(other.gameObject.CompareTag("RedDoor"))
		{
			if(redKey > 0)
			{
				redKey -=1;
				Destroy(other.gameObject);
			}
			else
			{
				Debug.Log("You need a red key");
			}
		}
	}
}
