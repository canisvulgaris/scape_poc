﻿using UnityEngine;
using System.Collections;

public class TerrainObject {

	private GameObject objRef;
	private float objX = 1;
	private float objY = 1;
	private float objZ = 1;
	private float objSize;
	private Vector3 objPosition;
	private Material objMat;

	public TerrainObject(GameObject type, Vector3 pos, float size, GameObject parent) {
		objPosition = pos;
		objSize = size;

        objRef = GameObject.Instantiate(type, pos, type.transform.rotation) as GameObject;        
        objRef.transform.localScale = new Vector3(objX * size, objY * size, objZ * size);
        objRef.transform.parent = parent.transform;

        objMat = new Material (Shader.Find("Standard"));
        objMat.color = new Color(0, 0.5F + (Random.value/2), 0);

        objRef.GetComponent<Renderer> ().material = objMat;
	}

	public void setColor(Color color) {
        objMat.color = color;
	}

	public void setEnabled(bool set) {
        objRef.SetActive (set);
	}

	public bool IsVisible {
		get {
			return objRef.activeSelf;
		}
	}

	public float ObjectSize {
		get {
			return objSize;
		}
	}

	public Vector3 ObjectPosition {
		get {
			return objPosition;
		}
		set {
			objPosition = value;
            objRef.transform.position = value;
		}
	}
}
