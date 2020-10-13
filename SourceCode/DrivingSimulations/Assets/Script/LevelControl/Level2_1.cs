using UnityEngine;
using System.Collections;

public class Level2_1 : MonoBehaviour {
	public GameObject handler;
	private Handler ha;

	void Awake ()
	{
		if(handler != null)
		{
			ha = handler.GetComponent<Handler>();
		}
	}

	//flag 1
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "CarTrigger" && other.name == "BackTrigger")
		{
			ha.TargetComplete(0);
		}
	}

	//flag 3
	void OnTriggerStay(Collider other)
	{
		if(other.tag == "CarTrigger" && other.name == "BackTrigger" && ha.flag[0] == ha.flag[1] == true)
		{
			ha.TargetComplete(2);
		}
	}
}
