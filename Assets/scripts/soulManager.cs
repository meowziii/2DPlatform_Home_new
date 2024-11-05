using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soulManager : MonoBehaviour
{
    public int soulCount;
    public Text soulText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        soulText.text = ": "+ soulCount.ToString();
    }
}
