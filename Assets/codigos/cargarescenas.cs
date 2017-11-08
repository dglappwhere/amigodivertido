using UnityEngine;
using System.Collections;

public class cargarescenas : MonoBehaviour {

	public string nombreescena="";
	void OnMouseDown () {
		if (nombreescena == "02_Mod1_juno") {
			fnmateDatos.fmDatos.VJJ1M1 += 1;
		} else if (nombreescena == "03_Mod1_jdos") {
			fnmateDatos.fmDatos.VJJ2M1 += 1;
		} else if (nombreescena == "04_Mod1_jtres") {
			fnmateDatos.fmDatos.VJJ3M1 += 1;
		} else if (nombreescena == "05_Mod1_jcuatro") {
			fnmateDatos.fmDatos.VJJ4M1 += 1;
		} else if (nombreescena == "06_Mod2_juno") {
			fnmateDatos.fmDatos.VJJ1M2 += 1;
		} else if (nombreescena == "07_Mod2_jdos") {
			fnmateDatos.fmDatos.VJJ2M2 += 1;
		} else if (nombreescena == "08_Mod3_juno") {
			fnmateDatos.fmDatos.VJJ1M3 += 1;
		} else if (nombreescena == "salir") {
			Application.Quit ();
		}
		fnmateDatos.fmDatos.balas = 3;
		fnmateDatos.fmDatos.Guardar ();
		Application.LoadLevel (nombreescena);
	}
}
