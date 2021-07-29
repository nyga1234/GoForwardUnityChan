using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour
{
    //‰¹ƒf[ƒ^‚ğŠi”[‚·‚é•Ï”
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

        //Õ“Ë‚µ‚½‘Šè‚ÉCubeTag‚ª‚Â‚¢‚Ä‚¢‚é‚Æ‚«
        if (collision.gameObject.tag == "CubeTag")
        {
            //‰¹‚ğÄ¶‚·‚é
            GetComponent<AudioSource>().Play();
        }

        //Õ“Ë‚µ‚½‘Šè‚ÉCubeTag‚ª‚Â‚¢‚Ä‚¢‚é‚Æ‚«
        if (collision.gameObject.tag == "CubeTag")
        {
            //‰¹‚ğÄ¶‚·‚é
            GetComponent<AudioSource>().Play();
        }



    }
}
