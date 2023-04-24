using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Sample.Tests.Tests
{
	public class CTestsRunAfter
	{
		[UnityTest]
		public IEnumerator TestC()
		{
			yield return LoadLevel();
		}

		private IEnumerator LoadLevel()
		{
			var asyncLoadLevel = SceneManager.LoadSceneAsync("SampleScene", LoadSceneMode.Single);
			while (!asyncLoadLevel.isDone)
				yield return null;
		}
	}
}