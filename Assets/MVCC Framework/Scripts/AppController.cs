/*******************************************************************************************
Author: Jefferson Scomacao - 2017
Description: MVCC for Unity

AppController.cs : AppController Base Class, use this class from Inherit from

Classes inherited from this will receive Event OnNotification

p_event_path = path to the event

p_target = source object, used to reference back who called this

p_data = all data related to this notification, it can be a mixed types array


*******************************************************************************************/

using UnityEngine;
using System.Collections.Generic;

public class AppController : AppElement {

/*
        You must create your own enumeration for p_event_path and cast as int

        See demo for reference

*/

    public virtual void OnNotification(int p_event_path,Object p_target, List<CustomParams> p_data) { }

}
