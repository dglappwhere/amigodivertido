using UnityEngine;
using System.Collections;

public class Activandoescudo : MonoBehaviour {

	public GameObject escudo;
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "incorrectoo");
	}
	
	// Update is called once per frame
	void incorrectoo () {
		if (fnmateDatos.fmDatos.balas > 0) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "disparar");
			escudo.SetActive (true);
			Invoke ("desactivar", 2.0f);
		} else if (fnmateDatos.fmDatos.balas <= 0) {
			NotificationCenter.DefaultCenter().PostNotification(this,"perdiopartida");
		}
	}
	void desactivar()
	{
		escudo.SetActive (false);
	}
}
