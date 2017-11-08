using UnityEngine;
using System.Collections;
public class generar : MonoBehaviour {
	public GameObject [] gObj;
	public float tiempoMin = 0f;
	public float tiempoMax = 0f;
	public float ejeXMin = 0f;
	public float ejeXMax = 0f;
	public float ejeYMin = 0f;
	public float ejeYMax = 0f;
	public float ejeZ = 0f;
	private bool generargOb = true;
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this,"empezaragenerar");
		NotificationCenter.DefaultCenter ().AddObserver (this,"perdiopartida");
	}
	void empezaragenerar()
	{
		genObject ();

	}
	void perdiopartida()
	{
		generargOb = false;
	}
	// Update is called once per frame
	void genObject () {
		if (generargOb) {
			Instantiate (gObj[Random.Range(0,gObj.Length)], new Vector3(Random.Range(ejeXMin,ejeXMax),
			                                                            Random.Range(ejeYMin,ejeYMax),
			                                                            ejeZ), Quaternion.identity);
			Invoke ("genObject", Random.Range(tiempoMin,tiempoMax));
			NotificationCenter.DefaultCenter().PostNotification(this,"darOrden");
		}
	}
}
