using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AccederConfig : MonoBehaviour {

	public GameObject CanvasSeguridad, blocfondo, menuniveles, config;
	public Text placecholdeeer;
	public InputField cooontra, Contraseña;
	private int contador=10;
	public AudioClip []  marco;
	void OnMouseDown () {
		AudioSource.PlayClipAtPoint (marco[0],transform.position, 1);
		CanvasSeguridad.SetActive (true);
		blocfondo.SetActive (true);
	}
	public void validadcontra()
	{
		if (Contraseña.text == "funny123") {
			AudioSource.PlayClipAtPoint (marco[0],transform.position, 1);
			cooontra.text="";
			menuniveles.SetActive (false);
			config.SetActive (true);
			blocfondo.SetActive (false);
			placecholdeeer.text="Contraseña:\nfunny123";
			CanvasSeguridad.SetActive (false);
		} else {
			AudioSource.PlayClipAtPoint (marco[1],transform.position, 1);
			if(contador<=0)
			{
				Debug.Log("salimos");
				Application.Quit();
			}
			cooontra.text="";
			if(fnmateDatos.fmDatos.lenguaje==0)
			{
				placecholdeeer.text = "Incorrecto: -" + (contador-=1).ToString()+" intentos";
			}
			else
			{
				placecholdeeer.text = "incorrect: -" + (contador-=1).ToString()+" Attempts";
			}
		}
	}
	public void cancelarAcceso()
	{
		AudioSource.PlayClipAtPoint (marco[0],transform.position, 1);
		CanvasSeguridad.SetActive (false);
		blocfondo.SetActive (false);
	}
}
