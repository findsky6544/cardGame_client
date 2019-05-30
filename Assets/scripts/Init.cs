using gcloud_voice;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Init : MonoBehaviour {
    private static Dictionary<string, object> datas = new Dictionary<string, object>();
    public static AudioSource mainBgm;
    public static AudioSource effectAudio;
    private static IGCloudVoice voiceengine = GCloudVoice.GetEngine();

    public static Dictionary<string,object> Datas
    {
        get { return datas; }
    }

    public static IGCloudVoice Voiceengine
    {
        get { return voiceengine; }
    }

    // Use this for initialization
    void Start ()
    {
        mainBgm = this.gameObject.AddComponent<AudioSource>();
        mainBgm.loop = true;
        mainBgm.playOnAwake = true;
        mainBgm.clip = (AudioClip)Resources.Load("music/mainBgm");
        mainBgm.Play();

        effectAudio = this.gameObject.AddComponent<AudioSource>();
        effectAudio.playOnAwake = false;

        initConfigs();

        System.TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
        string strTime = System.Convert.ToInt64(ts.TotalSeconds).ToString();
        int ret = voiceengine.SetAppInfo("932849489", "d94749efe9fce61333121de84123ef9b", strTime);
        //int ret = voiceengine.SetAppInfo("1035561383", "63ecf781b22b5796c8fdd864256ac5c6", strTime);
        //int ret = voiceengine.SetAppInfo("1399720660", "4bc37e395a4cde9a2c97cc4315167a21", strTime);
        Debug.LogFormat("set app info result:{0}", ret);
        ret = voiceengine.Init();
        Debug.LogFormat("init result:{0}", ret);
        ret = Init.Voiceengine.SetMode(GCloudVoiceMode.RealTime);
        Debug.LogFormat("set mode result:{0}", ret);
        Init.Voiceengine.SetSpeakerVolume(800);

        DontDestroyOnLoad(this);
        Debug.LogFormat("初始化完成，跳转到登陆界面");
        SceneManager.LoadScene("login");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void initConfigs()
    {
        string configFileURL = Application.dataPath + "/config.xml";
        XmlDocument xml = new XmlDocument();
        if (System.IO.File.Exists(configFileURL))
        {
            xml.Load(configFileURL);
            XmlNodeList configs = xml.GetElementsByTagName("config")[0].ChildNodes;
            foreach(XmlNode node in configs)
            {
                if(node.Name == "volume")
                {
                    foreach(XmlElement audioNode in node.ChildNodes)
                    {
                        if(audioNode.Name == "bgm")
                        {
                            mainBgm.volume = float.Parse(audioNode.GetAttribute("volume"))/100;
                            mainBgm.mute = bool.Parse(audioNode.GetAttribute("isMute"));
                        }
                        else if (audioNode.Name == "effectAudio")
                        {
                            effectAudio.volume = float.Parse(audioNode.GetAttribute("volume")) / 100;
                            effectAudio.mute = bool.Parse(audioNode.GetAttribute("isMute"));
                        }
                        else if (audioNode.Name == "chatAudio")
                        {
                            voiceengine.SetSpeakerVolume(int.Parse(audioNode.GetAttribute("volume"))*8);
                            Debug.LogFormat("node value:{0},voiceengine value:{1}", audioNode.GetAttribute("volume"), voiceengine.GetSpeakerLevel());
                            if (bool.Parse(audioNode.GetAttribute("isMute"))){
                                voiceengine.CloseSpeaker();
                            }
                            else
                            {
                                voiceengine.OpenSpeaker();
                            }
                        }
                    }
                }
            }
        }
        else
        {
            XmlElement config = xml.CreateElement("config");
            XmlElement volume = xml.CreateElement("volume");
            XmlElement bgm = xml.CreateElement("bgm");
            bgm.SetAttribute("volume", "100");
            bgm.SetAttribute("isMute", "false");
            XmlElement effectAudio = xml.CreateElement("effectAudio");
            effectAudio.SetAttribute("volume", "100");
            effectAudio.SetAttribute("isMute", "false");
            XmlElement chatAudio = xml.CreateElement("chatAudio");
            chatAudio.SetAttribute("volume", "100");
            chatAudio.SetAttribute("isMute", "false");

            volume.AppendChild(bgm);
            volume.AppendChild(effectAudio);
            volume.AppendChild(chatAudio);
            config.AppendChild(volume);
            xml.AppendChild(config);

            xml.Save(configFileURL);
        }
    }
}
