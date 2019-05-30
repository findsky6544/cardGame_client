using KBEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessagePanelController : MonoBehaviour
{
    public static void openMessagePanel(Transform canvas,string message)
    {
        GameObject messagePanel = Instantiate(Resources.Load("perfabs/MessagePanel")) as GameObject;
        messagePanel.transform.Find("Panel").Find("Text").GetComponent<Text>().text = message;
        messagePanel.transform.SetParent(canvas, false);
    }

    public void closePanel()
    {
        Debug.LogFormat("关闭消息面板,this:{0}",this);
        KBEngine.Event.fireOut("onCloseMessagePanel", this.transform.Find("Panel").Find("Text").GetComponent<Text>().text);
        Destroy(this.gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
