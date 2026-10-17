
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject CurrentCheckpoint;

    void Start()
    {
        CurrentCheckpoint = null;
    }

    void Update()
    {

    }

    public void RespawnPlayer()
    {
        if (CurrentCheckpoint != null)
        {
            FindObjectOfType<PlayerController>().transform.position =
                CurrentCheckpoint.transform.position;
        }
    }
}
