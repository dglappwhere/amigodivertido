using UnityEngine;
using System.Collections;

public class jDosSumaRestaMayor : MonoBehaviour {
	//Numeros del primer par... B|
	public TextMesh P1num01;
	public TextMesh P1num02;
	//numeros del segundo par
	public TextMesh P2num01;
	public TextMesh P2num02;
	//sumas
	public int sumaP01;
	public int sumaP02;
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
		//suma de cada par

	}
	void OnMouseDown()
	{
		sumaP01 = int.Parse (P1num01.text) + int.Parse (P1num02.text);
		sumaP02 = int.Parse (P2num01.text) + int.Parse (P2num02.text);
		compararvalidar ();
	}
	void compararvalidar()
	{
		if (fnmateDatos.fmDatos.mayor) {
			gameObject.GetComponent < Collider >().enabled=false;
			if (sumaP01 > sumaP02) {
				NotificationCenter.DefaultCenter ().PostNotification (this, "clicincoll");
				NotificationCenter.DefaultCenter ().PostNotification (this, "junoUno", puntoitem);
				NotificationCenter.DefaultCenter ().PostNotification (this, "sonidoExp");
				empezar = true;
				explocion01.SetActive (true);
				explocion02.SetActive (true);
				meteorito01.SetActive (false);
				meteorito02.SetActive (false);
				flama01.SetActive (false);
				flama02.SetActive (false);
				if(Application.loadedLevelName=="03_Mod1_jdos")
				{
					fnmateDatos.fmDatos.AJ2M1+=1;
				}
				else if (Application.loadedLevelName=="04_Mod1_jtres")
				{
					fnmateDatos.fmDatos.AJ3M1+=1;
				}
				else if (Application.loadedLevelName=="05_Mod1_jcuatro")
				{
					fnmateDatos.fmDatos.AJ4M1+=1;
				}
				destruir ();
			} 
			else if (sumaP01 == sumaP02) {
				NotificationCenter.DefaultCenter ().PostNotification (this, "clicincoll");
				NotificationCenter.DefaultCenter ().PostNotification (this, "sonidoExp");
				if(Application.loadedLevelName=="03_Mod1_jdos")
				{
					fnmateDatos.fmDatos.AJ2M1+=1;
				}
				else if (Application.loadedLevelName=="04_Mod1_jtres")
				{
					fnmateDatos.fmDatos.AJ3M1+=1;
				}
				else if (Application.loadedLevelName=="05_Mod1_jcuatro")
				{
					fnmateDatos.fmDatos.AJ4M1+=1;
				}
				empezar = true;
				explocion01.SetActive (true);
				explocion02.SetActive (true);
				meteorito01.SetActive (false);
				meteorito02.SetActive (false);
				flama01.SetActive (false);
				flama02.SetActive (false);
				destruir ();
			} 
			else {
				NotificationCenter.DefaultCenter ().PostNotification (this, "junoUnomenos", puntoitem);
				NotificationCenter.DefaultCenter ().PostNotification (this, "sonidoPuch");
				texto01.SetActive (false);
				texto02.SetActive (false);
				if(Application.loadedLevelName=="03_Mod1_jdos")
				{
					fnmateDatos.fmDatos.EJ2M1+=1;
				}
				else if (Application.loadedLevelName=="04_Mod1_jtres")
				{
					fnmateDatos.fmDatos.EJ3M1+=1;
				}
				else if (Application.loadedLevelName=="05_Mod1_jcuatro")
				{
					fnmateDatos.fmDatos.EJ4M1+=1;
				}
			}
		} else {
			gameObject.GetComponent < Collider >().enabled=false;
			if (sumaP01 < sumaP02) {
				NotificationCenter.DefaultCenter ().PostNotification (this, "clicincoll");
				NotificationCenter.DefaultCenter ().PostNotification (this, "junoUno", puntoitem);
				NotificationCenter.DefaultCenter ().PostNotification (this, "sonidoExp");
				empezar = true;
				explocion01.SetActive (true);
				explocion02.SetActive (true);
				meteorito01.SetActive (false);
				meteorito02.SetActive (false);
				flama01.SetActive (false);
				flama02.SetActive (false);
				if(Application.loadedLevelName=="03_Mod1_jdos")
				{
					fnmateDatos.fmDatos.AJ2M1+=1;
				}
				else if (Application.loadedLevelName=="04_Mod1_jtres")
				{
					fnmateDatos.fmDatos.AJ3M1+=1;
				}
				else if (Application.loadedLevelName=="05_Mod1_jcuatro")
				{
					fnmateDatos.fmDatos.AJ4M1+=1;
				}
				destruir ();
			} else if (sumaP01 == sumaP02) {
				NotificationCenter.DefaultCenter ().PostNotification (this, "clicincoll");
				NotificationCenter.DefaultCenter ().PostNotification (this, "sonidoExp");
				if(Application.loadedLevelName=="03_Mod1_jdos")
				{
					fnmateDatos.fmDatos.AJ2M1+=1;
				}
				else if (Application.loadedLevelName=="04_Mod1_jtres")
				{
					fnmateDatos.fmDatos.AJ3M1+=1;
				}
				else if (Application.loadedLevelName=="05_Mod1_jcuatro")
				{
					fnmateDatos.fmDatos.AJ4M1+=1;
				}
				NotificationCenter.DefaultCenter ().PostNotification (this, "sonidoExp");
				empezar = true;
				explocion01.SetActive (true);
				explocion02.SetActive (true);
				meteorito01.SetActive (false);
				meteorito02.SetActive (false);
				flama01.SetActive (false);
				flama02.SetActive (false);
				destruir ();
			} else {
				NotificationCenter.DefaultCenter ().PostNotification (this, "junoUnomenos", puntoitem);
				NotificationCenter.DefaultCenter ().PostNotification (this, "sonidoPuch");
				texto01.SetActive (false);
				texto02.SetActive (false);
				if(Application.loadedLevelName=="03_Mod1_jdos")
				{
					fnmateDatos.fmDatos.EJ2M1+=1;
				}
				else if (Application.loadedLevelName=="04_Mod1_jtres")
				{
					fnmateDatos.fmDatos.EJ3M1+=1;
				}
				else if (Application.loadedLevelName=="05_Mod1_jcuatro")
				{
					fnmateDatos.fmDatos.EJ4M1+=1;
				}
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
