using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
    
}
