using UnityEngine;
using System.Collections;

public class Level1Exit : MonoBehaviour {

	string labelText = "";
	float time = 0;
	float sumTime = 2;
	bool flag = true;

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
