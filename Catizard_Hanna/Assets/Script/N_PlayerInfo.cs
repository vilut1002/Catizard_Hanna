﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N_PlayerInfo : MonoBehaviour
{
    
    public enum Card {block1 = 1, block2, block3, wild, provoke, scarecrow, catnip, SOS, removeBlock};
    public static int CardSum = 20;
    public static int[] CardNum = new int[9];
    public static int Gold = 500;
    public static bool UnLock = false;
    public static bool Chap1_clear = false;
    public static bool Chap2_clear = false;

}
