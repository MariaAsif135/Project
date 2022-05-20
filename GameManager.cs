using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager {
    private static GameManager instance = new GameManager();
   
    // make sure the constructor is private, so it can only be instantiated here
    private GameManager() {
    }
 
    public static Instance {
        get { return instance; }
    }
}
 