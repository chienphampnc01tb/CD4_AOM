using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMan : MonoBehaviour
{
    [SerializeField]
    private GameObject Player;
    

    private void Start() {
        Instantiate(Player, transform.position, Quaternion.Euler(0.0f, 0.0f, 0.0f));
    }
}
