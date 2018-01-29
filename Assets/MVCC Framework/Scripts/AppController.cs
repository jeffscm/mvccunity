/*******************************************************************************************
Author: Jefferson Scomacao - 2017
Description: MVCC for Unity
AppController.cs : 

Base override for Controller

*******************************************************************************************/


using UnityEngine;

public class AppController : AppElement {

	public virtual void OnNotification(NOTIFYEVENT p_event_path,Object p_target,params object[] p_data)
	{
		
	}
}
