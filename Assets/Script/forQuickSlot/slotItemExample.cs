﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotItemExample : MonoBehaviour
{
    void Update()
    {
        if(Input.inputString == (transform.parent.GetComponent<Slot>().num + 1).ToString()){
            // use item
            Debug.Log("You used item");  // 여기에 아이템 기능을 넣자
            Destroy(this.gameObject);
        }
    }
}
