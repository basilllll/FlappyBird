using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float speed;
    public float deadPos;

    void Update()
    {
        transform.position += ((Vector3.left*speed)*Time.deltaTime);
        if (transform.position.x < deadPos)
        {
            Destroy(gameObject);
        }
    }
}
