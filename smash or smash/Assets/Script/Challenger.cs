using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.TextCore.Text;

public class Challenger : MonoBehaviour
{
    [SerializeField] bool isBoris = false;
    [SerializeField] bool isFrenchman = false;
    [SerializeField] bool isCrewmate = false;
    [SerializeField] EventSystem eventSystem;
    [SerializeField] int vie;
    [SerializeField] int mental;
    [SerializeField] int romance;
    public Character character;
    // Start is called before the first frame update
    void Awake()
    {
        if(isBoris)
        {
            character = new Boris();
        }
    }

    private void Update()
    {
        vie = character.vie;
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
        else {
            character.Romance += love;
            eventSystem.SetSelectedGameObject(null);
        }
        
    }
}
