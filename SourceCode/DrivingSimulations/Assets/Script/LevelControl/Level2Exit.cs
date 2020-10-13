using UnityEngine;
using System.Collections;

public class Level2Exit : MonoBehaviour {
	public bool flag1 = false;
	public bool flag2 = false;
	public bool flag = false;

	string labelText = "";
	float time = 0;
	float sumTime = 2;

	void OnTriggerEnter (Collider other) {
		if(flag1 == false) {flag1 = true;return;}

		if(flag2 == true) {
			flag = true;
		}
	}
	void TriggerMessage () {
		if(flag1 == true && flag2 == false)
		{
			flag2 = true;
		}
	}

	void Update () {
		if(sumTime - time < 0 )
		{
			Debug.Log("Jump to next stage!");
		}
	}
	
	
	void OnTriggerStay (Collider other) {
		if(flag == true && other.name == "Car")
		{
			time += Time.deltaTime;
			labelText = "Remain " + Mathf.CeilToInt(sumTime - time) + " seconds to left this level";
		}
	}
	void OnTriggerExit (){
		labelText = "";
		time = 0;
	}
	void OnGUI () {
		GUI.Label(new Rect(10,30,200,200),labelText);
	}
}
