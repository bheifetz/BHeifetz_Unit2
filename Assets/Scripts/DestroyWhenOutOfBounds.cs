using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenOutOfBounds : MonoBehaviour
{
    private float topOfScene = 22.0f;
    private float bottomOfScene = -5.5f;
    
    void Update()
    {
        //I could use an if/elseif to do this, but this does the same thing with half the lines of code.
        if ((transform.position.z > topOfScene) || (transform.position.z < bottomOfScene))
            Destroy(gameObject);
    }
}
