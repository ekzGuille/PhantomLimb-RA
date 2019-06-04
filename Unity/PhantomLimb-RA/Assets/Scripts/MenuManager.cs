using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Button btnStart;
    public Button btnOptions;
    public Button btnExit;

    // Start is called before the first frame update
    void Start()
    {
        btnStart.onClick.AddListener(() => ChangeScene("GameScene"));
        btnOptions.onClick.AddListener(() => ChangeScene("Settings_Menu"));
        btnExit.onClick.AddListener(Application.Quit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
