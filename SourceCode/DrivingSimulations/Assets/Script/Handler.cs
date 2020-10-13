using UnityEngine;
using System.Collections;

public class Handler : MonoBehaviour {
	public GameObject messageBroad;
	public GameObject targetBroad;
	public bool[] flag;

	private static int Score = 100;

	void Awake ()
	{
		int flagNumber = targetBroad.transform.childCount;
		flag = new bool[flagNumber];
		for(int i=0;i<flag.Length;i++)
		{
			flag[i] = false;
		}
	}

	public void EnterDemo () 
	{
		Application.LoadLevel("Level2");
	}

	public void ChangeMessage(string message = "")
	{
		string baseMessage = "Hi,moonrailgun!\n"+"Your Score:" + Handler.Score + "\n";
		messageBroad.GetComponent<UILabel>().text = baseMessage + message;
	}

	public void TargetComplete(int flagNumber)
	{
		if(flag[flagNumber] == false)
		{
			GameObject.Find("Target"+(flagNumber+1)).GetComponent<UIToggle>().value = true;
			//GameObject.Find("Target"+flagNumber +"/Background/Checkmark").animation.CrossFade("Checkmark");
			flag[flagNumber] = true;
		}
	}

	public void PointPenalty(int pointPenaltyNum)
	{
		Handler.Score -= pointPenaltyNum;

		ChangeMessage();

		if(Score == 0)
		{
			Debug.Log("Game Over!");
		}
	}
}
