using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Search;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int vie;
    int mental;
    int romance;

    public int Mental { get => mental; set => mental = value; }
    public int Romance { get => romance; set => romance = value; }
    public int Vie { get => vie; set => vie = value; }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(vie == 0)
        {
            
        }
    }

}
