using TMPro;
using UnityEngine;

public class GameOverKillNumber : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;

    void Start()
    {
        textMeshProUGUI.text = "Kills: " + GameManager.Instance.GetKills().ToString();
    }
}
