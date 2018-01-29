using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.SceneManagement;

public class CubeTest {
    
    /// <summary>
    /// [SetUp]
    /// 各テストが呼ばれる前に毎回呼ばれる
    /// </summary>
    [SetUp]
    public void Init()
    {
        SceneManager.LoadScene("Main");
    }

    [UnityTest]
    public IEnumerator OnCubeHellコールバックが呼ばれるか()
    {
        yield return new MonoBehaviourTest<OnCubeHellCallBackTest>();
    }
}

class OnCubeHellCallBackTest : MonoBehaviour, IMonoBehaviourTest
{
    /// <summary>
    /// Trueにすると呼び出し元のyieldに戻る(テスト完了となる)
    /// </summary>
    public bool IsTestFinished { get; private set; }

    void Start()
    {
        CubeManager.OnCubeHell.AddListener(OnCubeHellCallback);
    }

    void OnCubeHellCallback()
    {
        IsTestFinished = true;
    }
}
