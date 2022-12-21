using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTriger : MonoBehaviour
{
    public Button Button;
    public PlayerControl playerControl;

    private void OnTriggerEnter(Collider other)
    {
        Button.gameObject.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        Button.gameObject.SetActive(false);
    }

    public void OnButtonClick()
    {
        playerControl.StartJump();
        Button.gameObject.SetActive(false);
    }
}
