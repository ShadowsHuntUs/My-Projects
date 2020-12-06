/*1.	Show all of the details about first generation Pokémon that have a 100% male ratio.*/
		Select * From pokemon
		Where pokemonMaleRatio = 100 And pokemonIsFirstGen = 1

/*2.	How many Pokémon have ‘eo’ in their name?*/
		Select COUNT(*) as 'Number of Pokemon with eo in their name' 
		From pokemon
		Where pokemonName Like '%eo%'


/*3.	What is the average female ratio of Pokémon that have Pokédex values ranging from 001 – 199?*/
		Select AVG(pokemonFemaleRatio) as 'Average of Female pokemon' 
		From pokemon
		Where pokemonDexNo between 001 and 199



/*4.	Show each Pokémon name formatted as follows: PokedexNo - Name (i.e. 236 - Tyrogue). Order the output by Pokémon name.*/
		Select CONCAT(pokemonDexNo, ' - ', pokemonName) As 'Pokemon Dex # and Name'
		From pokemon
		Order By pokemonName



/*5.	Show all of the details about the heaviest Pokemon in our database. NOTE: do not hard-code the weight value.*/
		Select  * From POKEMON
		Where  pokemonWeight = ( Select Max(pokemonWeight)From pokemon)


/*6.	Which Pokemon was caught on a Sunday?*/
		Select PokemonName As 'Pokemon Caught on Sunday'
		From pokemon
		Where DATEPART(DW, pokemonCaughtDate) = 3		

