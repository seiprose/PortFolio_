using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posion : MonoBehaviour, IItem
{
    [SerializeField]Transform player;
    public int healAmount = 10;

    void Start()
    {
        
    }
    public void Use()
    {
        player.GetComponent<PlayerHealth>().Heal(healAmount);
    }
}
