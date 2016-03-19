using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CrucigramaShower : MonoBehaviour {
	public Text Nombre;
	public Text palabras;
	public Text estado;
	public int id;

	public void Resolver(){
		Managerhome.instance.CargarCruci (id);
	}
}
