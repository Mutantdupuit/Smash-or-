using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogScript : MonoBehaviour
{
    [SerializeField] GameObject nextDialog;
    bool isReady = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShowNextDialog();
        }
    }
    public void ShowNextDialog()
    {
        nextDialog.GetComponent<Canvas>().enabled = true;
        nextDialog.GetComponent<DialogScript>().enabled = true;
        gameObject.SetActive(false);
    }
}
