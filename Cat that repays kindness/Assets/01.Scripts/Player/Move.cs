using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // 테스트 용
    private Rigidbody2D rigid;
    
    float speed = 500f;

    private void Awake() {
        
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector2 dir = new Vector2(x, y);

        rigid.velocity = dir.normalized * speed;
    }
}
