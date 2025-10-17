using System;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class DistanceUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI DistanceText;
    [SerializeField] private Transform MetersRan;

    private float startingLineLoc;
    private float currentDistanceExact;
    private float currentDistanceRounded;
    void Start()
    {
        startingLineLoc = MetersRan.transform.position.x;
    }
    void Update()
    {
        currentDistanceExact = MetersRan.transform.position.x - startingLineLoc;
        currentDistanceRounded = Mathf.Floor(currentDistanceExact);
        DistanceText.text = currentDistanceRounded.ToString();
    }

}
