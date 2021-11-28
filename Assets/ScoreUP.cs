using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUP : MonoBehaviour
{
    public int scoreup;
    public Apple applescript;

    [SerializeField]
    private int Price = 10;

    // Start is called before the first frame update
    void Start()
    {
        scoreup = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if (applescript.Count >= Price)
        {
            applescript.Count -= Price;
            scoreup += 1;
        }
    }
}
