using UnityEngine;
using System.Collections.Generic;

public class TrapDisplay : MonoBehaviour
{
    //トラップをまとめているのでList
    public List<GameObject> traps;

    //トラップは最低７個は表示させる
    public int TrapCount = 7;

    void Start()
    {
        for (int i = 0; i < traps.Count; i++)
        {
            traps[i].SetActive(false);
        }
    }

    void Update()
    {
        
    }
}
