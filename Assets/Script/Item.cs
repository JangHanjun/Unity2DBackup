using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //아이템 종류와 값을 저장할 변수들
    public enum  Type { Coin, Heart, Weapon};
    public Type type;
    public int value;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag =="Player"){
            if(PlayerMove.MaxHp == PlayerMove.currentHp){
                Debug.Log("피가 만땅!");
            }else{
                PlayerMove.currentHp += 1f;
                Destroy(gameObject);
            }
        }
        /*
        if(collision.gameObject.tag =="Player"){
            Debug.Log("공격력 증가");
            Destroy(gameObject);
            playerAttack.atk += 1;

            
            PlayerMove.currentHp/PlayerMove.MaxHp
            Debug.Log("속도 증가");
            Destroy(gameObject);
            PlayerMove.maxSpeed *= 3;
        }
        */
    }
}
