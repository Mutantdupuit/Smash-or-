using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class ActionScript : MonoBehaviour
{
    [SerializeField] GameObject nextDialog;
    bool isReady = false;
    [SerializeField] private string nextfight;
    [SerializeField] private string mariage;
    [SerializeField] Challenger challenger;
    [SerializeField] bool isnotRomance = false;
    private void Start()
    {
    }

    private void Update()
    {
        if (isnotRomance == true && Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            ShowNextDialog();
        }
        challenger.vie = challenger.character.vie;
        if (isnotRomance == true && challenger.character.Vie <= 0 || challenger.character.Mental <= 0)
        {
            LoadScenenextfight();
        }
        if (isnotRomance == false && challenger.character.Romance >= 100)
        {
            LoadSceneMariage();
            //mariage
        }
        if (isnotRomance == false && Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            ShowNextDialog2();
        }
    }
    public void ShowNextDialog()
    {
        if (nextDialog != null)
            nextDialog.GetComponent<Canvas>().enabled = true;
        if (nextDialog.GetComponent<DialogScript>() != null)
            nextDialog.GetComponent<DialogScript>().enabled = true;
        if (nextDialog.GetComponent<SceneManager>())
            nextDialog.GetComponent<SceneManager>().enabled = true;
        nextDialog.SetActive(true);
        if(isnotRomance == true)
            FindFirstObjectByType<GameManager>().TakeDamage(FindFirstObjectByType<Challenger>().character.force);
        this.GetComponent<Canvas>().enabled = false;
        this.enabled = false;
    }

    public void ShowNextDialog2()
    {
        if (nextDialog != null)
            nextDialog.GetComponent<Canvas>().enabled = true;
        if (nextDialog.GetComponent<DialogScript>() != null)
            nextDialog.GetComponent<DialogScript>().enabled = true;
        if (nextDialog.GetComponent<SceneManager>())
            nextDialog.GetComponent<SceneManager>().enabled = true;
        nextDialog.SetActive(true);
        if (isnotRomance == true)
            FindFirstObjectByType<GameManager>().TakeDamage(FindFirstObjectByType<Challenger>().character.force);
        this.GetComponent<Canvas>().enabled = false;
        this.enabled = false;
    }
    void LoadScenenextfight()
    {
        EditorSceneManager.LoadScene(nextfight);
    }

    void LoadSceneMariage()
    {
        EditorSceneManager.LoadScene(mariage);
    }



}
