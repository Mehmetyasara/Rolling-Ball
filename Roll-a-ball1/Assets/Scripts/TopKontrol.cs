using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    public int hiz;
    public Rigidbody fizik;
    public int puan;

    public Text puanText;
    public Text oyunBittiText;
    
    void Start()
    {
        fizik.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.Translate(0, 0, 0.01f); x , y ve z eksenlerinde hareketi için kullanılan komut.
        //transform.Rotate(0, 0, 0.1f); objenin kendi etrafında x , y ve z eksenlerinde hareketi için kullanılan komut
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        fizik.AddForce(yatay * hiz, 0, dikey * hiz);


    }
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        puan++;

        puanText.text = "Puan: " + puan;

        if (puan == 8)
        {
            oyunBittiText.gameObject.SetActive(true);
        }
    }
}
