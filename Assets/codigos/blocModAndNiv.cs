using UnityEngine;
using System.Collections;

public class blocModAndNiv : MonoBehaviour {

	//BLOQUEADORES
	public GameObject M1J2,M1J3,M1J4,M2J1,M2J2,M3J1;
	// Use this for initialization
	void Start()
	{
		NotificationCenter.DefaultCenter ().AddObserver (this,"AlgoCambio");
	}
	void AlgoCambio()
	{
		OnEnable ();
	}
	void OnEnable()
	{
		if (fnmateDatos.fmDatos.BMOD1J2 == 0) {
			M1J2.SetActive (true);
		} else {
			M1J2.SetActive(false);
		}

		if (fnmateDatos.fmDatos.BMOD1J3 == 0) {
			M1J3.SetActive (true);
		} else {
			M1J3.SetActive(false);
		}

		if (fnmateDatos.fmDatos.BMOD1J4 == 0) {
			M1J4.SetActive (true);
		} else {
			M1J4.SetActive(false);
		}

		if (fnmateDatos.fmDatos.BMOD2J1 == 0) {
			M2J1.SetActive (true);
		} else {
			M2J1.SetActive(false);
		}
		if (fnmateDatos.fmDatos.BMOD2J2 == 0) {
			M2J2.SetActive (true);
		} else {
			M2J2.SetActive(false);
		}

		if (fnmateDatos.fmDatos.BMOD3J1 == 0) {
			M3J1.SetActive (true);
		} else {
			M3J1.SetActive(false);
		}
	}
}
