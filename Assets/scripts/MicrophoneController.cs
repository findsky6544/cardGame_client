using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

public class MicrophoneController : MonoBehaviour {
    //public AudioSource inAudio;
    //public AudioSource outAudio;
    //string[] micArray;

    // Use this for initialization
    void Start () {
        //KBEngine.Event.registerOut("playVoice",this,"playVoice");


        //getDevices();
    }

    //private void getDevices()
    //{
    //    micArray = Microphone.devices;
    //    if (micArray.Length == 0)
    //    {
    //        Debug.LogError("Microphone.devices is null");
    //    }
    //    foreach (string deviceStr in Microphone.devices)
    //    {
    //        Debug.Log("device name = " + deviceStr);
    //    }
    //}
	
	// Update is called once per frame
	void Update ()
    {
        Init.Voiceengine.Poll();
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.LogFormat("打开麦克风");
            int ret = Init.Voiceengine.OpenMic();
            Debug.LogFormat("open mic result:{0}",ret);
            this.transform.Find("Content").GetComponent<Text>().text += "open mic result:"+ret;
            //startRecord();
        }
        if (Input.GetKeyUp(KeyCode.T))
        {
            Debug.LogFormat("关闭麦克风");
            int ret = Init.Voiceengine.CloseMic();
            Debug.LogFormat("close mic result:{0}", ret);
            this.transform.Find("Content").GetComponent<Text>().text += "close mic result:" + ret;
            //stopRecord();
        }
    }

    //private void startRecord()
    //{
    //    Debug.LogFormat("开始语音");
    //    inAudio.clip = Microphone.Start(null, false, 1, 8000);
    //    while (!(Microphone.GetPosition(null) > 0))
    //    {
    //    }
    //    float[] samples = new float[inAudio.clip.samples];
    //    inAudio.clip.GetData(samples, 0);
    //    Debug.LogFormat("samples:{0},length:{1}", samples,samples.Length);
    //    byte[] samplesByte = new byte[samples.Length * 4];
    //    Debug.LogFormat("samplesByte:{0},length:{1}", samplesByte,samplesByte.Length);
    //    Buffer.BlockCopy(samples, 0, samplesByte, 0, samplesByte.Length);
    //    byte[] samplesZip = compress(samplesByte);
    //    Debug.LogFormat("samplesZip:{0},length:{1}", samplesZip,samplesZip.Length);

    //    List<byte> voice = new List<byte>(samplesZip);
    //    KBEngine.Event.fireIn("sendVoice", voice);
    //    //newAudio.Play();
    //}

    //private void stopRecord()
    //{
    //    Debug.LogFormat("结束语音");
    //    inAudio.Stop();
    //}

    //public void playVoice(List<byte> voice)
    //{
    //    Debug.LogFormat("播放语音");
    //    byte[] samplesZip = voice.ToArray();
    //    Debug.LogFormat("samplesZip:{0},length:{1}", samplesZip,samplesZip.Length);
    //    byte[] samplesByte = deCompress(samplesZip);
    //    Debug.LogFormat("samplesByte:{0},length:{1}", samplesByte,samplesByte.Length);
    //    float[] samples = new float[samplesByte.Length / 4];
    //    Debug.LogFormat("samples:{0},length:{1}", samples,samples.Length);
    //    Buffer.BlockCopy(samplesByte, 0, samples, 0, samples.Length);
    //    outAudio.clip = AudioClip.Create("outAudio",8000,1,8000,false);
    //    outAudio.clip.SetData(samples, 0);
    //    outAudio.Play();
    //}

    //private byte[] compress(byte[] binary)
    //{
    //    MemoryStream ms = new MemoryStream();
    //    GZipOutputStream gzip = new GZipOutputStream(ms);
    //    gzip.Write(binary, 0, binary.Length);
    //    gzip.Close();
    //    byte[] press = ms.ToArray();
    //    return press;
    //}

    //private byte[] deCompress(byte[] press)
    //{
    //    GZipInputStream gzi = new GZipInputStream(new MemoryStream(press));
    //    MemoryStream re = new MemoryStream();
    //    int count = 0;
    //    byte[] data = new byte[4096];
    //    while ((count = gzi.Read(data, 0, data.Length)) != 0)
    //    {
    //        re.Write(data, 0, count);
    //    }
    //    byte[] depress = re.ToArray();
    //    return depress;
    //}
}
