using UnityEngine;
using System.Collections;

public class SubAgua : MonoBehaviour {
	public float x,y,z;
	public float TiempoM1=2f;
	public float TiempoM2=2f;
	public GameObject fugasgObj01,fugasgObj02,fugasgObj03;
	bool t12 = true;

	void Start()
	{
		NotificationCenter.DefaultCenter ().AddObserver (this,"fugas");
	}

	void fugas()
	{
		if (fnmateDatos.fmDatos.balas >= 3) {
			fugasgObj01.SetActive (false);
			fugasgObj02.SetActive (false);
			fugasgObj03.SetActive (false);
		} else if (fnmateDatos.fmDatos.balas == 2) {
			fugasgObj01.SetActive (true);
			fugasgObj02.SetActive (false);
			fugasgObj03.SetActive (false);
		} else if (fnmateDatos.fmDatos.balas == 1) {
			fugasgObj01.SetActive (true);
			fugasgObj02.SetActive (true);
			fugasgObj03.SetActive (false);
		} else if (fnmateDatos.fmDatos.balas == 0) {
			fugasgObj01.SetActive (true);
			fugasgObj02.SetActive (true);
			fugasgObj03.SetActive (true);
		}
					
	}

	void Update () {
		if (t12) {
			TiempoM1 -= Time.deltaTime;
			if (TiempoM1 >= 0f) {
				transform.Translate (new Vector3 (x, y * Time.deltaTime, z));
			}
			if(TiempoM1<=0f)
			{
				t12=false;
				TiempoM1=2;
			}
		}
		else
		{
			TiempoM2 -= Time.deltaTime;
			if (TiempoM2 >= 0) {
				transform.Translate (new Vector3 (x, -y * Time.deltaTime, z));
			}
			if(TiempoM2<=0)
			{
				t12=true;
				TiempoM2=2f;
			}
		}
	}

}