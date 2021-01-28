using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hexagon : MonoBehaviour
{
    hexagon father = null;
    public hexagon[] neighbors = new hexagon[6];
    public bool isPass = true;
    private float gValue = 999f;
    private float hValue = 999f;

    public void reset()
    {

    }

    public hexagon[] getNeighborList()
    {
        return neighbors;
    }

    public void setFatherHexagon(hexagon f)
    {
        father = f;
    }

    public hexagon getFatherHexagon()
    {
        return father;
    }

    public void setCanPass(bool f)
    {
        isPass = f;
    }

    public bool canPass()
    {
        return isPass;
    }

    public float computeGValue(hexagon hex)
    {
        return 1f;
    }

    public void setgValue(float v)
    {
        gValue = v;
    }

    public float getgValue()
    {
        return gValue;
    }

    public void sethValue(float v)
    {
        hValue = v;
    }

    public float gethValue()
    {
        return hValue;
    }

    public float computeHValue(hexagon hex)
    {
        return Vector3.Distance(transform.position, hex.transform.position);
    }
}

