using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MightModificator : MonoBehaviour
{
	public Might mightType;
	
    void Awake()
    {
    	if (mightType == Might.ultima && SkyManager.energy == Might.ultima)
    	{
    		return;
    	}

    	if (mightType == Might.maxima && 
    		(SkyManager.energy == Might.ultima || 
    		 SkyManager.energy == Might.maxima))
    	{
    		return;
    	}

    	if (mightType == Might.simpla && 
    		(SkyManager.energy == Might.ultima || 
    		SkyManager.energy == Might.maxima ||
    		SkyManager.energy == Might.simpla))
    	{
    		return;
    	}
	    
	    Destroy(gameObject);	
	}
}