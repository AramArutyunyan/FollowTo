using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTo : MonoBehaviour
{
    [SerializeField] private Transform _FollowTo;

    private void FixedUpdate()
    {
        gameObject.transform.position = new Vector3(_FollowTo.position.x, _FollowTo.position.y, gameObject.transform.position.z);
    }
}
