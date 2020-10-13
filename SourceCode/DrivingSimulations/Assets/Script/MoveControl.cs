using UnityEngine;
using System.Collections;

public class MoveControl : MonoBehaviour {
	private float _carSpeed;
	private float _carAngle;
	private float changeMoveSpeed = 10f;
	private float changeAngleSpeed = 10f;

	public float CarAngle
	{
		get
		{
			return this._carAngle;
		}
		set
		{
			this._carAngle = value;
			if(this._carAngle >=45) {this._carAngle = 45;}
			else if(this._carAngle <= -45) {this._carAngle =-45;}
		}
	}
	public float CarSpeed
	{
		get {return this._carSpeed;}
		set {this._carSpeed = value;}
	}
	
	// Update is called once per frame
	void Update () {
		//left and right
		CarAngle = Input.GetAxis("Horizontal") * Time.deltaTime * changeAngleSpeed * 90;

		//front and back
		if(Input.GetAxis("Vertical") != 0)
		{
			CarSpeed = Input.GetAxis("Vertical");
			transform.Rotate(0,CarSpeed * CarAngle * Time.deltaTime * changeMoveSpeed,0);
			transform.Translate(0,0,CarSpeed * Time.deltaTime * changeMoveSpeed);
				
		}
	}
}
