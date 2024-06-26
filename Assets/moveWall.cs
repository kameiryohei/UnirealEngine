using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWall : MonoBehaviour
{
   Transform myTransform; // •¨‘Ì‚Ì transform î•ñ‚ğŠi”[‚·‚é•Ï”
Vector3 origin = new Vector3(0f, 1f, -3f); // ‰ñ“]’†S
Vector3 axis = new Vector3(0f, 1f, 0f); // ‰ñ“]²(Y ²)
// Start is called before the first frame update
void Start()
{
myTransform = this.transform; // transform î•ñ‚ğæ“¾
}
// Update is called once per frame
void Update()
{
myTransform.RotateAround(origin, axis, 5f); // origin ‚ğ’†S‚É axis ü‚è‚É5“x‰ñ“]‚·‚é
}
}
