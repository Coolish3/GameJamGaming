using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainButton : MonoBehaviour
{
    public void LoadSceneGame(string SampleScene)
    {
        GameManager.Instance.DestroyGameManager();
        SceneManager.LoadScene(SampleScene);
    }
}
