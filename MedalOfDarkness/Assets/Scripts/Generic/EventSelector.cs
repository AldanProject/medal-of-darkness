﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventSelector : MonoBehaviour 
{
    /* Made by Aldan Project | 2018 */
    public int eventNumber;
    public Event eventOne;
    public EventTwo eventTwo;
    public EventThree eventThree;
    public EventFour eventFour;

    public void SendToEvent(int callEvent)
    {
        try
        {
            switch(eventNumber)
            {
                case 1:
                    break;
                case 2:
                    eventTwo.SetMessages(callEvent);
                    break;
                case 3:
                    eventThree.SetEvent(callEvent);
                    break;
                case 4:
                    eventFour.SetEvent(callEvent);
                    break;
            }
        }
        catch(NullReferenceException ex)
        {
            Debug.Log("Evento " + eventNumber + " no encontrado");
            Debug.Log("Error: " + ex.Message);
        }
    }
}