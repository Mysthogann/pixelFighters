﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class MedievalKing : CharacterScript
{
    [Header("Movement")]
    [SerializeField] float speed = 1.5f;
    [SerializeField] float jumpForce = 3.5f;

    [Header("Audio")]
    [SerializeField] AudioClip swordAttack;
    [SerializeField] AudioClip swordAttackEnemy;
    [SerializeField] AudioClip swordAttackTwo;
    [SerializeField] AudioClip swordAttackEnemyTwo;
    [SerializeField] public bool isPlayerOne = false;

    [Header("Attack")]
    [SerializeField] public float damageMultiplier = 1.2f;

    void Start()
    {
        Starter(speed, jumpForce, swordAttack, swordAttackEnemy, swordAttackTwo, swordAttackEnemyTwo, isPlayerOne, transform.name.Replace("(Clone)", ""));
    }

    void Update()
    {
        Updater();
    }
}