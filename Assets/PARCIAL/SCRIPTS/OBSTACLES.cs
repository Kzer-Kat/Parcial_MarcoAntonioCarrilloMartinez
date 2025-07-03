using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField] private GameObject prefabObstacles; // Variable para guardar los obstaculos
    [SerializeField] private float speed = 5f; // Variable para saber la velocidad de los obstaculos
    [SerializeField] private float spawnTime = 2f; // Variable para saber el tiempo de spawn de los obstaculos
    [SerializeField] private float negativeAreaY = -1f; // Variable para saber la posici�n Y negativa de los obstaculos
    [SerializeField] private float positiveAreaY = 3f; // Variable para saber la posici�n Y positiva de los obstaculos
    [SerializeField] private float positionSpawnX = 11f; // Variable para saber la posici�n X de los obstaculos
    [SerializeField] private float positionSpawnZ = -1.5f; // Variable para saber la posici�n Z de los obstaculos

    private void Start()
    {
        StartCoroutine(SpawnObstacles());
    }

    private void MoveObstacles()
    {
        float posicionY = Random.Range(negativeAreaY, positiveAreaY);  // Genera una posici�n Y aleatoria dentro del rango especificado
        Vector3 posicionSpawn = new Vector3(positionSpawnX, posicionY, positionSpawnZ);  // Define la posici�n de spawn del enemigo
        GameObject clone = Instantiate(prefabObstacles, posicionSpawn, Quaternion.identity); // Instancia el enemigo en la posici�n de spawn
        Rigidbody rb = clone.GetComponent<Rigidbody>(); // Obtener el componente Rigidbody del enemigo
        rb.AddForce(Vector3.left * speed, ForceMode.Impulse); // Aplicar fuerza al enemigo para que se mueva hacia la izquierda
        Destroy(clone, 15f); // Destruir el enemigo despu�s de 15 segundos
    }

    IEnumerator SpawnObstacles()
    {
        while (true) // Bucle infinito
        {
            MoveObstacles();
            yield return new WaitForSeconds(spawnTime); // Espera 2 segundos antes de volver a llamar a MoveObstacles
        }
    }
}