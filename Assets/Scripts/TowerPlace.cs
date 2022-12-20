using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlace : MonoBehaviour {
    public GameObject Tower;
    public GameObject currentTower;
    public Vector3 offset;
    public bool isFree = true;

    void OnMouseDown() {
        if (isFree) {
            isFree = false;
            currentTower = Instantiate(Tower, transform.position + offset, Quaternion.identity);
        }
    }
}
