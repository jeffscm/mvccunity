/*******************************************************************************************
Author: Jefferson Scomacao - 2017
Description: MVCC for Unity
PressManager.cs : 

PressManage - Singleton

Use this to handle all your Press/UI events

*******************************************************************************************/

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
[System.Flags]
public enum BUTTONENUM { NONE, PANELITEM };

public class PressManager : AppElement {

    public static PressManager instance;

    bool _canClick = true;
    
    public bool CanClick
    {
        get
        {
            if (!_canClick)
                return false;

            _canClick = false;
            return true;
        }
    }

    void Awake ()
    {
        instance = this;
	}

    void ResetClick ()
    {
        _canClick = true;
    }

	public void ProcessNotify(NOTIFYEVENT n, MonoBehaviour obj, List<string> extraData = null)
	{
		app.Notify(n, obj, extraData);
		PointerExit();
	}

    public void ProcessClick(IButtonActions execButton)
    {
        if (execButton != null)
            execButton.ExecuteClick();

        PointerExit();
    }

    public IButtonActions FactoryButton(BUTTONENUM group)
    {
        switch(group)
        {
		case BUTTONENUM.PANELITEM:
			return new PanelClick();
        }
        return null;
    }

    public void PointerExit ()
    {
        CancelInvoke("ResetClick");
        Invoke("ResetClick", 0.5f);
    }

	public bool CheckClick ()
	{
		return _canClick;
	}

    public void UnlockClick()
    {
        _canClick = true;
    }

    public void HoldClickBackground()
    {
        _canClick = false;
        CancelInvoke("ResetClick");
        Invoke("ResetClick", 0.25f);
    }
}
