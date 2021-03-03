using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Might {
	simpla,
	maxima,
	ultima
}

public enum Skys {
	air,
	water,
	earth,
	fire,
	high
}

public static class SkyManager
{
    public static Might energy = Might.ultima;

    public static bool showAir = true;
    public static bool showWater = true;
    public static bool showEarth = true;
    public static bool showFire = true;
}
