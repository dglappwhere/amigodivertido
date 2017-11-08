using UnityEngine;
using System.Collections;

public class genPares : MonoBehaviour {

	//Numeros del primer par
	public TextMesh P1num01;
	public TextMesh P1num02;
	//numeros del segundo par
	public TextMesh P2num01;
	public TextMesh P2num02;
	//variables
	public int min, max;
	public string operador;
	//Luego mejorare esto!!!
	int num1,num2,num3,num4;
	void Start () {
		num1 = Random.Range (min,max);
		num2 = Random.Range (min,max);
		num3 = Random.Range (min,max);
		num4 = Random.Range (min,max);
		P1num01.text = num1.ToString();
		P1num02.text = operador+num2.ToString();
		P2num01.text = num3.ToString();
		P2num02.text = operador+num4.ToString();
	}
}
