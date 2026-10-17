
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   
    public Transform Target;

  
    public float Cameraspeed = 5f;

  
    public float minX, maxX;
    public float minY, maxY;

    void Start()
    {

    }

    void FixedUpdate()
    {
        if (Target != null)
        {
           
            Vector3 newCamPosition = Vector3.Lerp(
                transform.position,
                new Vector3(
                    Target.position.x,
                    Target.position.y,
                    transform.position.z
                ),
                Cameraspeed * Time.fixedDeltaTime
            );

        
            newCamPosition.x = Mathf.Clamp(
                newCamPosition.x, minX, maxX
            );

            newCamPosition.y = Mathf.Clamp(
                newCamPosition.y, minY, maxY
            );

            // Update camera position
            transform.position = newCamPosition;
        }
    }
}
