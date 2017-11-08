using UnityEngine;
using System.Collections;

public class moviendometeoritos : MonoBehaviour {
	public float Ex = 0;
	public float Ey = 0;
	public float Ez = 0;
	public int mod = 0;
	void Update () {
		if (mod == 0) {
			transform.Translate (Ex * Time.deltaTime, Ey * Time.deltaTime, Ez * Time.deltaTime);
		} else {
			transform.Translate (Ex * Time.deltaTime,0,0);
		}
	}
}
