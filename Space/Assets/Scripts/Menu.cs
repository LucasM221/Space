using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string NomeCena;
    public GameObject MenuPanel;

    // Start is called before the first frame update
    void Start()
    {
        // Ativando MenuPanel
        MenuPanel.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //  Função do botão start
    public void StartGame() 
    {
        // Carregando a cena Game
        SceneManager.LoadScene(NomeCena);
    }
}
