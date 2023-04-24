using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Sample.Tests.Tests
{
    public class ATestsRunBefore
    {
        [UnityTest]
        public IEnumerator TestA()
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
