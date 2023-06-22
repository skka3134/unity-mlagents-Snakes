using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;

public class move : Agent
{
    public Transform target;
    Rigidbody rb;
    float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 10.0f;
    }


    public override void Heuristic(in ActionBuffers actionsOut)
    {
        ActionSegment<float> continuousActions = actionsOut.ContinuousActions;
        continuousActions[0] = Input.GetAxis("Horizontal");
        continuousActions[1] = Input.GetAxis("Horizontal");
    }
    public override void OnActionReceived(ActionBuffers actions)
    {
        Vector3 control = Vector3.zero;
        control.x = actions.ContinuousActions[0];
        control.z = actions.ContinuousActions[1];
        this.rb.AddForce(control * speed);
        float distance = Vector3.Distance(this.transform.position, target.transform.position);
        if (distance < 1.5f)
        {
            SetReward(1.0f);
            EndEpisode();
        }
        if (this.transform.position.y < 0)
        {
            EndEpisode();
        }
    }
    public override void OnEpisodeBegin()
    {
        target.transform.position = new Vector3(Random.value * 8 - 4, 0.5f, Random.value * 8 - 4);
        if (this.transform.position.y < 0)
        {
            this.transform.position = new Vector3(0, 0.5f, 0);
            this.rb.velocity = Vector3.zero;
            this.rb.angularVelocity = Vector3.zero;
        }
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(target.transform.position);
        sensor.AddObservation(this.transform.position);
        sensor.AddObservation(this.rb.velocity.x);
        sensor.AddObservation(this.rb.velocity.z);

    }


}
