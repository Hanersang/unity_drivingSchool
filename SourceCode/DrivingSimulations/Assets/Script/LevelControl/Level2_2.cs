using UnityEngine;
using System.Collections;

public class Level2_2 : MonoBehaviour {
	public GameObject handler;
	private Handler ha;
	
	void Awake ()
	{
		if(handler != null)
		{
			ha = handler.GetComponent<Handler>();
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Car")
		{
			if(ha.flag[0] == true)
			{
				ha.TargetComplete(1);
			}
			else 
			{
				return;
			}
		}
	}
}
