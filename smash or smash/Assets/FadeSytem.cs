using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeSystem : MonoBehaviour
{
    [SerializeField] GameObject image;

    public void FadeOut()
    {
        image.SetActive(false);
    }
}
