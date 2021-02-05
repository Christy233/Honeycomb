using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public HexagonManager hexagonManager;
    public Hexagon startHex;
    public Hexagon targetHex;
    private float time = 0.0f;
    private int i = 0;
    private List<Hexagon> route = new List<Hexagon>();
    public void Start()
    {
        route = hexagonManager.SearchRoute(startHex, targetHex);
        this.transform.position = startHex.transform.position;
    }

    public void Update()
    {
        TestMove();
    }
    private void TestMove()
    {     
        time += Time.deltaTime;
        if(i < route.Count)
        {
            this.transform.position = route[i].transform.position;
            if (time > 2.0f)
            {
                i++;
                time = 0.0f;
            }
        }
    }

}
