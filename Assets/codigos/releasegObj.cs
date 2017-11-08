using UnityEngine;
using System.Collections;

public class releasegObj : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D colli)
	{
		Destroy (colli.gameObject);
	}
}