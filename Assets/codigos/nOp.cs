using UnityEngine;
using System.Collections;

public class nOp : MonoBehaviour {
	public GameObject goPadre;
	private bool una=true;
	private bool sacar = false;
	public AudioClip [] audclip;
	public float x,y,z;
	public float volumenT;
	public int mod;
	void OnMouseDown() {
		if(una)
		{
			NotificationCenter.DefaultCenter ().PostNotification (this,"gBala");
			int num = Random.Range(0, audclip.Length);
			AudioSource.PlayClipAtPoint(audclip[num], new Vector3(x,y,z),volumenT);
			una=false;
			sacar = true;
			if(mod!=3)
			{
				NotificationCenter.DefaultCenter().PostNotification(this,"fugas");
			}
		}
	}
	void Update()
	{
		if (sacar) {
			transform.Translate (-40*Time.deltaTime,0 ,0);
		}
	}
}
