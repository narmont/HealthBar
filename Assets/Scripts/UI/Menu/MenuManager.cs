using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Menu _menu;
    [SerializeField] private MenuAutors _aboutAutors;

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Autors()
    {
        _menu.gameObject.SetActive(false);
        _aboutAutors.gameObject.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Return()
    {
        _aboutAutors.gameObject.SetActive(false);
        _menu.gameObject.SetActive(true);
    }
}
