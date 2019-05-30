using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;

public class ConfigController : MonoBehaviour
{
    public Transform canvas;

    public Slider bgmSlider;
    public Slider effectAudioSlider;
    public Slider chatAudioSlider;

    public Toggle bgmToggle;
    public Toggle effectAudioToggle;
    public Toggle chatAudioToggle;

    public Text bgmVolumeText;
    public Text effectAudioVolumnText;
    public Text chatAudioVolumnText;

	// Use this for initialization
	void Start () {
        bgmSlider.onValueChanged.AddListener(bgmChanged);
        effectAudioSlider.onValueChanged.AddListener(effectAudioChanged);
        chatAudioSlider.onValueChanged.AddListener(chatAudioChanged);

        bgmToggle.onValueChanged.AddListener(bgmToggleChanged);
        effectAudioToggle.onValueChanged.AddListener(effectAudioToggleChanged);
        chatAudioToggle.onValueChanged.AddListener(chatAudioToggleChanged);

        bgmSlider.value = Init.mainBgm.volume*100;
        bgmToggle.isOn = !Init.mainBgm.mute;
        effectAudioSlider.value = Init.effectAudio.volume*100;
        effectAudioToggle.isOn = !Init.effectAudio.mute;
        chatAudioSlider.value = Init.Voiceengine.GetSpeakerLevel()/8;
        Debug.LogFormat("slider value:{0},voiceengine value:{1}", chatAudioSlider.value, Init.Voiceengine.GetSpeakerLevel());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(!canvas.Find("ConfigPanel(Clone)"))
                openConfigPanel();
        }
    }

    public void bgmChanged(float value)
    {
        Debug.LogFormat("bgm value:{0}",value);
        Init.mainBgm.volume = value/100;
        bgmVolumeText.text = (int)value + "";
        changeConfigs();
    }

    public void bgmToggleChanged(bool isChoose)
    {
        Debug.LogFormat("bgm mute:{0}", isChoose);
        Init.mainBgm.mute = !isChoose;
        changeConfigs();
    }

    public void effectAudioChanged(float value)
    {
        Debug.LogFormat("effect audio value:{0}", value);
        Init.effectAudio.volume = value / 100;
        effectAudioVolumnText.text = (int)value + "";
        changeConfigs();
    }

    public void effectAudioToggleChanged(bool isChoose)
    {
        Debug.LogFormat("effect audio mute:{0}", isChoose);
        Init.effectAudio.mute = !isChoose;
        changeConfigs();
    }

    public void chatAudioChanged(float value)
    {
        Debug.LogFormat("chat audio value:{0}", value);
        Init.Voiceengine.SetSpeakerVolume((int)value*8);
        chatAudioVolumnText.text = (int)value + "";
        changeConfigs();
    }

    public void chatAudioToggleChanged(bool isChoose)
    {
        Debug.LogFormat("chat audio mute:{0}", isChoose);
        if (isChoose)
        {
            Init.Voiceengine.OpenSpeaker();
        }
        else
        {
            Init.Voiceengine.CloseSpeaker();
        }
    }

    public void closePanel()
    {
        Destroy(this.gameObject);
    }

    public void openConfigPanel()
    {
        GameObject configPanel = Instantiate(Resources.Load("perfabs/ConfigPanel")) as GameObject;
        configPanel.transform.SetParent(canvas, false);
    }
    void changeConfigs()
    {
        string configFileURL = Application.dataPath + "/config.xml";
        if (System.IO.File.Exists(configFileURL))
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(configFileURL);
            XmlNodeList configs = XmlDoc.GetElementsByTagName("config")[0].ChildNodes;
            foreach (XmlNode node in configs)
            {
                if (node.Name == "volume")
                {
                    foreach (XmlElement audioNode in node.ChildNodes)
                    {
                        if (audioNode.Name == "bgm")
                        {
                            audioNode.SetAttribute("volume",(Init.mainBgm.volume * 100).ToString());
                            audioNode.SetAttribute("isMute", Init.mainBgm.mute.ToString());
                        }
                        else if (audioNode.Name == "effectAudio")
                        {
                            audioNode.SetAttribute("volume", (Init.effectAudio.volume * 100).ToString());
                            audioNode.SetAttribute("isMute", Init.effectAudio.mute.ToString());
                        }
                        else if (audioNode.Name == "chatAudio")
                        {
                            audioNode.SetAttribute("volume", (Init.Voiceengine.GetSpeakerLevel()/8).ToString());
                        }
                    }
                }
            }
            XmlDoc.Save(configFileURL);
        }
    }
}
