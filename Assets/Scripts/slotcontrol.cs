using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class slotcontrol : MonoBehaviour
{

    public char[] numbersRand = { '1', '2', '3'};
    public TMP_Text slotNum;
    public float time;
 
    void Update()
    {
        slotNum.text = numbersRand[Random.Range(0, numbersRand.Length)].ToString();

     
        
    }

    public void OffEnable()
    {
        Invoke("DelayNum", time);

    }

    public void WhenEnable()
    {
        enabled = true;
        
    }


    public void DelayNum()
    {
        enabled = false;
        

       
    }
}
