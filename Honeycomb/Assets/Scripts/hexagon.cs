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

    public void Reset()
    {

    }

    public hexagon[] GetNeighborList()
    {
        return neighbors;
    }

    public void SetFatherHexagon(hexagon f)
    {
        father = f;
    }

    public hexagon GetFatherHexagon()
    {
        return father;
    }
    //able to pass
    public void SetCanPass(bool f)
    {
        isPass = f;
    }

    public bool CanPass()
    {
        return isPass;
    }

    public float ComputeGValue(hexagon hex)
    {
        return 1f;
    }

    public void SetgValue(float v)
    {
        gValue = v;
    }

    public float GetgValue()
    {
        return gValue;
    }

    public void SethValue(float v)
    {
        hValue = v;
    }

    public float GethValue()
    {
        return hValue;
    }

    public float ComputeHValue(hexagon hex)
    {
        return Vector3.Distance(transform.position, hex.transform.position);
    }
}

//Hexagon manager
//openlist[] 
//closelist[]

//void searchRoute()
//int getRouteDistence(Hexagon thisHexagon, Hexagon targetHexagon)