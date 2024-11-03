using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{
    public AudioSource soundEffect; // 在Inspector中拖放音效文件
    public float defaultDelay = 2f; // 默认延迟时间

    public void PlaySoundAfterDelay(float delay)
    {
        StartCoroutine(PlaySoundCoroutine(delay));
    }

    private IEnumerator PlaySoundCoroutine(float delay)
    {
        yield return new WaitForSeconds(delay); // 等待特定时间
        if (soundEffect != null)
        {
            soundEffect.Play(); // 播放音效
        }
    }
}
