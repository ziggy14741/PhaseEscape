using UnityEngine;
using UnityEngine.InputSystem;

public class Phaseblue : MonoBehaviour
{
    public float phase = 0;
    public SpriteRenderer SR;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.zKey.wasPressedThisFrame)
        {
            phase++;
        }
        Collider2D col = GetComponent<Collider2D>();
        if (phase == 2)
        {
            //SR.color = Color.blue;
            col.enabled = false;
        }
        else
        {
            col.enabled = true;
        }
        if (phase >= 4)
        {
            phase = 0;
        }
        if (phase == 0)
        {
            SR.color = Color.white;
        }
    }
}
