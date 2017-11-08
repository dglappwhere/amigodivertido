using UnityEngine;
using System.Collections;

public class valorRandom : MonoBehaviour {

	public TextMesh valor01;
	public TextMesh valor02;
	void Start () {
		valor01.text = Random.Range (1,60).ToString();
		valor02.text = Random.Range (1,60).ToString();	
	}
}