using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Help : MonoBehaviour
{
    public bool HelpStart = false;
    public Apple applescript;
    public int Number0fPeople;
    private bool HelpController;

    [SerializeField]
    private int Price = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (HelpStart == true && HelpController == false)
        {
            StartCoroutine("HelpFunction");
        }
    }

    public void OnClick()
    {
        if (applescript.Count >= Price)
        {
            HelpStart = true;
            Number0fPeople += 1;
            applescript.Count -= 10;
        }

    }

    IEnumerator HelpFunction()
    {
        applescript.Count += 1 * Number0fPeople;
        HelpController = true;
        yield return new WaitForSeconds(1);
        HelpController = false;
    }
}