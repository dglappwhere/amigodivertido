using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class estadisticas : MonoBehaviour {

	public Text nombreJ,mod1p1,mod1p2,mod2p1,mod3p1;
	void OnEnable () {
		if (fnmateDatos.fmDatos.lenguaje == 0) {
			nombreJ.text = "Estadisticas de: " + fnmateDatos.fmDatos.nombrejugador;
			//Modulo 1 datos
			mod1p1.text = "Juego 1:" + "\n" +
				" Jugados: " + fnmateDatos.fmDatos.VJJ1M1.ToString () + "\n" +
				" Aciertos: " + fnmateDatos.fmDatos.AJ1M1.ToString () + "\n" +
				" Errores: " + fnmateDatos.fmDatos.EJ1M1.ToString () + "\n" + "\n" +
				"Juego 2:" + "\n" +
				" Jugados: " + fnmateDatos.fmDatos.VJJ2M1.ToString () + "\n" +
				" Aciertos: " + fnmateDatos.fmDatos.AJ2M1.ToString () + "\n" +
				" Errores: " + fnmateDatos.fmDatos.EJ2M1.ToString ();
			mod1p2.text = "Juego 3:" + "\n" +
				" Jugados: " + fnmateDatos.fmDatos.VJJ3M1.ToString () + "\n" +
				" Aciertos: " + fnmateDatos.fmDatos.AJ3M1.ToString () + "\n" +
				" Errores: " + fnmateDatos.fmDatos.EJ3M1.ToString () + "\n" + "\n" +
				"Juego 4:" + "\n" +
				" Jugados: " + fnmateDatos.fmDatos.VJJ4M1.ToString () + "\n" +
				" Aciertos: " + fnmateDatos.fmDatos.AJ4M1.ToString () + "\n" +
				" Errores: " + fnmateDatos.fmDatos.EJ4M1.ToString ();

			//Modulo 2 datos
			mod2p1.text = "Juego 1:" + "\n" +
				" Jugados: " + fnmateDatos.fmDatos.VJJ1M2.ToString () + "\n" +
				" Aciertos: " + fnmateDatos.fmDatos.AJ1M2.ToString () + "\n" +
				" Errores: " + fnmateDatos.fmDatos.EJ1M2.ToString () + "\n" + "\n" +
				"Juego 2:" + "\n" +
				" Jugados: " + fnmateDatos.fmDatos.VJJ2M2.ToString () + "\n" +
				" Aciertos: " + fnmateDatos.fmDatos.AJ2M2.ToString () + "\n" +
				" Errores: " + fnmateDatos.fmDatos.EJ2M2.ToString ();

			//Modulo 3 datos
			mod3p1.text = "Juego 1:" + "\n" +
				" Jugados: " + fnmateDatos.fmDatos.VJJ1M3.ToString () + "\n" +
				" Aciertos: " + fnmateDatos.fmDatos.AJ1M3.ToString () + "\n" +
				" Errores: " + fnmateDatos.fmDatos.EJ1M3.ToString ();
		} else {
			nombreJ.text = "Statistics: " + fnmateDatos.fmDatos.nombrejugador;
			//Modulo 1 datos
			mod1p1.text = "Game 1:" + "\n" +
				" matches: " + fnmateDatos.fmDatos.VJJ1M1.ToString () + "\n" +
				" Correct: " + fnmateDatos.fmDatos.AJ1M1.ToString () + "\n" +
				" mistakes: " + fnmateDatos.fmDatos.EJ1M1.ToString () + "\n" + "\n" +
				"Game 2:" + "\n" +
				" matches: " + fnmateDatos.fmDatos.VJJ2M1.ToString () + "\n" +
				" Correct: " + fnmateDatos.fmDatos.AJ2M1.ToString () + "\n" +
				" mistakes: " + fnmateDatos.fmDatos.EJ2M1.ToString ();
			mod1p2.text = "Game 3:" + "\n" +
				" matches: " + fnmateDatos.fmDatos.VJJ3M1.ToString () + "\n" +
				" Correct: " + fnmateDatos.fmDatos.AJ3M1.ToString () + "\n" +
				" mistakes: " + fnmateDatos.fmDatos.EJ3M1.ToString () + "\n" + "\n" +
				"Game 4:" + "\n" +
				" matches: " + fnmateDatos.fmDatos.VJJ4M1.ToString () + "\n" +
				" Correct: " + fnmateDatos.fmDatos.AJ4M1.ToString () + "\n" +
				" mistakes: " + fnmateDatos.fmDatos.EJ4M1.ToString ();
			
			//Modulo 2 datos
			mod2p1.text = "Game 1:" + "\n" +
				" matches: " + fnmateDatos.fmDatos.VJJ1M2.ToString () + "\n" +
				" Correct: " + fnmateDatos.fmDatos.AJ1M2.ToString () + "\n" +
				" mistakes: " + fnmateDatos.fmDatos.EJ1M2.ToString () + "\n" + "\n" +
				"Game 2:" + "\n" +
				" matches: " + fnmateDatos.fmDatos.VJJ2M2.ToString () + "\n" +
				" Correct: " + fnmateDatos.fmDatos.AJ2M2.ToString () + "\n" +
				" mistakes: " + fnmateDatos.fmDatos.EJ2M2.ToString ();
			
			//Modulo 3 datos
			mod3p1.text = "Game 1:" + "\n" +
				" matches: " + fnmateDatos.fmDatos.VJJ1M3.ToString () + "\n" +
				" Correct: " + fnmateDatos.fmDatos.AJ1M3.ToString () + "\n" +
				" mistakes: " + fnmateDatos.fmDatos.EJ1M3.ToString ();
		}
	}
}