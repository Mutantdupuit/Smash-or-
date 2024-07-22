using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class Dialogue
{
    public string dialog;
    List<Choix> choix;

    public Dialogue(string dialog){
        this.dialog = dialog;
        choix = new List<Choix> { new Choix(1), new Choix(2) };
    }

    protected Button choix1, choix2, choix3, choix4;

    protected int action(int choix)
    {
        return this.choix[choix].Action();
    }
}

class Choix
{
    public int id;
    int vie;
    int mental;
    int romance;

    public Choix(int id, int vie = 0, int mental = 0, int romance = 0)
    {
        this.id = id;
        this.vie = vie;
        this.mental = mental;
        this.romance = romance;
    }

    public virtual int Action()
    {
        return id;
    }
}

