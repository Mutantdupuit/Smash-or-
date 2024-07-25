using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Search;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Character player;


    // Start is called before the first frame update
    void Start()
    {
        player =  new Character();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.Vie <= 0)
        {
            // GAME OVER
        }
    }

    public void TakeDamage(int damage)
    {
        player.Vie -= damage;
    }
}
