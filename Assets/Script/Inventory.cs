using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<SlotData> slots = new List<SlotData>();
    private int maxSlot = 3;  // 슬롯의 갯수
    public GameObject slotPrefab;

    private void Start(){
        GameObject slotPanel = GameObject.Find("Panel");
        for(int i = 0; i < maxSlot; i++){
            GameObject go = Instantiate(slotPrefab, slotPanel.transform, false);
            go.name= "Slot_" + i;
            SlotData a = new SlotData();
            a.isEmpty = true;
            a.slotObj = go;
            slots.Add(a);

        }
    }
}
