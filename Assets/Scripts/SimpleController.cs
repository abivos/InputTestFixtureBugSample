using UnityEngine;
using UnityEngine.InputSystem;

namespace Sample
{
	public class SimpleController : MonoBehaviour
	{
		private void OnMove(InputValue inputValue)
		{
			var vector2 = inputValue.Get<Vector2>();
			var cachedTransform = transform;
			var oldPosition = cachedTransform.position;
			var newPosition = new Vector3(oldPosition.x + vector2.x, oldPosition.y + vector2.y, oldPosition.z);
			cachedTransform.position = newPosition;
		}
	}
}
