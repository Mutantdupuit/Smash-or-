using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDylan : MonoBehaviour
{
    [SerializeField] GameObject spriteToHide;
    // Start is called before the first frame update
    void Start()
    {
        spriteToHide.SetActive(false);
    }
}
