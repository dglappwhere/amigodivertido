using UnityEngine;
using System.Collections;

public class presentacion : MonoBehaviour {
	void Start () {
		Invoke ("cargarescena", 5f);
	}
	void cargarescena () {
		Application.LoadLevel ("01_inicio");
	}
}