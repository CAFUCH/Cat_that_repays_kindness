using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    Animator _animator;

    [SerializeField]
    int move, idle;

    private void Awake() {
        
        _animator = GetComponent<Animator>();
    }

    // 여기서 정하고? move랑 animation에 매개변수로 상세값을 정해서 넘겨주는 형식

    // move와 animation는 반환 타입을 bool로 만들어서 해당 행위가 끝났는지 & 우선 입력이 들어왔는지 확인

    private void Update() {
        
        if (Input.GetKeyDown(KeyCode.Space)) {

            Debug.Log("우선 키 입력");


        }
    }

    private void Brain() {

        
    }

    private bool Move(Vector2 _dir, float _during) {


        return true;
    }

    private bool Animation(string _animType, float _during) {


        return true;
    }
}
