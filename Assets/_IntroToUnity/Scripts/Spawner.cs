using UnityEngine;
public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public Transform spawnPoint;

    private bool isSpawned = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isSpawned)
        {
            Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
            isSpawned = true;
        }
    }
}
