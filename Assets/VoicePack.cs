using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoicePack : MonoBehaviour
{
    public static VoicePack instance;
    public AudioClip[] audio_clips;
    List<AudioSource> Suara = new List<AudioSource>();

    private void Awake()
    {
        instance = this;
    }

    public void Panggil_Suara(int i)
    {
        Suara[i].Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        Suara.Clear();
        for (int i = 0; i<audio_clips.Length; i++)
        {
            Suara.Add(gameObject.AddComponent<AudioSource>());
            Suara[i].clip = audio_clips[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
