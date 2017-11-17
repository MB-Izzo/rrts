using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class TimedAction
{
	private DateTime _time_started;
	private DateTime _last_date;
	private float _action_ratio;
	private double _time_progress;

	[SerializeField]
	private float _duration;
	[SerializeField]
	private long _seria_time_started;
	[SerializeField]
	private long _seria_last_date;


    // public accessors
	public DateTime time_started { get { return _time_started; } }
	public float duration { get { return _duration; } }
	public float ratio { get { return _action_ratio; } }

	public TimedAction(float duration, DateTime date)
	{
		_time_started = date;
		_last_date = _time_started;
		_duration = duration;
		_action_ratio = 0.0f;
	}

	public void Update(DateTime new_date)
	{
		double delta = MsElapsed(new_date, _last_date);
		_time_progress += delta / 1000f;
		_action_ratio = Mathf.Min((float)_time_progress / _duration, 1f);
		_last_date = new_date;
	}

	private double MsElapsed(DateTime a, DateTime b)
	{
		return a.Subtract(b).TotalMilliseconds;
	}

	public string SerializeToJSON()
	{
		_seria_time_started = this.time_started.ToFileTimeUtc();
		_seria_last_date = this._last_date.ToFileTimeUtc();
		return JsonUtility.ToJson(this, true); // TODO: Display the content of the string.
	}
}

/*
le plan c'est
tu as un monobehaviour
qui contient un timedaction
ce timedaction tu peux le serialiser maintenant
donc quand tu vas arreter le jeu
tu vas parcourir tous tes objets de jeu
et leur dire "serialize toi doudou"
ils vont te retourner leur type (unite au sol, ennemis) et vont contenir leur timedaction
du coup quand tu vas deserialiser tes unites
tu vas dire "ah, ici j'ai une troupe au sol, ennemie, ok je vais creer un gameobject lui coller le bon component, et lui filer mon objet a deseria, il mettra son timedaction aux bonnes valeur, et je le passe a timemanager pour qu'il lui fasse jouer son ratio"
voila
your game, in a nutshell
/*