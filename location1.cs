using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class location1 : MonoBehaviour
{
    public GameObject text;
    static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        score = score + 1;
        print(score);
        if(score == 5)
        {
            SceneManager.LoadScene("scene3");
        }
        Destroy(gameObject);
        Destroy(text);
        

    }
}
