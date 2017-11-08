using UnityEngine;
using System.Collections;

public class ModosMult : MonoBehaviour {
	public TextMesh numero01;
	public TextMesh numero02;
	private int forma;
	void Start()
	{
		NotificationCenter.DefaultCenter ().AddObserver (this,"undirsquals");
//		if (Application.loadedLevelName == "06_Mod2_juno") {
			forma = Random.Range (1, 3);
			if (forma == 1) {
				numero01.text = fnmateDatos.fmDatos.resultMultiplicacion.ToString ();
				numero02.text = Random.Range (int.Parse(numero01.text),
				                              int.Parse(numero01.text)+
				                              Random.Range(int.Parse(numero01.text),
				             int.Parse(numero01.text)+20)).ToString ();
			} else {
				numero02.text = fnmateDatos.fmDatos.resultMultiplicacion.ToString ();
				numero01.text = Random.Range (int.Parse(numero02.text),
				                              int.Parse(numero02.text)+
				                              Random.Range(int.Parse(numero02.text),
				             int.Parse(numero02.text)+20)).ToString ();
			}
//		}
//		else if (Application.loadedLevelName == "07_Mod2_jdos") {
//			forma = Random.Range (1, 3);
//			if (forma == 1) {
//				numero01.text = fnmateDatos.fmDatos.resultMultiplicacion.ToString ();
//				numero02.text = Random.Range (int.Parse(numero01.text),
//				                              int.Parse(numero01.text)+
//				                              Random.Range(int.Parse(numero01.text),
//				             int.Parse(numero01.text)+20)).ToString ();
//			} else {
//				numero02.text = fnmateDatos.fmDatos.resultMultiplicacion.ToString ();
//				numero01.text = Random.Range (int.Parse(numero02.text),
//				                              int.Parse(numero02.text)+
//				                              Random.Range(int.Parse(numero02.text),
//				             int.Parse(numero02.text)+20)).ToString ();
//			}
//		}
	}
	void undirsquals()
	{
		GetComponent<Rigidbody2D> ().gravityScale = 1;
	}

//	void OnMouseDown()
//	{
//
//	}
}