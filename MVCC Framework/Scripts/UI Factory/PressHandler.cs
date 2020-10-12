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
using UnityEngine.EventSystems;


public class PressHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
    
    public BUTTONENUM _group;
    
    public Animate _anim;

    public bool useFade = false;

    public bool Instant = false;

	public NOTIFYEVENT notify = NOTIFYEVENT.NONE;

    IButtonActions _execButton;

	public MonoBehaviour data;

	public bool reportOnUp = false;

    public bool detectDrag = false;

	public List<string> extraParams;


    void Start()
    {
        _execButton = PressManager.instance.FactoryButton(_group);
    }

    bool hasClickActive = false;

    public void OnPointerDown(PointerEventData eventData)
    {



        if (_anim != null && useFade) _anim.FadeOut(null, 0.6f);

		if (reportOnUp) return;

        if (Instant)
        {
			if (notify != NOTIFYEVENT.NONE)
			{
				PressManager.instance.ProcessNotify(notify, data, extraParams);
			}
			else
			{
				PressManager.instance.ProcessClick(_execButton);	
			}
            
            
        }
        else if (PressManager.instance.CanClick)
        {
            hasClickActive = true;           
        }        
    }

    public void OnPointerUp(PointerEventData eventData)
    {



        if (_anim != null && useFade) _anim.FadeIn();



		if (hasClickActive || reportOnUp)
        {
			if (notify != NOTIFYEVENT.NONE)
			{
				PressManager.instance.ProcessNotify(notify, data);
			}
			else
			{
	            hasClickActive = false;
	            PressManager.instance.ProcessClick(_execButton);
			}
        }

    }


}
