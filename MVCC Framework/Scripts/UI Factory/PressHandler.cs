/*******************************************************************************************
Author: Jefferson Scomacao - 2017
Description: MVCC for Unity
PressHandler.cs : 

Replacement for Button Component

Use this with Animate script

*******************************************************************************************/

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
