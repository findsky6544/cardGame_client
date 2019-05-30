using KBEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FindPasswordController : MonoBehaviour
{
    public Transform canvas;

    public InputField accountNameInput;

    public void findPassword()
    {
        Debug.Log("发送找回密码邮件");
        KBEngine.
        KBEngineApp.app.resetPassword(accountNameInput.text);
        MessagePanelController.openMessagePanel(canvas, "已发送邮件，请根据提示操作");
    }

    public void returnLoginScene()
    {
        Debug.Log("跳转到登录场景");
        SceneManager.LoadScene("login");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
