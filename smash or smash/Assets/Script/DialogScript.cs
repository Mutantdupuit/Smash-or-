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
        if  (nextDialog != null)
            nextDialog.GetComponent<Canvas>().enabled = true;
        if(nextDialog.GetComponent<DialogScript>() != null)
            nextDialog.GetComponent<DialogScript>().enabled = true;
        if (nextDialog.GetComponent<SceneManager>() != null)
            nextDialog.GetComponent<SceneManager>().enabled = true;
        this.GetComponent<Canvas>().enabled = false;
    }
}
