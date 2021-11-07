using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private GameObject scoreText;

    private int t = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
            this.scoreText.GetComponent<Text>().text = "score:" + t;
    }

    void OnCollisionEnter(Collision other)
    {
        if (tag == "SmallStarTag")
        {
            this.t += 1;
        }
        else if (tag == "LargeStarTag")
        {
            this.t += 3;
        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            this.t += 5;
        }
    }
}