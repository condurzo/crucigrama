using UnityEngine;
using System.Collections;

public class presplash : MonoBehaviour {
	public string escena;
	public float tiempo;
	// Use this for initialization
	void Start () {
		Invoke("Cambiar",tiempo);
	}

	void Cambiar(){
		Application.LoadLevel(escena);
	}
}
