using UnityEngine;
using System.Collections;

public class detectandobarrera : MonoBehaviour {
	private bool unavez = true;
	public TextMesh valor01;
	public TextMesh valor02;
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
	private bool empezar = false;
	public float tiempo = 0;
	void Start()
	{
		NotificationCenter.DefaultCenter ().AddObserver (this, "clicincoll");
	}
	void clicincoll()
	{
		gameObject.GetComponent<CircleCollider2D>().enabled = false;
	}
	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag == "casita") {
			if(unavez)
			{
				if(fnmateDatos.fmDatos.balas>0)
				{
					NotificationCenter.DefaultCenter().PostNotification(this,"disparar");
					explocion01.SetActive (true);
					explocion02.SetActive (true);
					meteorito01.SetActive (false);
					meteorito02.SetActive (false);
					flama01.SetActive (false);
					flama02.SetActive (false);
					empezar=true;
					unavez=false;
				}
				else if(fnmateDatos.fmDatos.balas<=0)
				{
					explocion01.SetActive (true);
					explocion02.SetActive (true);
					meteorito01.SetActive (false);
					meteorito02.SetActive (false);
					flama01.SetActive (false);
					flama02.SetActive (false);
					empezar=true;
					NotificationCenter.DefaultCenter().PostNotification(this,"perdiopartida");
				}
			}
		}
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
