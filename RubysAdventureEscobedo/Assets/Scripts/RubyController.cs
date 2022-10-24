using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        // deleted code here, debug
        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal;
        transform.position = position;

        float Vertical = Input.GetAxis("Horizontal");
        Vector2 axis = transform.axis;
        axis.y = axis.y + 0.1f * Vertical;
        transform.axis = axis;
    }
}
