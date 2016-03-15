using UnityEngine;
using System.Collections;

public class asd : MonoBehaviour {
	public GUIText guitexto;
	public static string nombre;
	void Update () {
		guitexto.text=nombre;
	}
}
