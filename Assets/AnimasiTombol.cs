using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimasiTombol : MonoBehaviour
{
    //public static string NamaScene;
    public void animasi()
    {
        GetComponent<Animation>().Play("button");
        VoicePack.instance.Panggil_Suara(0);
    }

    public void Pindah_SceneMain()
    {
        SceneManager.LoadScene(1);
    }

    public void Pindah_SceneMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void CloseApp()
    {
        Application.Quit();
    }
}
