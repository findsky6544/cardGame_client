using KBEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RegisterController : MonoBehaviour {
    public Transform canvas;
    public InputField userNameInput;
    public InputField passwordInput;
    public InputField emailInput;

    public void register()
    {
        if (emailInput.text == "")
        {
            MessagePanelController.openMessagePanel(canvas, "邮箱不允许为空");
        }
        else
        {
            KBEngine.Event.fireIn("createAccount", userNameInput.text, passwordInput.text, System.Text.Encoding.UTF8.GetBytes("PC"));
        }
    }

    public void cancel()
    {
        SceneManager.LoadScene("login");
    }

    public void onCreateAccountResult(UInt16 resultCode,byte[] datas)
    {
        if(resultCode != 0)
        {
            Debug.LogFormat("注册失败，错误码:{0},原因:{1}", resultCode, KBEngineApp.app.serverErr(resultCode));
            MessagePanelController.openMessagePanel(canvas, "注册失败，错误码:" + resultCode + ",原因:"+ KBEngineApp.app.serverErr(resultCode));
        }
        else
        {
            Debug.LogFormat("注册成功,原因:{0}", KBEngineApp.app.serverErr(resultCode));
            KBEngine.Event.fireIn("login", userNameInput.text, passwordInput.text, System.Text.Encoding.UTF8.GetBytes("PC"));
        }
    }

    public void onLoginSuccessfully()
    {
        Debug.LogFormat("正在绑定邮箱：{0}", emailInput.text);
        KBEngineApp.app.bindAccountEmail(emailInput.text);
        MessagePanelController.openMessagePanel(canvas, "注册成功");
    }

    public void onCloseMessagePanel(string text)
    {
        if(text == "注册成功")
        {
            SceneManager.LoadScene("login");
        }
    }

    // Use this for initialization
    void Start () {
        KBEngine.Event.registerOut("onCreateAccountResult", this, "onCreateAccountResult");
        KBEngine.Event.registerOut("onCloseMessagePanel", this, "onCloseMessagePanel");
        KBEngine.Event.registerOut("onLoginSuccessfully", this, "onLoginSuccessfully");

        passwordInput.inputType = InputField.InputType.Password;
    }

    void OnDestroy()
    {
        KBEngine.Event.deregisterOut(this);
    }
}
