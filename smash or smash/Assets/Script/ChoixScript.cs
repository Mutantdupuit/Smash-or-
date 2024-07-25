using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChoixScript : MonoBehaviour
{
    [SerializeField] GameObject nextDialog1;
    [SerializeField] GameObject nextDialog2;
    [SerializeField] GameObject nextDialog3;
    [SerializeField] GameObject nextDialog4;
    [SerializeField] EventSystem eventSystem;
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
        if (nextDialog1.GetComponent<DialogScript>() != null)
            nextDialog1.GetComponent<DialogScript>().enabled = true;
        this.GetComponent<Canvas>().enabled = false;
        eventSystem.SetSelectedGameObject(null);
    }

    public void ShowNextDialog2()
    {
        nextDialog2.GetComponent<Canvas>().enabled = true;
        if(nextDialog2.GetComponent<DialogScript>() != null)
            nextDialog2.GetComponent<DialogScript>().enabled = true;
        this.GetComponent<Canvas>().enabled = false;
        eventSystem.SetSelectedGameObject(null);
    }

    public void ShowNextDialog3()
    {
        nextDialog3.GetComponent<Canvas>().enabled = true;
        if (nextDialog3.GetComponent<DialogScript>() != null)
            nextDialog3.GetComponent<DialogScript>().enabled = true;
        this.GetComponent<Canvas>().enabled = false;
        eventSystem.SetSelectedGameObject(null);
    }

    public void ShowNextDialog4()
    {
        nextDialog4.GetComponent<Canvas>().enabled = true;
        if (nextDialog4.GetComponent<DialogScript>() != null)
            nextDialog4.GetComponent<DialogScript>().enabled = true;
        this.GetComponent<Canvas>().enabled = false;
        eventSystem.SetSelectedGameObject(null);

    }

   public void SetActif(bool isActive)
   {
        this.gameObject.SetActive(isActive);
   }

    public void SetSceneSystem(GameObject sceneManager)
    {
        if (sceneManager.GetComponent<SceneManager>() != null)
             sceneManager.GetComponent<SceneManager>().enabled = true;
    }
}
