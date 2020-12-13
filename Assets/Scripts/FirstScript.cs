using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstScript : MonoBehaviour
{
    public Button button;
    public string nextScene;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
        Debug.Log("GameObject Start called");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("GameObject Update called");
    }

    void OnButtonClick()
    {
        Debug.Log("Button was clicked!");
        SceneManager.LoadScene(nextScene);
    }
}
