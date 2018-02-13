
/*******************************************************************************************
Author: Jefferson Scomacao - 2017
Description: MVCC for Unity
UIView.cs : SAMPLE

    Sample calls for the View

*******************************************************************************************/

using UnityEngine.UI;

public class UIView : AppElement {

    // notify with parameters
    public void OnChangeInputSample1(string s)
    {
        app.Notify(NOTIFYEVENT.NONE, null, new object[] { s, 0, "other parameter" });
    }

    // pass some object as reference to the controller
    public void OnChangeInputSample2(Text textLabel)
    {
        app.Notify(NOTIFYEVENT.NONE, textLabel, new object[] { 0, "other parameter" });
    }

    // pass some object as parameter
    public void OnChangeInputSample3(Text textLabel)
    {
        app.Notify(NOTIFYEVENT.NONE, null, new object[] { textLabel });
    }

}
