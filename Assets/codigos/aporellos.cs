using UnityEngine;
using System.Collections;

public class aporellos : MonoBehaviour {
	public GameObject gOpadre;
	void OnMouseDown () {
		NotificationCenter.DefaultCenter ().PostNotification (this,"empezaragenerar");
		gOpadre.SetActive (false);
	}
}
