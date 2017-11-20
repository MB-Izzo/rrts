using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour {

	private List<OnClickBehavior> soldiers = new List<OnClickBehavior>();

	private static ClickManager _instance;
	public static ClickManager Instance { get { return _instance; } }

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
					OnClickBehavior clicked = hits [i].collider.GetComponent<OnClickBehavior>();
					clicked.OnSelect();
					soldiers.Add(clicked);

				}
				else
				{
					if (soldiers.Count >= 1) 
					{
						foreach(OnClickBehavior c in soldiers)
						{
							c.OnDeselect();

						}
						soldiers.Clear ();
					}

				}
			}
		}

	}
}
