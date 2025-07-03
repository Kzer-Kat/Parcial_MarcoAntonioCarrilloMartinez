using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
    // Destruye el objeto cuando colisiona con "EndLayer" o "ground"
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EndLayer" ) || collision.gameObject.CompareTag("ground"))
        {
            Destroy(gameObject);
        }
    }
}
