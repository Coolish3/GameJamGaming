using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform MetersRan;
    private float gameTime = 0;
    private int totalKills = 0;
    private float startingLineLoc;
    private float currentDistanceExact;
    private int currentDistanceRounded;

    public static GameManager Instance { get; private set; }

    // Step 2: Initialize in Awake()
    private void Awake()
    {
        // If there’s already an instance and it’s not this one, destroy this copy
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        // Set the instance
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        startingLineLoc = MetersRan.transform.position.x;
    }
    void Update()
    {
        gameTime += Time.deltaTime;
        if (MetersRan != null)
        {
            currentDistanceExact = MetersRan.transform.position.x - startingLineLoc;
            currentDistanceRounded = Mathf.FloorToInt(currentDistanceExact);
        }

    }

    public void SetKill()
    {
        totalKills++;
    }

    public float GetTime()
    {
        return gameTime;
    }
    public int GetKills()
    {
        return totalKills;
    }
    public float GetDistanceExact()
    {
        return currentDistanceExact;
    }
    public int GetDistanceRounded()
    {
        return currentDistanceRounded;
    }

    public void DestroyGameManager()
    {
        Destroy(gameObject);
    }
}
