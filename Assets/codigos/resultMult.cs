using UnityEngine;
using System.Collections;

public class resultMult : MonoBehaviour {
	public TextMesh numero;
	public GameObject tBSqls1;
	public GameObject tBSqls2;
	bool notoco=true;
	void OnMouseDown () {
		if (notoco) {
			if (int.Parse (numero.text) == fnmateDatos.fmDatos.resultMultiplicacion) {
				if(Application.loadedLevelName=="06_Mod2_juno")
				{
					fnmateDatos.fmDatos.AJ1M2+=1;
				}
				else
				{
					fnmateDatos.fmDatos.AJ2M2+=1;
				}
				tBSqls1.GetComponent<Rigidbody2D> ().isKinematic = true;
				tBSqls2.GetComponent<Rigidbody2D> ().isKinematic = true;
				NotificationCenter.DefaultCenter().PostNotification(this,"undirsquals");
				NotificationCenter.DefaultCenter().PostNotification(this,"junoUno",1);
				NotificationCenter.DefaultCenter ().PostNotification (this, "sonidoPuch");
			} else {
				if(fnmateDatos.fmDatos.balas<=0)
				{
					if(Application.loadedLevelName=="06_Mod2_juno")
					{
						fnmateDatos.fmDatos.EJ1M2+=1;
					}
					else
					{
						fnmateDatos.fmDatos.EJ2M2+=1;
					}
					NotificationCenter.DefaultCenter().PostNotification(this,"perdiopartida");
					NotificationCenter.DefaultCenter().PostNotification(this,"undirsquals");
					Debug.Log("perdio partida");
				}
				else
				{
					if(Application.loadedLevelName=="06_Mod2_juno")
					{
						fnmateDatos.fmDatos.EJ1M2+=1;
					}
					else
					{
						fnmateDatos.fmDatos.EJ2M2+=1;
					}
					NotificationCenter.DefaultCenter().PostNotification(this,"atacarbarca");
					NotificationCenter.DefaultCenter().PostNotification(this,"junoUnomenos",1);
					NotificationCenter.DefaultCenter ().PostNotification (this,"disparar");
				}
				NotificationCenter.DefaultCenter ().PostNotification (this, "sonidoExp");
			}
			fnmateDatos.fmDatos.Guardar();
			notoco=false;
		}
	}
}
