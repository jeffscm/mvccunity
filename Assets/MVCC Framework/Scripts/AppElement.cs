/*******************************************************************************************
Author: Jefferson Scomacao - 2017
Description: MVCC for Unity

AppElement.cs : Inherit from this if you want to communicate with MVCC but not receive events.

app object is exposed to be used like:

app.Notify((int)NOTIFYEVENT.CLICK, null, null);

*******************************************************************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppElement : MonoBehaviour {

	// Gives access to the application and all instances.
	public App app { get { return GameObject.FindObjectOfType<App>(); }}

}
