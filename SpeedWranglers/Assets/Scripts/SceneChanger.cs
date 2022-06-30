using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void trackone()
    {
        SceneManager.LoadScene("Track1");
    }

    public void tracktwo()
    {
        SceneManager.LoadScene("Track2");
    }
}
