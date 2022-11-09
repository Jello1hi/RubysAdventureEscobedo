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
        position.x = position.x + 5f * horizontal * Time.deltaTime;
        transform.position = position;

        float Vertical = Input.GetAxis("Vertical");
        Debug.Log(Vertical);
        Vector2 axis = transform.position;
        axis.y = axis.y + 5f * Vertical * Time.deltaTime;
        transform.position = axis;
    }
}
