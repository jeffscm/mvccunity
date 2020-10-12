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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Animate : MonoBehaviour {

	public CanvasGroup cg;
	public RectTransform rectTrans;
	public bool deactivateOnOut = false;
	public bool onStartXScreen = false;

	void Awake ()
	{
		//if (onStartXScreen)
		//{
		//	var v = rectTrans.position;
		//	v.x = Screen.width * 2;
		//	rectTrans.position = v;
		//	if (deactivateOnOut)
		//	{
		//		this.gameObject.SetActive(false);
		//	}
		//}
	}

	public void FadeOut (Action onComplete = null, float limit = 0f, float speed = 0.25f)
	{
		//gameObject.SetActive(true);
		//LeanTween.cancel(this.gameObject);

		//LeanTween.alphaCanvas(cg, limit, speed).setOnComplete ( () => {
		//	if (onComplete != null)
		//		onComplete ();

		//	if (deactivateOnOut)
		//		this.gameObject.SetActive(false);
			
		//});

	}
	public void FadeIn (Action onComplete = null, float limit = 1f, float speed = 0.25f)
	{
		//gameObject.SetActive(true);
		//LeanTween.cancel(this.gameObject);

		//LeanTween.alphaCanvas(cg, limit, speed).setOnComplete ( () => {
		//	if (onComplete != null)
		//		onComplete ();
		//});

	}

	public void FadeInPanel (Action onComplete = null)
	{
		
		FadeIn(onComplete, 1f, 1f);
	}

	public void FadeOutPanel (Action onComplete = null)
	{
		FadeOut(onComplete, 0f, 1f);
	}
	public void FadeInInstant ()
	{
		//gameObject.SetActive(true);
		//LeanTween.cancel(this.gameObject);
		//cg.alpha = 1f;
	}

	public void FadeOutInstant ()
	{
		//gameObject.SetActive(true);
		//LeanTween.cancel(this.gameObject);
		//cg.alpha = 0f;
	}

	public void MoveY (float f, Action onComplete = null)
	{
		//gameObject.SetActive(true);
		//LeanTween.cancel(this.gameObject);
		//LeanTween.moveY(rectTrans, f, 0.5f).setEaseInOutExpo ().setOnComplete ( () => {

		//	if (onComplete != null) onComplete ();

		//});
	}

	public void MoveXIn (Action onComplete = null)
	{
		//gameObject.SetActive(true);

  //      var v = rectTrans.anchoredPosition;
  //      v.x = rectTrans.rect.width * 2f;
		//rectTrans.anchoredPosition = v;

		//LeanTween.cancel(this.gameObject);
		//LeanTween.moveX(rectTrans, 0, 0.35f).setDelay(0.1f).setEaseInOutExpo ().setOnComplete ( () => {
		//	if (onComplete != null)
		//		onComplete ();
		//});

	}

	public void MoveXOut(Action onComplete = null)
	{

  //      float f = Mathf.Abs(rectTrans.rect.width) * (-1f);
       
		//gameObject.SetActive(true);
		//LeanTween.cancel(this.gameObject);
		//LeanTween.moveX(rectTrans, f, 0.35f).setDelay(0.1f).setEaseInOutExpo ().setOnComplete ( () => {
		//	if (onComplete != null)
		//		onComplete ();

		//	if (deactivateOnOut)
		//		this.gameObject.SetActive(false);
			
		//});

	}

}
