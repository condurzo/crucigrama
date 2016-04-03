using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GanasteCarta : MonoBehaviour {

	public Sprite[] CartasChicas;
	public Image Carta1;
	public Image Carta2;
	public Image Carta3;

	void DarVueltaCarta1 () {
		int Random1 = UnityEngine.Random.Range (1, 4);
		switch (Random1) {
		case 1:
			
			break;
		case 2:
			break;
		case 3:
			break;
		}

	}
	
	void Update () {
	
	}
}
