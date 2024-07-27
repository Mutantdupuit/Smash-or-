using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Menu : MonoBehaviour
{
    [SerializeField] private string NameScene;
    [SerializeField] EventSystem eventSystem;
    [SerializeField] GameObject nextDialog1;
    public Button button1, button2, button3;
    // Start is called before the first frame update
    void Start()
    {
        if (button1 != null)
            button1.onClick.AddListener(LoadScene);
        if (button2 != null)
            button2.onClick.AddListener(Quitter);
        if(button3 != null)
            button3.onClick.AddListener(ShowNextDialog1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadScene()
    {
        SceneManager.LoadScene(NameScene);
    }

    void Quitter() { 
        Application.Quit();
    }

    public void ShowNextDialog1()
    {
        nextDialog1.GetComponent<Canvas>().enabled = true;
        if (nextDialog1.GetComponent<DialogScript>() != null)
            nextDialog1.GetComponent<DialogScript>().enabled = true;
        if (nextDialog1.GetComponent<ActionScript>() != null)
            nextDialog1.GetComponent<ActionScript>().enabled = true;
        this.GetComponent<Canvas>().enabled = false;
        eventSystem.SetSelectedGameObject(null);
    }
}
