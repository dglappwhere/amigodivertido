using UnityEngine;
using System.Collections;

public class moviendoedificioesdefondo : MonoBehaviour {
	private float tiempo = 3f;
	public bool alternando = true;
	private int valor = 1;
	// Update is called once per frame
	void Update () {
		if (alternando) {
			transform.Translate (-0.003f, 0, 0);
		} else {
			transform.Translate (0.003f, 0, 0);
		}
		if (tiempo <= 0) {
			cambiarbool();
			tiempo = 3f;
		}
		tiempo -= Time.deltaTime;
	}
	void cambiarbool()
	{
		if (valor == 1) {
			alternando = false;
			valor = 0;
		} else {
			alternando = true;
			valor=1;
		}
	}
}