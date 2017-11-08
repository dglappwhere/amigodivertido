using UnityEngine;
using System.Collections;

public class weblapicin : MonoBehaviour {
	public string url;
	void OnMouseUp()
	{
		Application.OpenURL(url);
	}
}
