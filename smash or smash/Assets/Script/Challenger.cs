using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.TextCore.Text;
using UnityEditor.SceneManagement;

public class Challenger : MonoBehaviour
{
    [SerializeField] bool isBoris = false;
    [SerializeField] bool isFrenchman = false;
    [SerializeField] bool isCrewmate = false;
    [SerializeField] bool isKaska = false;
    [SerializeField] EventSystem eventSystem;
    [SerializeField] int vie;
    [SerializeField] int mental;
    [SerializeField] int romance;
    [SerializeField] private string nextfight;
    public Character character;
    // Start is called before the first frame update
    void Awake()
    {
        if(isBoris)
        {
            character = new Boris();
        }
        if (isCrewmate)
        {
            character = new Crewmate();
        }
        if (isKaska)
        {
            character = new Kaska();
        }
    }

    private void Update()
    {
        vie = character.vie;
        if (isBoris && character.Vie<=0 || character.Mental<=0)
        {
            LoadScenenextfight();
        }
    }

    public void SetLife(int damage)
    {   

        character.Vie -= damage;
        eventSystem.SetSelectedGameObject(null);
    }

    public void SetMental(int emotionaldamage) {
        if (isBoris && character.Vie>=50) {
            character.Mental -= emotionaldamage/2;
        }
        if(isCrewmate && character.Vie <= 75)
        {
            character.Mental -= emotionaldamage*2;
        }
        else {
            character.Mental -= emotionaldamage;
            eventSystem.SetSelectedGameObject(null);
        }
        
    }

    public void SetRomance(int love)
    {
        if (isBoris && character.Vie<=50) {
            character.Romance += love*2;
        }
        if (isCrewmate && character.Vie <= 75)
        {
            character.Romance += love* 2;
        }
        else {
            character.Romance += love;
            eventSystem.SetSelectedGameObject(null);
        }
        
    }

    void LoadScenenextfight()
    {
        EditorSceneManager.LoadScene(nextfight);
    }
}
