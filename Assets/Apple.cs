using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Apple : MonoBehaviour
{
    private Vector3 mousePosition;
    private bool SizeChange = false;
    private float SizeTimer = 0;

    private int Increase = 1;
    public GameObject IncreaseTextObject;
    public Text IncreaseText;
    public GameObject canvas;
    public int Count;
    public Text CountText;

    public ScoreUP scoreupscript;
    public GameObject AppleObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CountText.text = Count.ToString();
        Increase = 1 * scoreupscript.scoreup;
        IncreaseText.text = "+" + Increase.ToString();
        if (SizeChange == true)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(1, 1, 1), Time.deltaTime * 10);
            SizeTimer += Time.deltaTime;

            if (SizeTimer >= 0.3f)
            {
                this.transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(2, 2, 2), Time.deltaTime * 10);
                if (SizeTimer >= 0.6f)
                {
                    SizeTimer = 0;
                    SizeChange = false;
                }
            }
        }
    }
    public void OnClickAct()
    {
        SizeChange = true;

        Count += 1 * scoreupscript.scoreup;
        mousePosition = Input.mousePosition;
        GameObject IncreaseTexts = (GameObject)Instantiate(IncreaseTextObject);
        IncreaseTexts.transform.SetParent(canvas.transform, false);
        IncreaseTexts.transform.position = mousePosition;
        Vector3 force = gameObject.transform.up * 1000f;
        IncreaseTexts.GetComponent<Rigidbody2D>().AddForce(force);
        Destroy(IncreaseTexts.gameObject, 0.5f);

        for(int i = 0; i < 1 *scoreupscript.scoreup; i++)
        {
            float x = Random.Range(-8, 8);
            GameObject apple = Instantiate(AppleObject.gameObject,new Vector3(x,412f,0),Quaternion.identity);
            Destroy(apple.gameObject, 2f);
        }
}
}