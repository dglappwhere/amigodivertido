using UnityEngine;
using System.Collections;

public class contextual : MonoBehaviour {

	public GameObject menuContext,GOADesact;
	public string hacer;
	public bool pulsando = false;
	public float segundosP=0.0f;
	public AudioClip []  marco;
	void OnMouseUp () {
		pulsando = false;
		if (segundosP < 0.2) {
			if (hacer == "abrir")
			{
				AudioSource.PlayClipAtPoint (marco[0],transform.position, 1);
				menuContext.SetActive (true);
				GOADesact.SetActive(false);
			}
			else
			{
				AudioSource.PlayClipAtPoint (marco[0],transform.position, 1);
				menuContext.SetActive (false);
				GOADesact.SetActive(true);
			}
		}
		segundosP = 0.0f;
	}
	void OnMouseDown()
	{
		pulsando = true;
	}
	void Update()
	{
		if (pulsando) {
			segundosP+=Time.deltaTime;
		}
	}
}