/*******************************************************************************************
Author: Jefferson Scomacao - 2017
Description: MVCC for Unity
AppElement.cs : 

Base Element class for MVCC

*******************************************************************************************/

using UnityEngine;

public class AppElement : MonoBehaviour {

	// Gives access to the application and all instances.
	public App app { get { return GameObject.FindObjectOfType<App>(); }}
}
