using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public GameObject bulletPrefab; // drag prefab here in Inspector
    public float bulletSpeed = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Create bullet
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            // Give it some forward motion
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = transform.forward * bulletSpeed;
            }
        }
    }
}