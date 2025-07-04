using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColiciones : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto con" + collision.gameObject.name);

        if (collision.gameObject.name == "Sphere")
        {
            Destroy(gameObject);
        }
    }

}
