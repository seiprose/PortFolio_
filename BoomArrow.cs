using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomArrow : MonoBehaviour, IItem
{
    [SerializeField]Transform player;
    
    public void Use()
    {
        player.GetComponent<PlayerAttack>().GetBoomArrow();
    }   
}
