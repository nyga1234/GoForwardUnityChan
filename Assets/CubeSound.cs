using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour
{
    //���f�[�^���i�[����ϐ�
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

        //�Փ˂��������CubeTag�����Ă���Ƃ�
        if (collision.gameObject.tag == "CubeTag")
        {
            //�����Đ�����
            GetComponent<AudioSource>().Play();
        }

        //�Փ˂��������CubeTag�����Ă���Ƃ�
        if (collision.gameObject.tag == "CubeTag")
        {
            //�����Đ�����
            GetComponent<AudioSource>().Play();
        }



    }
}
