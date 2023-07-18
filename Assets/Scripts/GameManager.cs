using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject cactus;
    public GameObject cactusSpawnPosition;
    public float spawnTime;
    float timer;
    public GameObject gameOverScene;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnTime)
        {
            Instantiate(cactus, cactusSpawnPosition.transform);
            timer = 0;
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverScene.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level1");
    }
}
