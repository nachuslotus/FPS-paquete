using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPoint : MonoBehaviour
{
    public UImanager UImanager;
    public HealthManager HealthManager;
    public int vida = 10;

    void Start()
    {
        HealthManager = FindObjectOfType<HealthManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (HealthManager.UpdateHealth(vida))
            {
                Destroy(gameObject);
            }


        }
    }

}
