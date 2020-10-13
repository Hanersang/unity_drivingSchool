using UnityEngine;
using System.Collections;

public class ObstacleBaseControl : MonoBehaviour {
	public GameObject handler;
	public int score;
	private Handler ha;
	
	void Awake ()
	{
		if(handler != null)
		{
			ha = handler.GetComponent<Handler>();
		}
	}
	void OnTriggerEnter(Collider other) {
		if(other.tag == "Car")
		{
			ha.PointPenalty(score);
		}

		if(other.tag == "CarTrigger")
		{
			ha.ChangeMessage(other.name.Replace("Trigger","") + " tread the line");
		}
	}
}
