using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [Header("UI Reference")]
    [SerializeField] private TextMeshProUGUI scoreText;

    private int _currentScore = 0;
    
    // This runs as soon as the object is enabled in the scene
    private void OnEnable()
    {
        // Subscribe to the static event from your CollisionTrigger script
        // This means ANY pipe that triggers will tell this manager to AddScore
        ScoreCollisionTrigger.OnPipePassed += AddScore;
    }
    
    // This runs if the object is destroyed or the game stops
    private void OnDisable()
    {
        // Always unsubscribe to prevent memory leaks and "MissingReference" errors
        ScoreCollisionTrigger.OnPipePassed -= AddScore;
    }
    
    void Start()
    {
        UpdateScoreDisplay();
    }

    public void AddScore()
    {
        _currentScore += 1;
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        scoreText.text = _currentScore.ToString();
    }
    

    


}
