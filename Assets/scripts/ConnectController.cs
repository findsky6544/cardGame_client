using KBEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConnectController : MonoBehaviour
{
    public Transform canvas;

    // Use this for initialization
    void Start () {
        KBEngine.Event.registerOut("onDisconnected", this, "onDisconnected");
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnDestroy()
    {
        KBEngine.Event.deregisterOut(this);
    }

    public void exit()
    {
        KBEngineApp.app.reset();
        Init.Datas.Clear();
        SceneManager.LoadScene("login");
    }

    public void onDisconnected()
    {
        MessagePanelController.openMessagePanel(canvas,"链接已断开");
        KBEngine.Event.registerOut("onCloseMessagePanel", this, "onCloseMessagePanel");
    }

    public void onCloseMessagePanel(string message)
    {
        Debug.LogFormat("关闭消息面板,消息:{0}",message);
        exit();
    }
}
