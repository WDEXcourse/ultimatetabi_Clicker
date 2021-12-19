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

    public GameObject AppleObject;

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

        for (int i = 0; i < Number0fPeople; i++)
        {
            float x = Random.Range(-8, 8);
            Instantiate(AppleObject.gameObject, new Vector3(x, 4.13f, 0), Quaternion.identity);
        }
        yield return new WaitForSeconds(1);
        HelpController = false;
    }
}