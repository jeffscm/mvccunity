/*******************************************************************************************
Author: Jefferson Scomacao - 2017
Description: MVCC for Unity

ProgramController.cs : Sample Inherited Controller 

Objective:

    Two panels
        Panel 1:
            Button to show panel 2
            Button to change its own value with content from InputField
            InputField 

        Panel 2:
            Button to show panel 2
            Button to change panel to Blue            

*******************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgramController : AppController {


    public Image[] panels;

    public InputField inputField;

    public Text changeText;

    void OnEnable()
    {
        app.RegisterController(this);
    }

    void OnDisable()
    {
        if (app != null) app.UnRegisterController(this);
    }

    public override void OnNotification(int p_event_path,Object p_target, List<CustomParams> p_data)
	{

		switch ((NOTIFYEVENT)p_event_path)
		{

            case NOTIFYEVENT.CLICKSHOWPANEL:
                var idx = p_data[0].intValue;
                SetPanel(idx);
                break;

            case NOTIFYEVENT.CLICKGETINPUTTEXTDIRECT:
                (p_data[0].gameObject as Text).text = (p_data[1].gameObject as InputField).text;

                break;
            case NOTIFYEVENT.CLICKGETINPUTTEXT_CLASS:
                changeText.text = inputField.text;

                break;
            case NOTIFYEVENT.CLICKCHANGETOBLUE:
                (p_data[0].gameObject as Image).color = Color.blue;

                break;
        }

    }

    //----------------------------------------------
    // Helper functions for this controller
    //----------------------------------------------

    void SetPanel(int idx)
    {

        for(int i = 0; i < panels.Length; i++)
        {
            panels[i].gameObject.SetActive(i == idx);
        }

    }
	
}
