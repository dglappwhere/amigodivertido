using UnityEngine;
using System.Collections;

public class orden : MonoBehaviour {
	public TextMesh txtOrden;
	//1 = Menor, 2 = Mayor
	public int _orden;
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this,"darOrden");
	}
	void darOrden()
	{
		if (fnmateDatos.fmDatos.lenguaje == 0) {
			_orden = Random.Range (1, 3);
			if (_orden == 1) {
				txtOrden.text = "Menor";
				fnmateDatos.fmDatos.mayor = false;
			} else {
				txtOrden.text = "Mayor";
				fnmateDatos.fmDatos.mayor = true;
			}
		} else {
			_orden = Random.Range (1,3);
			if (_orden == 1) {
				txtOrden.text = "Smaller";
				fnmateDatos.fmDatos.mayor=false;
			}
			else
			{
				txtOrden.text = "Higher";
				fnmateDatos.fmDatos.mayor=true;
			}
		}
	}
}
