using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrototypeWin : MonoBehaviour
{
    Score score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (score.TrashBags == 6)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
