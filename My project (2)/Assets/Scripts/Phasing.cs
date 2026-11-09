using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Phasing : MonoBehaviour
{
    public static PhaseState mode;
    public SpriteRenderer SR;
    public PhaseState State = PhaseState.normal;
    public float phaser = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public List<PhaseState> phaseStates = new List<PhaseState>()
    {
        PhaseState.normal,
        PhaseState.red,
        PhaseState.blue,
        PhaseState.green
    };
    public int PhaseStateIndex = 0;

   
    
    public void SetState(PhaseState s)
    {
        State = s;

        if (State == PhaseState.normal)
        {
            SR.color = Color.white;
        } 
        if(State == PhaseState.red)
        {
            SR.color = Color.red;
        }
        if(State == PhaseState.blue)
        {
            SR.color = Color.blue;
        }
        if(State == PhaseState.green)
        {
            SR.color = Color.green;
        }

        
    }
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.zKey.wasPressedThisFrame)
        {
            phaser++;
        }
        if(phaser == 0)
        {
            SR.color = Color.white;
        }
        if (phaser == 1)
        {
            SR.color = Color.red;
        }
        if (phaser == 2)
        {
            SR.color = Color.blue;
        }
        if(phaser == 3)
        {
            SR.color = Color.green;
        }
        if(phaser >= 4)
        {
            phaser = 0;
        }
        
        /*if (Keyboard.current.zKey.wasPressedThisFrame)
        {
            phaser++;
        }
        Collider2D col = GetComponent<Collider2D>();

        if(phaser == 0)
        {
            col.enabled = true;
        }
        else
        {
            col.enabled = false;
        }  

        if(phaser == 1)
        
        switch (State)
        {
            case PhaseState.normal:
                {
                    col.enabled = true;
                    break;
                }
            case PhaseState.red:
                {
                    col.enabled = true;
                    break;
                }
            case PhaseState.blue:
                {
                    col.enabled = true;
                    break;
                }
            case PhaseState.green:
                {
                    col.enabled = true;
                    break;
                }*/

    }
    }
   
 public enum PhaseState
    {
        normal = 0,
        red = 1,
        blue = 2,
        green = 3
    }