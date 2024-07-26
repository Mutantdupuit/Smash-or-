using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Character player;
    [SerializeField] private string GameOver;


    // Start is called before the first frame update
    void Awake()
    {
        player =  new Character();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.Vie <= 0)
        {
            LoadScene2();
            // GAME OVER
        }
    }

    public void TakeDamage(int damage)
    {
        player.Vie -= damage;
    }

    void LoadScene2()
    {
        EditorSceneManager.LoadScene(GameOver);
    }
}
