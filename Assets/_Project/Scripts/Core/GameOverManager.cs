using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    
    // This runs as soon as the object is enabled in the scene
    private void OnEnable()
    {
        // Subscribe to the static event from your CollisionTrigger script
        // This means ANY pipe that triggers will tell this manager to AddScore
        GameOverCollisionTrigger.OnPipeHit += GameOver;
    }
    
    // This runs if the object is destroyed or the game stops
    private void OnDisable()
    {
        // Always unsubscribe to prevent memory leaks and "MissingReference" errors
        GameOverCollisionTrigger.OnPipeHit -= GameOver;
    }
    
    public void RestartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        FlapMotor.Instance.FlapStrength = 0f;
    }
}
