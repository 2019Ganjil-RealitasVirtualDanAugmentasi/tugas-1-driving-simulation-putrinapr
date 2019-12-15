using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 6f;
    //[SerializeField]
    private string SampleScene;
    private float timeElapsed;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delayBeforeLoading)

        {
            SceneManager.LoadScene("LevelSelectMenu");
        }

    }
}