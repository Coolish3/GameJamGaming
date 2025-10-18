using System;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class DistanceUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textUI;
    void Update()
    {
        textUI.text = "Meters: " + GameManager.Instance.GetDistanceRounded().ToString() + "/nKills: " + GameManager.Instance.GetKills().ToString();
    }

}
