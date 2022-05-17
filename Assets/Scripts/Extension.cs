using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
static class Extension
{
    public static bool IsEqualTo(this Color me, Color other)
    {
        return Math.Round(me.r,3) == Math.Round(other.r,3) && Math.Round(me.g,3) == Math.Round(other.g,3) && Math.Round(me.b,3) == Math.Round(other.b,3) && Math.Round(me.a,3) == Math.Round(other.a,3);
    }
}
