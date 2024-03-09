using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetScore : MonoBehaviour
{
    private GameController GameController;
    public TMP_Text score;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score: " + GameController.score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
