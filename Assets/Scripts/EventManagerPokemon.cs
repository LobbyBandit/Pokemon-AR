using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManagerPokemon : MonoBehaviour
{

    float timer;
    public GameObject Pokemon;
    public GameObject Canvas;
    public AudioSource PokeballOpen;
    public AudioSource PokemonShow;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0; 
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

        if (timer >= 2.8f)
        {
            Pokemon.SetActive(true);
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
