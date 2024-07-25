using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarresChallenger : MonoBehaviour
{
    [SerializeField] Challenger adversaire;
    public Image Barrevie;
    public int viemax = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int vieactuelle = adversaire.character.vie;
        Barrevie.fillAmount = Mathf.Clamp(vieactuelle / viemax, 0, 1);
    }
}
