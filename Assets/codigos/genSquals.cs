using UnityEngine;
using System.Collections;

public class genSquals : MonoBehaviour {
	public GameObject [] squals;
	public float vecX,vecY,vecZ;
	private bool perdio = false;
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this,"generarTibur");
		NotificationCenter.DefaultCenter ().AddObserver(this,"perdiopartida");	
	}
	void perdiopartida()
	{
		perdio = true;
	}
	void generarTibur () {
		if (!perdio) {
			Instantiate (squals [Random.Range (0, squals.Length)], new Vector3 (vecX, vecY, vecZ), Quaternion.identity);	
		}
	}
}
