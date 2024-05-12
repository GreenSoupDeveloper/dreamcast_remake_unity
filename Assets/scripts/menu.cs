using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class menu : MonoBehaviour
{
    public int mainOptionChoosed;

    public Animator sceneAnimator;
    public AudioSource audiosrc;
    public AudioClip selection;
    public AudioClip accept;
    public AudioClip back;
    public GameObject backfog;
    public TextMeshPro date;
    public TextMeshPro hour;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {



        date.text = "" + DateTime.Now.ToString("dd/MM/yyyy");
             hour.text = "" + DateTime.Now.ToString("HH:mm");
        backfog.transform.Rotate(0, 0, 0.1f);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audiosrc.PlayOneShot(accept);
        
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            audiosrc.PlayOneShot(back);

        }
        sceneAnimator.SetInteger("iconChoosed", mainOptionChoosed);                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
        if (mainOptionChoosed < 0){mainOptionChoosed = 0;}
        if (mainOptionChoosed > 3) { mainOptionChoosed = 3; }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            if (mainOptionChoosed > 0)
            {
                mainOptionChoosed -= 1; audiosrc.PlayOneShot(selection);
            }
            
            
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (mainOptionChoosed < 3)
            {
                mainOptionChoosed += 1; audiosrc.PlayOneShot(selection);
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
       
            if (mainOptionChoosed == 3) { mainOptionChoosed = 1; audiosrc.PlayOneShot(selection); }
            if (mainOptionChoosed == 2) { mainOptionChoosed = 0; audiosrc.PlayOneShot(selection); }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
           
            if (mainOptionChoosed == 1) { mainOptionChoosed = 3; audiosrc.PlayOneShot(selection); }
            if (mainOptionChoosed == 0) { mainOptionChoosed = 2; audiosrc.PlayOneShot(selection); }
        }
    }
}
