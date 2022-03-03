using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    Image timerbar;
    public float maxTime=5f;
    float timeleft;
     public GameObject timesUpText;
    // Start is called before the first frame update
    void Start()
    {
        timesUpText.SetActive(false);
        timerbar =GetComponent<Image> ();
        timeleft=maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeleft>0){
            timeleft-=Time.deltaTime;
            timerbar.fillAmount=timeleft/maxTime;
        }
        else{
           timesUpText.SetActive(true);
           Time.timeScale=0;
           
        }
        
    }
}
