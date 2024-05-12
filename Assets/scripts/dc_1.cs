using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dc_1 : MonoBehaviour
{
public Animator animScene;
    public AudioClip soundstart1;
    public AudioSource audiosrc;
    public int start = 0;
    private float count;
    public GameObject circleObj;
    public bool debug = false;
    public Vector3 _rotobj;
    public int xo;
    public int yo;
    // Start is called before the first frame update
    private IEnumerator Start()
    {
        Invoke("starty", 1);
        start = 1;
       
        GUI.depth = 2;
        while (true)
        {
            count = 1f / Time.unscaledDeltaTime;
            yield return new WaitForSeconds(0.1f);
        }
    }
   public void starty()
    {
        Invoke("entermenu", 10.6f);
        animScene.SetInteger("start", 1);
        audiosrc.PlayOneShot(soundstart1);
        Debug.Log("started");
    }

    private void OnGUI()
    {
        if (debug == true)
        {
            GUI.Label(new Rect(5, 5, 120, 30), "FPS: " + Mathf.Round(count));
        }
    }
   

    public void entermenu()
    {
        SceneManager.LoadScene("menudc");
    }
    // Update is called once per frame
    void Update()
    {
       _rotobj = new Vector3(0, xo, yo);   
        //just debug stuff
        if (start == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
              
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {

           
            debug = true;
        }
        if (debug == true)
        {
             if (Input.GetKey(KeyCode.LeftArrow))
             {
                 xo -= 1;
               
             }
             if (Input.GetKey(KeyCode.RightArrow))
             {
                 xo += 1;
                
             }
             if (Input.GetKey(KeyCode.UpArrow))
             {
                 yo -= 1;
               
             }
             if (Input.GetKey(KeyCode.DownArrow))
             {
                 yo += -1;
                 
             }
            
            circleObj.transform.Rotate(_rotobj * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            animScene.SetInteger("start", 0);
            audiosrc.Stop();
            start = 0;
            Debug.Log("stopped");
           // circleObj.transform.rotation = new Quaternion(0,-90,0,0);
            debug = false;






        }


        }
}
