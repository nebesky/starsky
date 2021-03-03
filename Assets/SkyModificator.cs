using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyModificator : MonoBehaviour
{
    public Skys skyType;

    void Awake()
    {
	    switch (skyType)
	    {
	    	case Skys.water:
	    		if (!SkyManager.showWater)
	    			Destroy(gameObject);
	    	break;

	    	case Skys.fire:
	    		if (!SkyManager.showFire)
	    			Destroy(gameObject);
	    	break;
	    	case Skys.earth:
	    		if (!SkyManager.showEarth)
	    			Destroy(gameObject);
	    	break;
	    	case Skys.air:
	    		if (!SkyManager.showAir)
	    			Destroy(gameObject);
	    	break;
	    	default:
	    	break;   
	    }
	}
}
