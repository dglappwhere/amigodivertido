using UnityEngine;
using System.Collections;

public class validarFraccion : MonoBehaviour {
	public GameObject picos;
	public GameObject expBrillo;
	public AudioClip destruido;
	private bool unavez = true;
	private bool volverfalso = true;
	void Start()
	{
		NotificationCenter.DefaultCenter().AddObserver(this, "correctoo");
		NotificationCenter.DefaultCenter().AddObserver(this, "incorrectoo");
		NotificationCenter.DefaultCenter().AddObserver(this, "unaVezz");
		NotificationCenter.DefaultCenter().AddObserver(this,"perdiopartida");
	}
	void perdiopartida()
	{
		correctoo ();
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "escudoA" && !unavez) {
			correctoo();
		}
		if (col.gameObject.tag == "avion" && volverfalso) {
			NotificationCenter.DefaultCenter ().PostNotification (this, "perdiopartida");
		}
	}
	void unaVezz()
	{
		unavez = false;
	}
	void incorrectoo()
	{
		volverfalso = false;
		try
		{
		picos.SetActive (true);
		}
		catch
		{
		}
	}
	void correctoo ()
	{
		AudioSource.PlayClipAtPoint (destruido, new Vector3 (0, 0, -10),0.5f);
		GetComponent<SpriteRenderer> ().enabled = false;
		expBrillo.SetActive (true);
		Destroy (picos);
		Destroy (gameObject, 2.00f);
	}
	void OnMouseDown()
	{
		if (unavez) {
			if (gameObject.name.Substring (0, 3).Replace ('_', '/') == fnmateDatos.fmDatos.fraccionGenerada) {
				fnmateDatos.fmDatos.AJ1M3+=1;
				NotificationCenter.DefaultCenter ().PostNotification (this, "junoUno",1);
				NotificationCenter.DefaultCenter ().PostNotification (this, "correctoo");
				NotificationCenter.DefaultCenter ().PostNotification (this, "VGenFrac");
			} else {
				fnmateDatos.fmDatos.EJ1M3+=1;
				NotificationCenter.DefaultCenter ().PostNotification (this, "junoUnomenos",1);
				NotificationCenter.DefaultCenter ().PostNotification (this, "incorrectoo");
				NotificationCenter.DefaultCenter ().PostNotification (this, "VGenFrac");
			}
			fnmateDatos.fmDatos.Guardar();
			NotificationCenter.DefaultCenter ().PostNotification (this, "unaVezz");
			unavez=false;
		}
	}
}