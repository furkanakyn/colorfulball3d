using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Touch touch;
    private Rigidbody rb;
    public int speedModifier;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                rb.velocity = new Vector3(touch.deltaPosition.x * speedModifier * Time.deltaTime,
                                          transform.position.y,
                                          touch.deltaPosition.y * speedModifier * Time.deltaTime);
            }
        }
    
    
    
    
    
    }
}
