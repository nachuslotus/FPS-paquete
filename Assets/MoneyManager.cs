using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public UImanager UImanager;

     void Start()
    {
        UImanager = FindObjectOfType<UImanager>();   
    }
    public bool UpdateMoney(float amount)
    {
        if (money + amount < 0)
        {
            // impedir la compra
            return false;
        }
        else
        {
            money += amount;
            UImanager.UpdateMoneyText(money.ToString());
            return true;
        }

      
    }
}
