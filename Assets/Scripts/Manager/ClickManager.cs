using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour {

	private static ClickManager _instance;
	public static ClickManager Instance { get { return _instance; } }

	private Squad _squad_selected;
	public Squad squad_selected { get { return _squad_selected; }}

	private OnClickBehavior _squad_selected_clicked_behavior = null;
	public delegate Squad OnSquadSelected();
	public event OnSquadSelected onSquadSelected;

	// Use this for initialization
	void Start () {
		if (_instance != null && _instance != this)
		{
			Destroy (this.gameObject);
		}
		else
		{
			_instance = this;
		}
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
					_squad_selected_clicked_behavior = hits [i].collider.GetComponent<OnClickBehavior>();
					_squad_selected_clicked_behavior.OnSelect();
					_squad_selected = _squad_selected_clicked_behavior.GetComponent<Squad> ();
					if (onSquadSelected != null)
					{
						onSquadSelected ();
					}

				}
				/*else
				{
					if (squad_selected != null)
					{
						_squad_selected_clicked_behavior.OnDeselect ();
						_squad_selected = null;
					}

				}*/
			}
		}

	}
}
