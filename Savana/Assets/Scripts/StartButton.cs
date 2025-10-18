using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void LoadSceneGame(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }
}
