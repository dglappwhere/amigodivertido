using UnityEngine;
using System.Collections;

public class datosalperder : MonoBehaviour {

	public TextMesh TmAciertos;
	public TextMesh TmErrores;
	public TextMesh aci;
	public TextMesh err;
	void Update()
	{
		aci.text = TmAciertos.text;
		err.text = TmErrores.text;
	}
}
