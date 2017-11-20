using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickBehavior : MonoBehaviour {

	private SpriteRenderer _renderer;
	private Sprite _default_sprite;
	public Sprite selected_sprite;

	public delegate void UpdateUI(float speed, string destination, float travel_time, string squad_name, bool show);
	public static event UpdateUI updateUI;

	private Squad squad;

	private bool _is_selected;
	public bool is_selected { get { return _is_selected; } }


	// Use this for initialization
	void Start () {
		squad = GetComponent<Squad> ();
		_renderer = GetComponent<SpriteRenderer> ();
		_default_sprite = _renderer.sprite;
	}

	public void OnSelect()
	{
		if (updateUI != null)
		{
			updateUI (squad.speed_km, squad.destination_name, squad.traval_time, squad.squad_name, true);
		}
		_renderer.sprite = selected_sprite;
		_is_selected = true;
	}

	public void OnDeselect()
	{
		if (updateUI != null)
		{
			updateUI (squad.speed_km, squad.destination_name, squad.traval_time, squad.squad_name, false);
		}
		_renderer.sprite = _default_sprite;
		_is_selected = false;
	}
}
