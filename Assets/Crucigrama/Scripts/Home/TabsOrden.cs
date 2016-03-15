using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TabsOrden : MonoBehaviour {
	public Image CrucigramaBtn;
	public Image CartasBtn;
	public Image FeedBackBtn;

	public Sprite Barra_Superior_Cartas_CERCA;
	public Sprite Barra_Superior_Cartas_ON;
	public Sprite Barra_Superior_Crucigrama_CERCA;
	public Sprite Barra_Superior_Crucigrama_LEJOS;
	public Sprite Barra_Superior_Crucigrama_ON;
	public Sprite Barra_Superior_Feedback_CERCA;
	public Sprite Barra_Superior_Feedback_LEJOS;
	public Sprite Barra_Superior_Feedback_ON;


	public void EnCrucigrama () {
		CrucigramaBtn.sprite = Barra_Superior_Crucigrama_ON;
		CartasBtn.sprite = Barra_Superior_Cartas_CERCA;
		FeedBackBtn.sprite = Barra_Superior_Feedback_LEJOS;
	}
	public void EnCartas () {
		CrucigramaBtn.sprite = Barra_Superior_Crucigrama_CERCA;
		CartasBtn.sprite = Barra_Superior_Cartas_ON;
		FeedBackBtn.sprite = Barra_Superior_Feedback_CERCA;
	}
	public void EnFeedBack () {
		CrucigramaBtn.sprite = Barra_Superior_Crucigrama_LEJOS;
		CartasBtn.sprite = Barra_Superior_Cartas_CERCA;
		FeedBackBtn.sprite = Barra_Superior_Feedback_ON;
	}
	




}
