using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject Menu;
    public Button buttonReturn;
    public Button buttonRestart;
    // Start is called before the first frame update
    void Start()
    {
        buttonRestart.onClick.AddListener(Restart);
        buttonReturn.onClick.AddListener(Return);
        Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Return();
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Return();
    }

    void Return()
    {
        Menu.SetActive(!Menu.activeSelf);
        if (Menu.activeSelf)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
