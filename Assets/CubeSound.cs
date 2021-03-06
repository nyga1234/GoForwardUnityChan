using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour
{
    //音データを格納する変数
    private AudioSource audio;

    private AudioClip sound;
    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //衝突した相手にCubeTagがついているとき
        if (collision.gameObject.tag == "CubeTag")
        {
            //音を再生する
            GetComponent<AudioSource>().Play();
        }

        //衝突した相手にCubeTagがついているとき
        if (collision.gameObject.tag == "CubeTag")
        {
            //音を再生する
            GetComponent<AudioSource>().Play();
        }



    }
}
