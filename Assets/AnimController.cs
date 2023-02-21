using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    [SerializeField] private Animator ani;
    private void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        
        if (input < 1)
        {
            ani.SetFloat("Walk", Mathf.Abs(input));
        }
        else if (input > 0)
        {
            ani.SetFloat("Walk", Mathf.Abs(input));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ani.SetFloat("Jump", Mathf.Abs(1));
        }
        else
        {
            ani.SetFloat("Jump", Mathf.Abs(0));
        }

    }
}
