﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitScreen : MonoBehaviour {
	public Camera cam1;
	public Camera cam2;

	public bool horizon = false;

    // Update is called once per frame
    void Update(){
    	if(Input.GetKeyDown(KeyCode.Space)){
    		ChangeSplitScreen();
    	}
        
    }

    public void ChangeSplitScreen() {
    	horizon = !horizon;
    	if (horizon){
    		cam1.rect = new Rect(0,0,1,0.5f);
    		cam2.rect = new Rect(0,0.5f,1,0.5f);
    	}else{
    		cam1.rect = new Rect(0,0,0.5f,1);
    		cam2.rect = new Rect(0.5f,0,0.5f,1);
    	}

    }
}
