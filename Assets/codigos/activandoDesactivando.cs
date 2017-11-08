using UnityEngine;
using System.Collections;

public class activandoDesactivando : MonoBehaviour {

	public string nJuego;
	public bool pulsando = false;
	public float segundosP=0;
	public AudioClip []  marco;

	void OnMouseUp () {
		pulsando = false;
		if (segundosP < 0.2) {
			AudioSource.PlayClipAtPoint (marco[0],transform.position, 1);
			if (nJuego == "j2m1") {
				if (fnmateDatos.fmDatos.BMOD1J2 == 0) {
					fnmateDatos.fmDatos.BMOD1J2 = 1;
				} else {
					fnmateDatos.fmDatos.BMOD1J2 = 0;
				}
			}

			if (nJuego == "j3m1") {
				if (fnmateDatos.fmDatos.BMOD1J3 == 0) {
					fnmateDatos.fmDatos.BMOD1J3 = 1;
				} else {
					fnmateDatos.fmDatos.BMOD1J3 = 0;
				}
			}

			if (nJuego == "j4m1") {
				if (fnmateDatos.fmDatos.BMOD1J4 == 0) {
					fnmateDatos.fmDatos.BMOD1J4 = 1;
				} else {
					fnmateDatos.fmDatos.BMOD1J4 = 0;
				}
			}

			if (nJuego == "j1m2") {
				if (fnmateDatos.fmDatos.BMOD2J1 == 0) {
					fnmateDatos.fmDatos.BMOD2J1 = 1;
				} else {
					fnmateDatos.fmDatos.BMOD2J1 = 0;
				}
			}
		
			if (nJuego == "j2m2") {
				if (fnmateDatos.fmDatos.BMOD2J2 == 0) {
					fnmateDatos.fmDatos.BMOD2J2 = 1;
				} else {
					fnmateDatos.fmDatos.BMOD2J2 = 0;
				}
			}

			if (nJuego == "j1m3") {
				if (fnmateDatos.fmDatos.BMOD3J1 == 0) {
					fnmateDatos.fmDatos.BMOD3J1 = 1;
				} else {
					fnmateDatos.fmDatos.BMOD3J1 = 0;
				}
			}
			fnmateDatos.fmDatos.Guardar ();
			NotificationCenter.DefaultCenter ().PostNotification (this, "AlgoCambio");
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
