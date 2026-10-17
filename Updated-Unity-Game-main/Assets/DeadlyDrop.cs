
using UnityEngine;

public class DeadlyDrop : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            FindObjectOfType<LevelManager>().RespawnPlayer();
        }
    }
}
