using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPoint : MonoBehaviour
{
    public UImanager UImanager;
    public MoneyManager MoneyManager;
    public int dinero = 100;

    void Start()
    {
        MoneyManager = FindObjectOfType<MoneyManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (MoneyManager.UpdateMoney(dinero))
            {
                Destroy(gameObject);
            }


        }
    }
}
