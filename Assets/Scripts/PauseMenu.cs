using UnityEngine;

public class PausedMenu : MonoBehaviour
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
        if (Input.GetKeyUp(keyPausedMenu))
        {
            keyPaused = !keyPaused;
        }

        if (keyPaused)
        {
            pauseMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenu.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
        }
    }

    public void Continue()
    {
        keyPaused = false;
    }
}
