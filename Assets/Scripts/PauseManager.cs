using UnityEngine;

public class PauseManager: MonoBehaviour
{
    public GameObject pauseMenu;
   
    public GameObject objective;
    public GameObject returnToShed;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        objective.SetActive(false);
        returnToShed.SetActive(false);
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
         objective.SetActive(true);
        returnToShed.SetActive(true);
    }
}
