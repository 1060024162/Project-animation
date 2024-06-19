using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum AIState
{
    None,
    Idle,
    Patrol,
    PlayerSeen,
    PlayerNear

}
public class AIController : MonoBehaviour
{
    private AIState _state = AIState.None;
    private Animator _animator;
    public bool PlayerNear  = false;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckTransition();
        Behavior();
    }
    private void Behavior() 
    {
        switch (_state)
        {
            case AIState.None:
                break; 
            case AIState.Idle:
                break;
            case AIState.Patrol:
                break;
            case AIState.PlayerSeen:
                break;
            case AIState.PlayerNear: 
                break;
            default:
                break;
        }
    }

    public void CheckTransition() 
    { 
        switch ( _state) 
        {
            case AIState.None:
                break;
            case AIState.Idle:
                if (PlayerNear)
                {
                    _state = AIState.PlayerNear;
                    _animator.SetBool("PlayerNear", true);
                }
                break;
            case AIState.Patrol:
                if (PlayerNear)
                {
                    _state = AIState.PlayerNear;
                    _animator.SetBool("PlayerNear", true);
                }
                break;
            case AIState.PlayerSeen:
                if (PlayerNear) 
                {
                    _state = AIState.PlayerNear;
                    _animator.SetBool("PlayerNear", true);
                }
                break;
            case AIState.PlayerNear:

                if (!PlayerNear)
                { 
                    _state = AIState.Patrol;
                    _animator.SetBool("PlayerNear", false);
                }
                break;
            default:
                break;  
        }
    
    }
}
