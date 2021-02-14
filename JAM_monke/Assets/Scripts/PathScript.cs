using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PathScript : MonoBehaviour
{
    public Color lineColor;
    private List<Transform> nodes = new List<Transform>();

    //TO make the path visible in the editor
    public void OnDrawGizmos()
    {
        //Set color for editor
        Gizmos.color = lineColor;
        

        Transform[] pathTransforms = GetComponentsInChildren<Transform>();
        nodes = new List<Transform>();

        for (int i = 0; i < pathTransforms.Length; i++) {
            if (pathTransforms[i] != transform) {
                nodes.Add(pathTransforms[i]);
            }
        }

        for (int i = 0; i < nodes.Count; i++) {
            Vector3 currentNode = nodes[i].position;
            Vector3 previousNode = Vector3.zero;

            if (i > 0) {
                previousNode = nodes[i - 1].position;
            } else if (i == 0 && nodes.Count > 1) {
                previousNode = nodes[nodes.Count - 1].position;
            }

            Gizmos.DrawLine(previousNode, currentNode);
        }
        // //Get all nodes
        // var pathTransforms = GetComponentsInChildren<Transform>();
        
        // //All nodes that are not the top node

        // nodes = pathTransforms.Where(x => x != transform).ToList();

        // //Draw line between every node
        // for (var i = 0; i < nodes.Count; i++)
        // {
        //     var currentNode = nodes[i].position;
        //     var nextNode = Vector3.zero;

        //     //Exist multiple nodes
        //     if (nodes.Count <= 1) continue;
           
        //     //if we hit the last one
        //     if (i + 1 > nodes.Count - 1)
        //         nextNode = nodes[0].position;
        //     if (i + 1 <= nodes.Count - 1)
        //         nextNode = nodes[i + 1].position;

        //     Gizmos.DrawLine(currentNode, nextNode);
        // }
    }
}
