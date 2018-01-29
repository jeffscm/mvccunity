using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System;

public class PressGame : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
    
    public Animate _anim;
    public bool useFade = false;

	public NOTIFYEVENT notifyDown = NOTIFYEVENT.NONE;
	public NOTIFYEVENT notifyUp = NOTIFYEVENT.NONE;

    public void OnPointerDown(PointerEventData eventData)
    {
		PressManager.instance.ProcessNotify(notifyDown, null);
    }

    public void OnPointerUp(PointerEventData eventData)
    {

		PressManager.instance.ProcessNotify(notifyUp, null);

    }


}
