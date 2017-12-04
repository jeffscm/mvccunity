/*******************************************************************************************
Author: Jefferson Scomacao - 2017
Description: MVCC for Unity

AppModel.cs : 

*******************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;

public class AppModel {


    public AppModel ()
    {
        /*

        Use this space to handle:

            # Create/Instance other models in the system
            # Initialize what is needed 
            # Lazy load if needed as this is called once in App.cs

        Remember:

            # The AppModel is the hub to all other model scripts

        */
    }

    public IEnumerator GetData (Action<string> onResult)
    {
        var request = new UnityWebRequest("https://www.google.com");
        yield return request.Send();

        if (string.IsNullOrEmpty(request.error))
            onResult(request.downloadHandler.text);
        else
            onResult(null);
    }

}
