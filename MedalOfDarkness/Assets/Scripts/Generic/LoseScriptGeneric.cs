﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScriptGeneric : MonoBehaviour 
{
    /* Made by Aldan Project | 2018 */
    public Transform m_Katherine;
    public Transform m_NewPosition;
    public float m_WaitTime;
    public EventSelector m_Event;
    public int m_CallEvent;
    public bool m_UnlockMovement = true;

    private float m_Count = 0.0f;

    public void ReturnCharacter()
    {
        m_Katherine.position = m_NewPosition.position;
        m_Katherine.rotation = m_NewPosition.rotation;
        while (m_Count < m_WaitTime)
        {
            m_Count += Time.deltaTime;
        }
        this.GetComponent<Animator>().SetBool("isActive", false);
        if (m_UnlockMovement)
        {
            m_Katherine.GetComponent<PlayerController>().m_CanMove = true;
        }
        m_Event.SendToEvent(m_CallEvent);
    }
}
