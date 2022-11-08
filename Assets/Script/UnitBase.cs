using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ClassType
{
    CT_SwordMan,
    CT_Archer,
    CT_Guarder,
    CT_Wizard,

}
public class UnitBase : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private ClassType classType;

    private Vector3 move;
    private void Update()
    {

        move.x = moveSpeed * Time.deltaTime;
        move.y = 0f;
        move.z = 0f;
        transform.Translate(move);
    }
}
