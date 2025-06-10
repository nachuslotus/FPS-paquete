using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{

    public TextMeshProUGUI Txt_Money;
    public TextMeshProUGUI Txt_Health;

    public void UpdateMoneyText(string money)
    {
        Txt_Money.text = "$" + money; 
     
    }

    public void UpdateHealthText(string healthpoints)
    {
        Txt_Health.text = healthpoints; 
     
    }

}
