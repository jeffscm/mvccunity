/*******************************************************************************************
Author: Jefferson Scomacao - 2017
Description: MVCC for Unity

PrssHandler.cs : Instead of Button scripts use this to speed up process. Better used together
with animations as LeanTween. This is a cut down version

*******************************************************************************************/


using UnityEngine;

using System.Collections.Generic;

using UnityEngine.EventSystems;
using System;

public class PressHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
    
    public BUTTONENUM _group;
    
    public bool Instant = false;

	public NOTIFYEVENT notify = NOTIFYEVENT.NONE;

    IButtonActions _execButton;

	public bool reportOnUp = false;

    public List<CustomParams> customParams;

    void Start()
    {
        _execButton = PressManager.instance.FactoryButton(_group);
    }

    bool hasClickActive = false;

    public void OnPointerDown(PointerEventData eventData)
    {
		if (reportOnUp) return;

        if (Instant)
        {
			if (notify != NOTIFYEVENT.NONE)
			{
				PressManager.instance.ProcessNotify(notify, this, customParams);
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
		if (hasClickActive || reportOnUp)
        {
			if (notify != NOTIFYEVENT.NONE)
			{
				PressManager.instance.ProcessNotify(notify, this, customParams);
			}
			else
			{
	            hasClickActive = false;
	            PressManager.instance.ProcessClick(_execButton);
			}
        }
    }


}

[Serializable]
public class CustomParams
{
    public int intValue;
    public MonoBehaviour gameObject;


}
