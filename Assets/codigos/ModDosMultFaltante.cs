using UnityEngine;
using System.Collections;

public class ModDosMultFaltante : MonoBehaviour {
	// VV 	  VV   AA	 LL		EEEEEE	   VV 	 VV	EEEEEEE RRRRRRRRR	 GGGGGGGG	AA
	//	VV   VV	  A  A	 LL		EE__	    VV   VV	EE──	RR	   RR	GG		   A  A
	//	 VV	VV	 AAAAAA	 LL		EE──	     VV VV	EE──	RR	 RRR	GG	  GG  AAAAAA
	//	  VV	AA	  AA LLLLLL EEEEEEE 	  VV	EEEEEEE	RR		RR    GGGGGG AA	   AA
	//
	// LL		AA		   VV	   VV	  II	DDDDDD      AA		!!
	// LL	   A  A		    VV	  VV	  II	DD	  DD   A  A		!!
	// LL	  AAAAAA	     VV VV		  II	DD	  DD  AAAAAA	
	// LLLLL AA	   AA	      VV	   IIIIIIII DDDDDD   AA    AA	!!
	public TextMesh numero01;
	public TextMesh numero02;
	public TextMesh numero03;
	public int min, max;
	public int resultado;
	public int aleat;
	public float tiempoaGen=0.0f;
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this,"undirsquals");
		NotificationCenter.DefaultCenter ().AddObserver (this,"atacarbarca");
		NotificationCenter.DefaultCenter ().AddObserver (this,"empezaragenerar");
	}
	void empezaragenerar()
	{
		mult ();
	}
	void atacarbarca()
	{
		mult ();
	}
	void undirsquals()
	{
		mult ();
	}
	void mult()
	{
		numero01.text = Random.Range (min,max).ToString();
		numero02.text =" X "+Random.Range (min,max).ToString();
		resultado = int.Parse (numero01.text) * int.Parse (numero02.text.Trim(new char[]{'X',' '}));
		numero03.text = "= "+resultado.ToString ();
		aleat = Random.Range (1,3);
		if (aleat == 1) {
			fnmateDatos.fmDatos.resultMultiplicacion = int.Parse(numero01.text);
			numero01.text = "? ";
		} else if(aleat==2) {
			fnmateDatos.fmDatos.resultMultiplicacion = int.Parse(numero02.text.Trim(new char[]{'X',' '}));
			numero02.text=" X ?";
		}
		NotificationCenter.DefaultCenter ().PostNotification (this,"generarTibur");
	}
}