using UnityEngine;
using System.Collections;

public class CronometroTiburones : MonoBehaviour {

	public float tiempoADar = 10f;
	private float _tiempoADar = 10f;
	public TextMesh tiempo;
	bool empezo=false;
	void Start () {
		 _tiempoADar = tiempoADar;
		NotificationCenter.DefaultCenter ().AddObserver (this,"undirsquals");
		NotificationCenter.DefaultCenter ().AddObserver (this,"atacarbarca");
		NotificationCenter.DefaultCenter ().AddObserver (this,"empezaragenerar");
		NotificationCenter.DefaultCenter ().AddObserver (this,"perdiopartida");
	}
	void perdiopartida()
	{
		empezo = false;
	}
	void empezaragenerar()
	{
		empezo = true;
	}
	void atacarbarca()
	{
		tiempoADar=_tiempoADar;
	}
	void undirsquals()
	{
		tiempoADar=_tiempoADar;
	}
	void Update () {
		if (empezo) {
			tiempoADar -= Time.deltaTime;
			tiempo.text = tiempoADar.ToString ("0.0");
			if (tiempoADar <= 0) {
				restapuntos();
				tiempoADar = _tiempoADar;
			}
		}
	}
	void restapuntos()
	{
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
}
