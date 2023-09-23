using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenOutOfBounds : MonoBehaviour
{
    private float topOfScene = 22.0f;
    private float bottomOfScene = -5.5f;
    
    void Update()
    {
        if (transform.position.z > topOfScene)
            Destroy(gameObject);
        else if (transform.position.z < bottomOfScene)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}
