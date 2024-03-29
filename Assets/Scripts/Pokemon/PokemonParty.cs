using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PokemonParty : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] List<Pokemon> pokemons;


   public List<Pokemon> Pokemons{
    get { return pokemons;}
   }
   private void Start() {
        foreach (var pokemon in pokemons)
        {
           pokemon.Init(); 
        }
   }
    public Pokemon GetHealthyPokemon(){
        return pokemons.Where(x => x.Hp > 0).FirstOrDefault();
    }

}
