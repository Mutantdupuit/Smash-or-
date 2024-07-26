using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BarresCharacter : MonoBehaviour
{
    [SerializeField] Character character;
    public Image Barrevie;
    public const float viemax = 100.0f;
    public Image Barremental;
    public const float mentalmax = 100.0f;
    public Image Barreromance;
    public const float romancemax = 100.0f;

    [SerializeField] string nameCharacter;
    [SerializeField] bool isPlayer;

    // Start is called before the first frame update
    void Start()
    {
        if(isPlayer){
            character = GameObject.FindFirstObjectByType<GameManager>().player;
        }
        else
        {
            Challenger challenger = FindObjectOfType<Challenger>();
            //GameObject challenger = GameObject.Find(nameCharacter);
            //character = challenger.GetComponent<Challenger>().character;
            character = challenger.character;
        }

    }

    // Update is called once per frame
    void Update()
    {
        int vieactuelle = character.vie;
        Barrevie.fillAmount = Mathf.Clamp(vieactuelle / viemax, 0, 1);
        if (Barremental != null)
        {
            int mentalactuel = character.mental;
            Barremental.fillAmount = Mathf.Clamp(mentalactuel / mentalmax, 0, 1);
        }
        if (Barreromance != null)
        {
            int romanceactuelle = character.romance;
            Barreromance.fillAmount = Mathf.Clamp(romanceactuelle / romancemax, 0, 1);
        }
    }
}
