/*******************************************************************************************
Author: Jefferson Scomacao - 2017
Description: MVCC for Unity

PressManager.cs : Input/Click manager for UI integrated with MVCC. Better used with LeanTween.
This is a cut down version.

In the future it will be integrated back to App.cs

*******************************************************************************************/

using System.Collections.Generic;

[System.Flags]
public enum BUTTONENUM { NONE, PANELITEM };

public class PressManager : AppElement {

    public static PressManager instance;

    bool _canClick = true;

    public float delayTime = 0.5f;

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

	public void ProcessNotify(NOTIFYEVENT n, PressHandler obj, List<CustomParams> data)
	{
		app.Notify((int)n, obj, data);
		PointerExit();
	}

    public void ProcessClick(IButtonActions execButton)
    {
        if (execButton != null)
            execButton.ExecuteClick(this);

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
        _canClick = false;
        CancelInvoke("UnlockClick");
        Invoke("UnlockClick", delayTime);
    }

	public bool CheckClick ()
	{
		return _canClick;
	}

    public void UnlockClick()
    {
        _canClick = true;
    }

}
