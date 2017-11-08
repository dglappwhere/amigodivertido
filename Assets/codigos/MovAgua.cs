using UnityEngine;
using System.Collections;

public class MovAgua : MonoBehaviour {
	public float velocidad = 0.3f;
	// Update is called once per frame
	void Update () {
		GetComponent<Renderer> ().material.mainTextureOffset = new Vector2 (Time.time * velocidad, 0);
	}
}
