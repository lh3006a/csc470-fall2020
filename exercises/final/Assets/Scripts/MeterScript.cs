using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeterScript : MonoBehaviour
{
	public Color meterColor;
	public Image MeterFG;
	public Image MeterFGBG;
	//public int filled;

	float meterRate = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
    	MeterFG.color = new Color(meterColor.r, meterColor.g, meterColor.b, 1);

    }

    // Update is called once per frame
    void Update()
    {
    	if(MeterFGBG.fillAmount > MeterFG.fillAmount){
    		MeterFGBG.fillAmount -= meterRate * Time.deltaTime;
    	}

    }
    public void SetMeter(float val){
    	MeterFG.fillAmount = val;
    }
}
