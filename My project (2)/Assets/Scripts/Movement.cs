using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float speed = 5;
    public float jump = 3;
    public float boost = 2;
    public Rigidbody2D rig;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = new Vector2(0, 0);
        if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("n");
            vel.x = speed;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("w");
            vel.x = -speed;
        }    
        if (Keyboard.current.wKey.isPressed)
        {            
            vel.y = speed;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            vel.y = -speed;
        }
        rig.linearVelocity = vel;
    }
}
