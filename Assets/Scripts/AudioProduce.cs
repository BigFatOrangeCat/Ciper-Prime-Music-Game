using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioProduce : MonoBehaviour
{

    public float Volume;
    public float Reward;
    public float DecreaseSpeed;
    public AudioSource AudioTrack;
    public Color Disable;
    public Color Enable;
    public SpriteRenderer bar1;
    public SpriteRenderer bar2;
    public SpriteRenderer bar3;
    void Update()
    {
        if (_active + _timealive < Time.time && AudioTrack.volume > Volume)
        {
            AudioTrack.volume -= 1f * Time.deltaTime; //音量随时间降低
        }
        if (AudioTrack.volume >= 0.3f)
        {
            bar1.color = Enable; //大于0.3，亮1
        }
        else
        {
            bar1.color = Disable;
        }

        if (AudioTrack.volume >= 0.6f)
        {
            bar2.color = Enable; //大于0.6，亮2
        }
        else
        {
            bar2.color = Disable;
        }
        if (AudioTrack.volume >= 0.9f)
        {
            bar3.color = Enable; //大于0.9，亮3
        }
        else
        {
            bar3.color = Disable;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (AudioTrack.volume < 1.0f)
        {
            AudioTrack.volume += 0.005f; //当检测到碰撞时，如果音量小于1，缓慢增加
            _active = Time.time;

        }
    }
    private float _timealive = 2f;
    private float _active = 0f;
}
