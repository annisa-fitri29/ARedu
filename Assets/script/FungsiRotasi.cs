using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FungsiRotasi : MonoBehaviour
{

    public float Kecepatan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,Kecepatan*10*Time.deltaTime,0);
    }

    private void OnMouseDown()
    {
        GetComponent<Animation>().Play("button");
        Sistem.instance.PanggilSuaraBuah();
    }
}
