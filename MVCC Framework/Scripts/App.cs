/*******************************************************************************************
Author: Jefferson Scomacao - 2017
Description: MVCC for Unity
App.cs : 

Base class for the MVCC

*******************************************************************************************/

using UnityEngine;

public class App : MonoBehaviour {

	public AppModel model;

	void Awake ()
	{
        model = new AppModel();
	}

	public void Notify(NOTIFYEVENT p_event_path, UnityEngine.Object p_target, params object[] p_data)
	{
		AppController[] controller_list = GetAllControllers();
		foreach(AppController c in controller_list)
		{
			c.OnNotification(p_event_path,p_target,p_data);
		}
	}

	// Fetches all scene Controllers.
	public AppController[] GetAllControllers() { return GameObject.FindObjectsOfType<AppController>(); }

}
