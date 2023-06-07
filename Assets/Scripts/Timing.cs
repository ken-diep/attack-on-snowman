using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timing : MonoBehaviour
{
    public float timeElapsed = 0;
    public TMP_Text TimingText;

    void Start()
    {
        TimingText = GetComponent<TextMeshProUGUI>();
        TimingText.text = "Test";
    }

    // Update is called once per frame
    void Update()
    {
        
        //timeElapsed += Time.Delt
        //Debug.Log(Time.realtimeSinceStartup);

        if(!GameObject.FindWithTag("Player"))
        {
            //Reset timer

            Debug.Log("Timer stopped");
        }
        else
        {
            TimingText.text = Time.realtimeSinceStartup.ToString("0.00");
        }
    }
}
