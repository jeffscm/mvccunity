/*******************************************************************************************
Author: Jefferson Scomacao - 2017
Description: MVCC for Unity

App.cs : Framework entry point, should be present in the scene before any other script

*******************************************************************************************/


using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour {

	public AppModel model { get; set; }

    public bool IsPersistent = false;

    List<AppController> allControllers = new List<AppController>();

    /*
     
    Use this script to handle:
    
    # Loaders
    # Progress bars
    # Modal views/screens references
    # Unique objects important to system function     
         
    */

    void Awake ()
	{
		model = new AppModel();

        if (IsPersistent)
        {
            DontDestroyOnLoad(this);
        }
	}

	public void Notify(int p_event_path, UnityEngine.Object p_target, List<CustomParams> p_data)
	{
		foreach(AppController c in allControllers)
		{
			c.OnNotification(p_event_path,p_target,p_data);
		}
	}

    public void RegisterController(AppController newController)
    {
        if (allControllers.IndexOf(newController) < 0)
            allControllers.Add(newController);
    }

    public void UnRegisterController(AppController newController)
    {
        var x = allControllers.IndexOf(newController);
        if (x >= 0)
            allControllers.RemoveAt(x);
    }
}
