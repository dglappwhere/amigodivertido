using UnityEngine;
using System.Collections;

public class junoelmayordelosnumeros : MonoBehaviour {

	//variables para obtener el valor del texto y compararlos
	public TextMesh valor01;
	public TextMesh valor02;
	//Variables de tipo GameObject para desactivar.
	public GameObject explocion01;
	public GameObject explocion02;
	public GameObject meteorito01;
	public GameObject meteorito02;
	public GameObject texto01;
	public GameObject texto02;
	public GameObject flama01;
	public GameObject flama02;
	public GameObject gOPadre;
	//Temporizador para desctivar el gameobject que contiene el valor
	public float tiempo = 0;
	//Variable para activar cuenta regresiva
	private bool empezar = false;
	//puntos
	public int puntoitem = 0;
	public int puntoitemmenos = 0;
	void Start()
	{
		NotificationCenter.DefaultCenter ().AddObserver(this,"perdiopartida");
	}
	void OnMouseDown()
	{
		if (fnmateDatos.fmDatos.mayor) {
			gameObject.GetComponent < Collider >().enabled=false;
			if (int.Parse (valor01.text) > int.Parse (valor02.text)) {
				NotificationCenter.DefaultCenter ().PostNotification (this, "clicincoll");
				//gameObject.GetComponent < Collider >().enabled=false;
				empezar = true;
				explocion01.SetActive (true);
				explocion02.SetActive (true);
				meteorito01.SetActive (false);
				meteorito02.SetActive (false);
				flama01.SetActive (false);
				flama02.SetActive (false);
				if (Application.loadedLevelName == "02_Mod1_juno") {
					fnmateDatos.fmDatos.AJ1M1 += 1;
				} else {
					fnmateDatos.fmDatos.AJ4M1 += 1;
				}
				NotificationCenter.DefaultCenter ().PostNotification (this, "junoUno", puntoitem);
				NotificationCenter.DefaultCenter ().PostNotification (this, "sonidoExp");
				destruir ();
			} else if (int.Parse (valor01.text) == int.Parse (valor02.text)) {
				NotificationCenter.DefaultCenter ().PostNotification (this, "clicincoll");
				//gameObject.GetComponent < Collider >().enabled=false;
				empezar = true;
				explocion01.SetActive (true);
				explocion02.SetActive (true);
				meteorito01.SetActive (false);
				meteorito02.SetActive (false);
				flama01.SetActive (false);
				flama02.SetActive (false);
				NotificationCenter.DefaultCenter ().PostNotification (this, "sonidoExp");
				destruir ();
			} else {
				texto01.SetActive (false);
				texto02.SetActive (false);
				if (Application.loadedLevelName == "02_Mod1_juno") {
					fnmateDatos.fmDatos.EJ1M1 += 1;
				} else {
					fnmateDatos.fmDatos.EJ4M1 += 1;
				}
				NotificationCenter.DefaultCenter ().PostNotification (this, "junoUnomenos", puntoitem);
				NotificationCenter.DefaultCenter ().PostNotification (this, "sonidoPuch");
			}
		}
		else {
			gameObject.GetComponent < Collider >().enabled=false;
			if (int.Parse (valor01.text) < int.Parse (valor02.text)) {
				NotificationCenter.DefaultCenter ().PostNotification (this, "clicincoll");
			//	gameObject.GetComponent < Collider >().enabled=false;
				empezar = true;
				explocion01.SetActive (true);
				explocion02.SetActive (true);
				meteorito01.SetActive (false);
				meteorito02.SetActive (false);
				flama01.SetActive (false);
				flama02.SetActive (false);
				if (Application.loadedLevelName == "02_Mod1_juno") {
					fnmateDatos.fmDatos.AJ1M1 += 1;
				} else {
					fnmateDatos.fmDatos.AJ4M1 += 1;
				}
				NotificationCenter.DefaultCenter ().PostNotification (this, "junoUno", puntoitem);
				NotificationCenter.DefaultCenter ().PostNotification (this, "sonidoExp");
				destruir ();
			} else if (int.Parse (valor01.text) == int.Parse (valor02.text)) {
				NotificationCenter.DefaultCenter ().PostNotification (this, "clicincoll");
				//gameObject.GetComponent < Collider >().enabled=false;
				empezar = true;
				explocion01.SetActive (true);
				explocion02.SetActive (true);
				meteorito01.SetActive (false);
				meteorito02.SetActive (false);
				flama01.SetActive (false);
				flama02.SetActive (false);
				NotificationCenter.DefaultCenter ().PostNotification (this, "sonidoExp");
				destruir ();
				Debug.Log ("iguales");
			} else {
				texto01.SetActive (false);
				texto02.SetActive (false);
				if (Application.loadedLevelName == "02_Mod1_juno") {
					fnmateDatos.fmDatos.EJ1M1 += 1;
				} else {
					fnmateDatos.fmDatos.EJ4M1 += 1;
				}
				NotificationCenter.DefaultCenter ().PostNotification (this, "junoUnomenos", puntoitem);
				NotificationCenter.DefaultCenter ().PostNotification (this, "sonidoPuch");
			}
		}
		fnmateDatos.fmDatos.Guardar ();
	}
	void perdiopartida()
	{
		explocion01.SetActive (true);
		explocion02.SetActive (true);
		meteorito01.SetActive (false);
		meteorito02.SetActive (false);
		flama01.SetActive (false);
		flama02.SetActive (false);
		destruir ();
		empezar=true;
	}
	void destruir()
	{
		Destroy (gOPadre, 0.5f);
	}
	void Update()
	{
		if (empezar) {
			tiempo-=Time.deltaTime;
			if (tiempo <= 0) {
				texto01.SetActive(false);
				texto02.SetActive(false);
			}
		}
	}
}
