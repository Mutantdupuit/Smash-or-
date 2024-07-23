using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogScript : MonoBehaviour
{
    [SerializeField] GameObject nextDialog;

    public void ShowNextDialog()
    {
        nextDialog.SetActive(true);
        gameObject.SetActive(false);
    }
}
