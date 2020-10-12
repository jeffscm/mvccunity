/*
Jefferson Scomacao
https://www.jscomacao.com

GitHub - Source Code
Project: MVCC2.0

Copyright (c) 2015 Jefferson Raulino Scomação

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
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
