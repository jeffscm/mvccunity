/*******************************************************************************************
Author: Jefferson Scomacao - 2017
Description: MVCC for Unity

TestView.cs : Sample how to use the Views in this framework

*******************************************************************************************/

using System.Collections.Generic;

public class TestView : AppElement {

	public void OnChangePanel (int panelIdx)
	{

        app.Notify((int)NOTIFYEVENT.CLICKSHOWPANEL, null, new List<CustomParams> () { new CustomParams() { intValue = 0 } });

    }

}
