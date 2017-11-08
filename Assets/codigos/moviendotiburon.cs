using UnityEngine;
using System.Collections;

public class moviendotiburon : MonoBehaviour {
	public GameObject numero;
	public float velocidad = 0.1f;
	public float vgiracion = 0.3f;
	public bool derecha = true;
	public bool ABM = true;
	public float cont1=0.2f, cont2=0.2f;
	public int vContradictorio=0;
	//Varaibles de ataque
	public Transform objetivo;
	public float velocidadA = 0f;
	public Transform seguir;
	public Vector2 direc;
	private bool atacar = false;
	private bool dSeguir = true;
	//otras variables
	public GameObject tibAlt;
	public GameObject tibAlt2;
	public int izquierda=0;
	private bool abusado = true;
	void Awake()
	{
		objetivo = transform;
	}
	void Start()
	{
		seguir = GameObject.FindWithTag ("boote").transform;
		NotificationCenter.DefaultCenter ().AddObserver (this, "atacarbarca");
		NotificationCenter.DefaultCenter ().AddObserver (this,"sonidoPuch");
		NotificationCenter.DefaultCenter ().AddObserver (this,"sonidoExp");
	}
	void sonidoExp()
	{
		GetComponent<AudioSource> ().Stop ();
	}
	void sonidoPuch()
	{
		GetComponent<AudioSource> ().Stop ();
	}
	void atacarbarca()
	{
		atacar = true;
	}
	void Update () {
		if (!atacar) {
			if (derecha) {
				transform.Translate (velocidad * Time.deltaTime, 0, 0);
				transform.localScale = new Vector3 (1, 1, 1);
			} else {
				transform.Translate (velocidad * -Time.deltaTime, 0, 0);
				transform.localScale = new Vector3 (-1, 1, 1);
			}
			if (ABM) {
				transform.Rotate (Vector3.forward * vgiracion * Time.deltaTime, Space.World);
				cont1 -= Time.deltaTime;
				cont2 = 0.2f;
			} else {
				transform.Rotate (Vector3.forward * vgiracion * -Time.deltaTime, Space.World);
				cont2 -= Time.deltaTime;
				cont1 = 0.2f;
			}
			if (cont1 <= 0) {
				ABM = false;
			}
			if (cont2 <= 0) {
				ABM = true;
			}
		}
		if (abusado) {
			if (atacar) {
				if (derecha && izquierda == 2) {
					transform.localScale = new Vector3 (-1, 1, 1);
				} else if (!derecha && izquierda == 1) {
					transform.localScale = new Vector3 (1, 1, 1);
				} else if (derecha && izquierda == 0) {
					transform.localScale = new Vector3 (1, 1, 1);
				} else if (!derecha && izquierda == 0) {
					transform.localScale = new Vector3 (-1, 1, 1);
				}
				abusado=false;
			}
		}
		if (!abusado && dSeguir) {
			direc = (seguir.position - objetivo.position);
			objetivo.GetComponent<Rigidbody2D> ().AddForce (direc * velocidadA);
		}
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "CDTd") {
			vContradictorio = 1;
			derecha = false;
		} else if (col.gameObject.tag == "CDTi") {
			derecha = true;
		} else if (col.gameObject.tag == "dIzq") {
			izquierda = 1;
		} else if (col.gameObject.tag == "dDerech") {
			izquierda=2;
		}
		else if (col.gameObject.tag == "boote") {
//			NotificationCenter.DefaultCenter ().PostNotification (this,"disparar");
//			if(fnmateDatos.fmDatos.balas<=0)
//			{
//				NotificationCenter.DefaultCenter().PostNotification(this,"perdiopartida");
//				NotificationCenter.DefaultCenter().PostNotification(this,"undirsquals");
//				Debug.Log("perdio partida");
//			}
			NotificationCenter.DefaultCenter().PostNotification(this,"fugas");
			dSeguir = false;
		} else if (col.gameObject.tag == "GenAndDel") {
//			NotificationCenter.DefaultCenter ().PostNotification (this,"generarTibur");
			Destroy(tibAlt);
			Destroy(tibAlt2);
		}
		if (derecha) {
			numero.transform.localScale = new Vector3 (1, 1, 1);
		} else {
			numero.transform.localScale = new Vector3(-1,1,1);
		}
	}
}