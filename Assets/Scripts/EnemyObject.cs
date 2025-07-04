using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyObject : MonoBehaviour
{
    public int daño = 5;
    public HealthManager HealthManager;

    // Start is called before the first frame update
    void Start()
    {
        HealthManager = FindObjectOfType<HealthManager>();
    }

    
   



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag ("Player"))
        {
            if (HealthManager.UpdateHealth(daño))
            {
                Destroy(gameObject);
            }
            
            
        }
    }
    
}
