using UnityEngine;
using System.Collections;

public class modTresFracciones : MonoBehaviour {

	public TextMesh Fracciones,Partes;
	// Use this for initialization
	public string vf;
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this,"genFrac");
	}
	void genFrac()
	{
		Fracciones.text = fnmateDatos.fmDatos.fraccionGenerada.Substring (0, 1).ToString ();
		Partes.text = fnmateDatos.fmDatos.fraccionGenerada.Substring (2).ToString ();
	}
}
