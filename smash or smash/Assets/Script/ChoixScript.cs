using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoixScript : MonoBehaviour
{
    [SerializeField] GameObject nextDialog1;
    [SerializeField] GameObject nextDialog2;
    [SerializeField] GameObject nextDialog3;
    [SerializeField] GameObject nextDialog4;
    public Button button1, button2, button3, button4;
    bool isReady = false;
    
    void Start()
    {
        if (button1 != null)
            button1.onClick.AddListener(ShowNextDialog1);
        if(button2 != null)
            button2.onClick.AddListener(ShowNextDialog2);
        if (button3 != null)
            button3.onClick.AddListener(ShowNextDialog3);
        if (button4 != null)
            button4.onClick.AddListener(ShowNextDialog4);
    }

    
    public void ShowNextDialog1()
    {
        nextDialog1.GetComponent<Canvas>().enabled = true;
        nextDialog1.GetComponent<DialogScript>().enabled = true;
        this.GetComponent<Canvas>().enabled = false;
    }

    public void ShowNextDialog2()
    {
        nextDialog2.GetComponent<Canvas>().enabled = true;
        nextDialog2.GetComponent<DialogScript>().enabled = true;
        this.GetComponent<Canvas>().enabled = false;
    }

    public void ShowNextDialog3()
    {
        nextDialog3.GetComponent<Canvas>().enabled = true;
        nextDialog3.GetComponent<DialogScript>().enabled = true;
        this.GetComponent<Canvas>().enabled = false;
    }

    public void ShowNextDialog4()
    {
        nextDialog4.GetComponent<Canvas>().enabled = true;
        nextDialog4.GetComponent<DialogScript>().enabled = true;
        this.GetComponent<Canvas>().enabled = false;
        
    }

   public void SetActif(bool isActive)
   {
        this.gameObject.SetActive(isActive);
    }
}
