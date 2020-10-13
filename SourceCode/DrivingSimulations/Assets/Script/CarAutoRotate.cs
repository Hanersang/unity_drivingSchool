using UnityEngine;
using System.Collections;

public class CarAutoRotate : MonoBehaviour {

	public float rotateSpeed = 5.0f;

	void Update () {
		transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
	}
}
