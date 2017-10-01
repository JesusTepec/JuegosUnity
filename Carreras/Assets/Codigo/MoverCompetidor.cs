using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCompetidor : MonoBehaviour {

	private float velocidad = 10;
	private float tiempo;

	// Use this for initialization
	void Start () {
		tiempo = 0;
	}

	// Update is called once per frame
	void Update () {
		tiempo = tiempo + Time.deltaTime;
		if (tiempo >= 5) {
			Correr();
		}
	}

	private void Correr(){
		float posZ = transform.position.z + (velocidad * Time.deltaTime);
		transform.position = new Vector3(transform.position.x, transform.position.y, posZ);
	}
}
