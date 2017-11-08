using UnityEngine;
using System.Collections;

public class idiomaselect : MonoBehaviour {
	
	// Use this for initialization
	public string bandera;
	public AudioClip []  marco;
	void OnMouseDown () {
		AudioSource.PlayClipAtPoint (marco[0],transform.position, 1);
		if (bandera == "españa") {
			fnmateDatos.fmDatos.lenguaje = 0;
			NotificationCenter.DefaultCenter().PostNotification(this, "langES");
		} else if (bandera == "usa") {
			fnmateDatos.fmDatos.lenguaje = 1;
			NotificationCenter.DefaultCenter().PostNotification(this, "langEN");
		}
		fnmateDatos.fmDatos.Guardar ();
	}
}
