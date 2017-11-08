using UnityEngine;
using System.Collections;

public class disparandocañon : MonoBehaviour {
	private Animator animacion;
	public bool disparoya = false;
	public float tiempo = 0.3f;
	public GameObject chispas;
	void Start () {
		animacion = GetComponent<Animator>();
		NotificationCenter.DefaultCenter ().AddObserver (this, "disparar");	
		chispas.SetActive (false);
	}
	
	// Update is called once per frame
	void disparar () {
		animacion.SetBool ("disparo", true);
		chispas.SetActive (true);
		disparoya = true;
	}
	void Update()
	{
		if (disparoya) {
			if(tiempo<=0)
			{
				tiempo = 0.3f;
				animacion.SetBool("disparo", false);
				chispas.SetActive (false);
				disparoya = false;
			}
			tiempo-=Time.deltaTime;
		}
	}
}
