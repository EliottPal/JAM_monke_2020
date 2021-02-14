using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string Car;

    public void PlayGame()
    {
        Debug.Log("merde");
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CredsScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void BackToMenuFromCarSelection()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void StartOne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Manager.Instance.Value = "Groot";
    }

    public void StartTwo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Manager.Instance.Value = "Mercold";
    }

    public void StartThree()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Manager.Instance.Value = "Pierrafeu";
    }

    public void StartFour()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Manager.Instance.Value = "TerTer";
    }

    public void StartFive()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Manager.Instance.Value = "458Italia";
    }

    public void StartSix()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Manager.Instance.Value = "FefeLambo";
    }

    public void StartSeven()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Manager.Instance.Value = "Peugeot2049";
    }

    public void StartEight()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Manager.Instance.Value = "Cyberpunk";
    }

    public void StartNine()
    {
        Debug.Log("BUY THE BATTLE PASS MAN");
    }

    public void BackToMenuFromCredits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        Car = Manager.Instance.Value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
