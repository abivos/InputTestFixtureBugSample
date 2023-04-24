using System.Collections;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Sample.Tests.Tests
{
	public class BInputTests : InputTestFixture
	{
		[UnityTest]
		public IEnumerator TestB()
		{
			yield return LoadLevel();

			var keyboard = InputSystem.AddDevice<Keyboard>();

			Press(keyboard[Key.D]);

			InputSystem.RemoveDevice(keyboard);
		}

		private IEnumerator LoadLevel()
		{
			var asyncLoadLevel = SceneManager.LoadSceneAsync("SampleScene", LoadSceneMode.Single);
			while (!asyncLoadLevel.isDone)
				yield return null;
		}
	}
}