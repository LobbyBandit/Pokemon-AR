using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManagerPokemon : MonoBehaviour
{

    float timer;
    public float GrowSpeed;
    public GameObject Pokemon;
    public GameObject Canvas;
    public AudioSource PokeballOpen;
    public AudioSource PokemonShow;
    public GameObject SpawnEffect;
    public GameObject FakePokemon;
    public float FakeMonDrag;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        FakePokemon.SetActive(false);
        SpawnEffect.SetActive(false);
        SpawnEffect.transform.localScale = new Vector3(0, 0, 0);
        FakePokemon.transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 1.1f)
        {
            if(PokeballOpen.isPlaying == false)
                PokeballOpen.Play();
        }

        if (timer >= 1.5f)
        {
            FakePokemon.SetActive(true);
            SpawnEffect.SetActive(true);
            if (SpawnEffect.transform.localScale.x <= 7.42f)
                SpawnEffect.transform.localScale += new Vector3(GrowSpeed, GrowSpeed, GrowSpeed) * Time.deltaTime;
            if(FakePokemon.transform.localScale.x <= 1)
                FakePokemon.transform.localScale += new Vector3(FakeMonDrag * (GrowSpeed / 7.42f), FakeMonDrag * (GrowSpeed / 7.42f), FakeMonDrag * (GrowSpeed / 7.42f)) * Time.deltaTime;
        }

        if (timer >= 2.8f)
        {
            Destroy(SpawnEffect, 0.5f);
            Pokemon.SetActive(true);
            Destroy(FakePokemon);
            Canvas.SetActive(true);
            if (PokemonShow.isPlaying == false)
                PokemonShow.Play();
            Destroy(PokemonShow, PokemonShow.clip.length);

        }

        if (timer >= 4)
        {
            Canvas.SetActive(true);
        }

        Destroy(gameObject, 5.9f);





        
    }
}
