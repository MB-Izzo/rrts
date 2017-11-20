using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour {

	private SpriteRenderer _renderer_selected;
	public Sprite _default_sprite;
	public Sprite _selected_sprite;
	private Squad _selected_squad;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		OnClick ();
	}

	private void OnClick()
	{
		if (Input.GetMouseButtonDown (0))
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D[] hits = Physics2D.GetRayIntersectionAll (ray);
			for (int i = 0; i < hits.Length; i++)
			{
				if (hits [i].collider.CompareTag ("Soldier"))
				{
					_renderer_selected = hits [i].collider.GetComponent<SpriteRenderer> ();
					_renderer_selected.sprite = _selected_sprite;
					_selected_squad = hits [i].collider.GetComponent<Squad> ();
				}
				else
				{
					if (_renderer_selected != null)
					{
						_renderer_selected.sprite = _default_sprite;
						_selected_squad = null;
					}
				}
			}
		}

	} 
}
