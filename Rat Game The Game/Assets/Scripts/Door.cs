using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform PlayerCamera;
    public float MaxDistance = 5;

    private bool opened = false;
    private Animator anim;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            Pressed();
        }
    }

    void Pressed()
    {
        RaycastHit doorhit;

        if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out doorhit, MaxDistance))
        {
            if (doorhit.transform.tag == "Door")
            {
                anim = doorhit.transform.GetComponent<Animator>();

                opened = !opened;

                anim.SetBool("Opening", !opened);
            }
        }
    }
}
