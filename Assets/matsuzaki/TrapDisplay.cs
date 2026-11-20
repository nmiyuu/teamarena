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

        //ランダムで罠を7個表示
        for (int i = 0; i < TrapCount; i++)
        {
            int RandomIndex = Random.Range(0, traps.Count);

            if (traps[RandomIndex].activeSelf == false)
            {
                traps[RandomIndex].SetActive(true);
            }
            else
            {
                while (traps[RandomIndex].activeSelf == true)
                {
                    RandomIndex = Random.Range(0, traps.Count);
                }
                traps[RandomIndex].SetActive(true);
            }
        }
    }
}
