using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    [SerializeField] KeyCode keyPausedMenu;


    bool keyPaused = false;

    public void Start()
    {
        pauseMenu.SetActive(false);
    }
    public void Update()
    {
        AktiveMenu();
    }

    public void AktiveMenu()
    {
        if (Input.GetKeyDown(keyPausedMenu))
        {
            keyPaused = !keyPaused;
        }

        if (keyPaused)
        {
            pauseMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
        }
        else
        {
            pauseMenu.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1
                ;
        }
    }

    public void Continue()
    {
        keyPaused = !keyPaused;
    }

    public void Exit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
