using UnityEngine;
using System.Collections;

public class puntuacionJ : MonoBehaviour {

	public TextMesh tmPuntuacionP;
	public TextMesh tmPuntuacionN;
	public TextMesh tmVidas;
	public int puntuacionP=0;
	public int puntuacionN=0;
	public GameObject goPerdiste;
	public static puntuacionJ pJ;
	//private int vidasT;
	//public int vidas = 3;
	void Start () {	
		NotificationCenter.DefaultCenter ().AddObserver (this,"perdiopartida");
		NotificationCenter.DefaultCenter ().AddObserver (this,"junoUno");
		NotificationCenter.DefaultCenter ().AddObserver (this,"junoUnomenos");
		NotificationCenter.DefaultCenter ().AddObserver (this,"disparar");
		NotificationCenter.DefaultCenter ().AddObserver (this,"gBala");
		tmVidas.text = fnmateDatos.fmDatos.balas.ToString ();
	}
	void gBala()
	{
		fnmateDatos.fmDatos.balas += 1;
		actuazalizar ();
	}
	void perdiopartida()
	{
		goPerdiste.SetActive (true);
	}
	void disparar()
	{
		fnmateDatos.fmDatos.balas -= 1;
		actuazalizar ();
	}
	void junoUno(Notification not)
	{
		int valor = (int)not.data;
		puntuacionP += valor;
		actuazalizar ();
	}
	void junoUnomenos(Notification not)
	{
		int valor = (int)not.data;
		puntuacionN += valor;
		actuazalizar ();
	}
	// Update is called once per frame
	void actuazalizar () {
		tmPuntuacionP.text = puntuacionP.ToString ();
		tmPuntuacionN.text = puntuacionN.ToString ();
		tmVidas.text = fnmateDatos.fmDatos.balas.ToString ();
	}
}
