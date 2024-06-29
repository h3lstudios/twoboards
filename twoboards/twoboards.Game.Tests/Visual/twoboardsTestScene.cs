using osu.Framework.Testing;

namespace twoboards.Game.Tests.Visual
{
    public abstract partial class twoboardsTestScene : TestScene
    {
        protected override ITestSceneTestRunner CreateRunner() => new twoboardsTestSceneTestRunner();

        private partial class twoboardsTestSceneTestRunner : twoboardsGameBase, ITestSceneTestRunner
        {
            private TestSceneTestRunner.TestRunner runner;

            protected override void LoadAsyncComplete()
            {
                base.LoadAsyncComplete();
                Add(runner = new TestSceneTestRunner.TestRunner());
            }

            public void RunTestBlocking(TestScene test) => runner.RunTestBlocking(test);
        }
    }
}
