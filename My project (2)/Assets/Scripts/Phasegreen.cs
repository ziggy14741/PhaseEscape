using UnityEngine;
using UnityEngine.InputSystem;

public class Phasegreen : MonoBehaviour
{
    public float phase = 0;
    public SpriteRenderer SR;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SR = GameObject.FindFirstObjectByType<Phasing>().SR;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.zKey.wasPressedThisFrame)
        {
            phase++;
        }
        Collider2D col = GetComponent<Collider2D>();
        if (phase == 3)
        {
            //SR.color = Color.green;
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
        
    }
}
