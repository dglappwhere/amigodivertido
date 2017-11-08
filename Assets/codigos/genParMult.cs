using UnityEngine;
using System.Collections;

public class genParMult : MonoBehaviour {

	public TextMesh numero01;
	public TextMesh numero02;
	public int rangomin;
	public int rangomax;
	public float tiempoaGen;
//	public int resultadoMult;
	void Start () {
//		genParM ();
//		Invoke ("genParM", tiempoaGen);
//		Invoke ("genbal",0.2f);
		NotificationCenter.DefaultCenter ().AddObserver (this,"undirsquals");
		NotificationCenter.DefaultCenter ().AddObserver (this,"atacarbarca");
		NotificationCenter.DefaultCenter ().AddObserver (this,"empezaragenerar");
	}
	void empezaragenerar()
	{
		genParM ();
	}
	void atacarbarca()
	{
		genParM ();
	}
	void undirsquals()
	{
		genParM ();
	}
	void genParM()
	{
		numero01.text = (Random.Range (rangomin, rangomax)).ToString();
		numero02.text ="X"+(Random.Range (rangomin, rangomax)).ToString();
		resultmult ();
	}
	void resultmult()
	{
		fnmateDatos.fmDatos.resultMultiplicacion = int.Parse(numero01.text)*int.Parse(numero02.text.Trim(new char[]{'X'}));
		NotificationCenter.DefaultCenter ().PostNotification (this,"generarTibur");
	}
}