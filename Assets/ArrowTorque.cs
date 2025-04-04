﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowTorque : MonoBehaviour {
    
    public Rigidbody Rigidbody;

    public float VelocityMult;
    public float AngularVelocityMult;

	void FixedUpdate () {

        Vector3 cross = Vector3.Cross(transform.forward, Rigidbody.linearVelocity.normalized);

        Rigidbody.AddTorque(cross * Rigidbody.linearVelocity.magnitude * VelocityMult);
        Rigidbody.AddTorque((-Rigidbody.angularVelocity + Vector3.Project(Rigidbody.angularVelocity, transform.forward)) * Rigidbody.linearVelocity.magnitude * AngularVelocityMult);

	}
}
