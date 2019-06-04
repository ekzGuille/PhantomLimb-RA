using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsManager : MonoBehaviour
{
  
    public Button btnAtras;


    // Start is called before the first frame update
    void Start()
    {
      btnAtras.onClick.AddListener(() => ChangeScene("Main_Menu"));
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
