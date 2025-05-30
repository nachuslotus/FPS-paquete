using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{

    public TextMeshProUGUI Txt_Money;

    public void UpdateMoneyText(string money)
    {
        Txt_Money.text = "$" +money; 
     
    }

}
