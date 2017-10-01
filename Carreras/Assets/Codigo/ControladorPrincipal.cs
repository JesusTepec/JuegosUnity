using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPrincipal : MonoBehaviour {

	public float velocidad = 5.0f;
	private Rigidbody objetoPrincipal;
	private float tiempo;

	public void Start(){
		tiempo = 0;
		objetoPrincipal = GetComponent<Rigidbody> ();
	}

	public void FixedUpdate(){
		tiempo += Time.deltaTime;
		if (tiempo >= 5) {
			Correr ();
		}
	}
		
	private void Correr(){
		float movimientoHorizontal = Input.GetAxis("Horizontal");
		float movimientoVertical = Input.GetAxis("Vertical");

		Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);
		objetoPrincipal.AddForce(movimiento * velocidad);
	}
}
