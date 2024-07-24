using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenger : MonoBehaviour
{
    [SerializeField] bool isBoris = false;
    [SerializeField] bool isFrenchman = false;
    [SerializeField] bool isCrewmate = false;

    Character character;
    // Start is called before the first frame update
    void Start()
    {
        if(isBoris)
        {
            character = new Boris();
        }
    }

    public void SetLife(int damage)
    {
        character.Vie = damage;
    }

    public void SetMental(int emotionaldamage) {
        if (isBoris && character.Vie>=50) {
            character.Mental = emotionaldamage/2;
        }
        character.Mental = emotionaldamage;
    }

    public void SetRomance(int love)
    {
        if (isBoris && character.Vie<=50) {
            character.Romance = love*10;
        }
        character.Romance = love;
    }
}
