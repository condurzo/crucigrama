using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class progreso : MonoBehaviour {
	//public GUIText guitexto;
	public UnityEngine.UI.Text guitexto;
	void Update () {
		guitexto = GetComponent<UnityEngine.UI.Text>();
		guitexto.text=ZipTest.progreso.ToString();
	}
}
