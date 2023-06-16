using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class buttons : MonoBehaviour
{
    public TMP_Text money;
    public TMP_Text text1, text2, text3, text4, text5;

    public int moneycount;


    private void Start()
    {
        moneycount = 100;
        money.text = ("Money: " + moneycount);

    }



    public void OnMouseDown()
    {

        if (text1.text == "1" && text2.text == "1" && text3.text == "1")
        {
            moneycount = moneycount + 10;

            money.text = ("Money: " + moneycount);
        }

        if (text1.text == "2" && text2.text == "2" && text3.text == "2"
            || text2.text == "2" && text3.text == "2" && text4.text == "2"
            || text3.text == "2" && text4.text == "2" && text5.text == "2")
        {
            moneycount = moneycount + 10;

            money.text = ("Money: " + moneycount);
        }
    }

}
