using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sistem : MonoBehaviour
{
    public static Sistem instance;
    public int ID;
    public GameObject TempatSpawn;
    public GameObject Gui_Utama;
    public GameObject[] KoleksiBuah;
    public AudioClip[] SuaraBuah;
    AudioSource Suara;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        ID = 0;
        //SpawnObject();
        Gui_Utama.SetActive(false);
        Suara = gameObject.AddComponent<AudioSource>();
    }

    void Update()
    {
       
    }

    public void btnspawn()
    {
        Gui_Utama.SetActive(true);
        TempatSpawn.GetComponent<Animation>().Play("PopUp");
        VoicePack.instance.Panggil_Suara(1);
    }

    public void btnhide()
    {
        Gui_Utama.SetActive(false);
    }

    public void SpawnObject()
    {
        GameObject BendaSebelumnya = GameObject.FindGameObjectWithTag("Buah");
        if (BendaSebelumnya != null) Destroy(BendaSebelumnya);

        GameObject Benda = Instantiate(KoleksiBuah[ID]);
        Benda.transform.SetParent(TempatSpawn.transform,false);
        Benda.transform.localScale = new Vector3(170,170,170);
        TempatSpawn.GetComponent<Animation>().Play("PopUp");
        VoicePack.instance.Panggil_Suara(1);
    }

    public void GantiBuahKanan()
    {
        if(ID >= KoleksiBuah.Length -1)
        {
            ID = 0;
        }
        else
        {
            ID++;
        }
        SpawnObject();
        PanggilSuaraBuah();
    }    
    
    
    public void GantiBuahKiri()
    {
        if(ID <= 0)
        {
            ID = KoleksiBuah.Length -1;
        }
        else
        {
            ID--;
        }
        SpawnObject();
        PanggilSuaraBuah();
    }

    public void PanggilSuaraBuah()
    {
        Suara.clip = SuaraBuah[ID];
        Suara.Play();
    }
}
