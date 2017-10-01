using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controles : MonoBehaviour {

	public Text textoContador;
	private float contador;

	// Use this for initialization
	void Start () {
		contador = 0;
		textoContador.text = "0";
	}

	// Update is called once per frame
	void Update () {
		if (contador < 6) {
			contador = contador + Time.deltaTime;
			int segundos = (int)contador;
			textoContador.text = segundos.ToString ();
		} else {
			textoContador.gameObject.SetActive (false);
		}
	}
}
