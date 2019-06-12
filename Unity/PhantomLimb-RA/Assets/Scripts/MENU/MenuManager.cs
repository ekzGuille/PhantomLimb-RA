using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Button btnEntreno;
    public Button btnOptions;
    public Button btnExit;
    public Button btnModoLibre;

    // Start is called before the first frame update
    void Start()
    {
        btnEntreno.onClick.AddListener(() => ChangeScene("ShootingMiniGame"));
        btnModoLibre.onClick.AddListener(() => ChangeScene("GameScene"));
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
