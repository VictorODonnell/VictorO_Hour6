using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    //A reference to the game manager
    public GameManager gameManager; 

    // Triggers when the player enters the water
    void OnTriggerEnter(Collider other)
    {
        // Check if the collider is tagged as "Lava"
        if (other.CompareTag("Lava"))
        {
            // Moves the player to the spawn point
            gameManager.PositionPlayer();
        }
    }
}
