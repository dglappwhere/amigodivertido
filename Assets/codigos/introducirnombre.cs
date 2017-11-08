using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class introducirnombre : MonoBehaviour {
	public GameObject menuusuario;
	public GameObject bloqueadorregistro;
	//salidas de usuario
	public Text IntTexUserName;
	public Text IntTexUserEdad;
	public GameObject intdeDatos;
	public TextMesh nombrej, edadj;
	void Start()
	{
		if (fnmateDatos.fmDatos.primeravez == 1) {
			bloqueadorregistro.SetActive(false);
			menuusuario.SetActive(true);
			nombrej.text=fnmateDatos.fmDatos.nombrejugador;
			edadj.text=fnmateDatos.fmDatos.edad.ToString();
			intdeDatos.SetActive(false);
		} else {
			menuusuario.SetActive(false);
			bloqueadorregistro.SetActive(true);
		}
	}
	public void validarnombreClic()
	{
		if (IntTexUserName.text == "" && IntTexUserEdad.text == "") {
			Debug.Log ("Introducir datos");
		} else {
			salvar();
		}
	}
	void salvar()
	{
		fnmateDatos.fmDatos.primeravez=1;
		fnmateDatos.fmDatos.nombrejugador = IntTexUserName.text.ToString();
		fnmateDatos.fmDatos.edad = int.Parse(IntTexUserEdad.text.ToString());
		fnmateDatos.fmDatos.Guardar ();
		Start ();
	}
}
