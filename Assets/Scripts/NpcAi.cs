﻿using UnityEngine;
using System.Collections;

public class NpcAi : MonoBehaviour {

    public Color color;

	// Use this for initialization
	void Start () {
        this.GetComponent<Renderer>().material.color = color;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}