using UnityEngine;
using System.Collections;

public class seleccionitem : MonoBehaviour {
	public AudioClip []  marco;
	void OnMouseDown () {
		AudioSource.PlayClipAtPoint (marco[0],transform.position, 1);
	}
}
