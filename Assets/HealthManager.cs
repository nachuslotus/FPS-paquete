using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int healthpoints;
    public UImanager UImanager;
    // Start is called before the first frame update
    void Start()
    {
        UImanager = FindObjectOfType<UImanager>(); 
    }

   public bool UpdateHealth(int damageamount){

      if(healthpoints <= damageamount){
           
           Debug.Log("Perdiste");
           return false;
      }
      healthpoints -= damageamount;
      UImanager.UpdateHealthText(healthpoints.ToString());
      return true;
   }
}
