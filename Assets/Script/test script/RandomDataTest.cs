using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDataTest : MonoBehaviour
{
    public int dataNumber;
    public int[] index;
    public int[] data;
    void Start()
    {
        GenerateRandomData();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateRandomData();
        }
    }

    void GenerateRandomData()
    {
        List<int> availableIndices = new List<int>(data.Length);
        for (int i = 0; i < data.Length; i++)
        {
            availableIndices.Add(i);
        }

        for (int i = 0; i < index.Length; i++)
        {
            if (availableIndices.Count == 0)
            {
                Debug.LogError("Tidak ada indeks yang tersedia lagi.");
                break; // Hentikan pengulangan jika tidak ada indeks yang tersedia lagi.
            }

            int randomIndex = Random.Range(0, availableIndices.Count);
            index[i] = availableIndices[randomIndex];
            availableIndices.RemoveAt(randomIndex);

            Debug.Log(index[i]);
        }
    }
}
