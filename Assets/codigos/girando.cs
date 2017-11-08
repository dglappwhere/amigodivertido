using UnityEngine;
using System.Collections;

public class girando : MonoBehaviour {
	public float velocidad=0;
	void Update () {
		transform.Rotate (Vector3.forward * velocidad * Time.deltaTime, Space.World);
	}
}
