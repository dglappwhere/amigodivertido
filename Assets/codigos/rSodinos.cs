using UnityEngine;
using System.Collections;

public class rSodinos : MonoBehaviour {
	public AudioClip [] sonidos;
	public float volumen = 0f;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this,"sonidoExp");	
		NotificationCenter.DefaultCenter ().AddObserver (this,"sonidoPuch");
		NotificationCenter.DefaultCenter ().AddObserver (this,"sonidoExp2");
		NotificationCenter.DefaultCenter ().AddObserver (this,"perdiopartida");
	}
	void perdiopartida()
	{
		AudioSource.PlayClipAtPoint (sonidos[0],transform.position, volumen);
	}
	void disparar()
	{
		AudioSource.PlayClipAtPoint (sonidos[0],transform.position, volumen);
	}

	void sonidoExp2 () {
		AudioSource.PlayClipAtPoint (sonidos[0],transform.position, volumen);
	}
	void sonidoExp () {
		AudioSource.PlayClipAtPoint (sonidos[0],transform.position, volumen);
	}
	void sonidoPuch()
	{
		AudioSource.PlayClipAtPoint (sonidos[1],transform.position, volumen);
	}
}
