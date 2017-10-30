using UnityEngine;

public class Weight : MonoBehaviour {

	public float distFromEnd;

	public void ConnectRopeEnd(Rigidbody2D endRB) {
		HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
		joint.autoConfigureConnectedAnchor = false;
		joint.connectedBody = endRB;
		joint.anchor = Vector2.zero;
		joint.connectedAnchor = new Vector2(0, -distFromEnd);
;	}
}
