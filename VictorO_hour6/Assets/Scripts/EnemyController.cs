using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player; // Reference to the player GameObject
    public float speed = 5f; // Enemy movement speed

    private void Update()
    {
        if (player != null)
        {
            // Calculate direction towards the player
            Vector3 direction = (player.position - transform.position).normalized;

            // Move towards the player
            transform.position += direction * speed * Time.deltaTime;

            // Optionally, you can add rotation towards the player
            //transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // You can add any logic here for when the enemy catches the player
            Debug.Log("Player caught by the enemy!");
            // For example, you might want to restart the game or decrease player health
        }
    }
}
