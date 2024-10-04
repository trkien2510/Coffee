using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorWC : MonoBehaviour
{
    private bool doorIsOpen = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !doorIsOpen)
        {
            doorIsOpen = true;
            transform.Rotate(0, 0, 90);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        doorIsOpen = false;
        transform.Rotate(0, 0, -90);
    }
}
