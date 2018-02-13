/*******************************************************************************************
Author: Jefferson Scomacao - 2017
Description: MVCC for Unity
UIController.cs : SAMPLE

Sample how to use the AppController

Override the OnNotification Method

How to invoke a notification to the system

*******************************************************************************************/

using UnityEngine;

public class UIController : AppController {

    public override void OnNotification(NOTIFYEVENT p_event_path, Object p_target, params object[] p_data)
    {
        switch(p_event_path)
        {
            case NOTIFYEVENT.NONE:
                Debug.Log("None event");
                break;
        }
    }

    void TestNotify ()
    {
        app.Notify(NOTIFYEVENT.NONE, null, null);
    }
}
