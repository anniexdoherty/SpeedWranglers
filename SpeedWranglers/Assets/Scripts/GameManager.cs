using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
<<<<<<< Updated upstream
    
=======
>>>>>>> Stashed changes

    public GameObject titleScreen;

    public string gameSceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartEasyTrack()
    {
        SceneManager.LoadScene("race_track_lake");    
    }

    public void StartHardTrack()
    {

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
