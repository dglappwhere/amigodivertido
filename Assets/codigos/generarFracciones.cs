using UnityEngine;
using System.Collections;

public class generarFracciones : MonoBehaviour {

	public GameObject [] fracciones;
	//Posicion de la primera fraccion
	public float ejeXF01=0.0f;
	public float ejeYF01=0.0f;
	//Posicion de la segunda fraccion
	public float ejeXF02=0.0f;
	public float ejeYF02=0.0f;
	//Posicion de la tercera fraccion
	public float ejeXF03=0.0f;
	public float ejeYF03=0.0f;
	//Posicion general de z en todas las fracciones
	public float ejeZG = 0.0f;

	public int vAleat;

	public bool empezar=false;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "VGenFrac");
		NotificationCenter.DefaultCenter ().AddObserver (this,"empezaragenerar");
		NotificationCenter.DefaultCenter().AddObserver(this,"perdiopartida");
		genFrac ();
	}
	void perdiopartida()
	{
		empezar = false;
	}
	void empezaragenerar()
	{
		empezar = true;
		genFrac ();
	}
	void VGenFrac()
	{
		genFrac ();
	}
	void genFrac()
	{
		if (empezar) {
			vAleat = Random.Range (1, 3);
			int FAMAnd = Random.Range (0, fracciones.Length);
			if (vAleat == 1) {
				//generamos la fraccion correcta en el sprite de arriba.
				Instantiate (fracciones [FAMAnd], new Vector3 (ejeXF01, ejeYF01, ejeZG), Quaternion.identity);
				fnmateDatos.fmDatos.fraccionGenerada = fracciones [FAMAnd].name.Replace ('_', '/').Trim (new char[]{'v'});
				Instantiate (fracciones [Random.Range (0, fracciones.Length)], new Vector3 (ejeXF02, ejeYF02, ejeZG), Quaternion.identity);
				Instantiate (fracciones [Random.Range (0, fracciones.Length)], new Vector3 (ejeXF03, ejeYF03, ejeZG), Quaternion.identity);
			} else if (vAleat == 2) {
				//generamos la fraccion correcta en el sprite de en medio.
				Instantiate (fracciones [Random.Range (0, fracciones.Length)], new Vector3 (ejeXF01, ejeYF01, ejeZG), Quaternion.identity);
				Instantiate (fracciones [FAMAnd], new Vector3 (ejeXF02, ejeYF02, ejeZG), Quaternion.identity);
				fnmateDatos.fmDatos.fraccionGenerada = fracciones [FAMAnd].name.Replace ('_', '/').Trim (new char[]{'v'});
				Instantiate (fracciones [Random.Range (0, fracciones.Length)], new Vector3 (ejeXF03, ejeYF03, ejeZG), Quaternion.identity);
			} else if (vAleat == 3) {
				//generamos la fraccion correcta en el sprite de abajo
				Instantiate (fracciones [Random.Range (0, fracciones.Length)], new Vector3 (ejeXF01, ejeYF01, ejeZG), Quaternion.identity);
				Instantiate (fracciones [Random.Range (0, fracciones.Length)], new Vector3 (ejeXF02, ejeYF02, ejeZG), Quaternion.identity);
				Instantiate (fracciones [FAMAnd], new Vector3 (ejeXF03, ejeYF03, ejeZG), Quaternion.identity);
				fnmateDatos.fmDatos.fraccionGenerada = fracciones [FAMAnd].name.Replace ('_', '/').Trim (new char[]{'v'});

			}
			fnmateDatos.fmDatos.Guardar ();
			NotificationCenter.DefaultCenter ().PostNotification (this, "genFrac");
		}
	}
}
