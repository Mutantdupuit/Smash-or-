using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Dialog;
    [SerializeField] TextMeshProUGUI Name;
    class Personnage
    {
        public string name;
        int id_dialog = 0;
        public List<Dialogue> dialogs;

        public Personnage(string name)
        {
            this.name = name;
            dialogs = new List<Dialogue>();
            dialogs.Add(new Dialogue("Salut"));
            dialogs.Add(new Dialogue("D'accord ça me vas"));
            dialogs.Add(new Dialogue("Va chier!"));


        }

        public void Reponse()
        {

        }


    }
    // Start is called before the first frame update
    void Start()
    {
        Personnage barman = new Personnage("barman");
        Dialog = GameObject.Find("dialogue").GetComponent<TextMeshProUGUI>();
        Dialog.text = barman.dialogs[0].dialog;
        Name = GameObject.Find("Name_Text").GetComponent<TextMeshProUGUI>();
        Name.text = barman.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
