using Newtonsoft.Json;
using PokeApiNet;
using System.Reflection;

namespace PokeFusionApp
{
    public partial class MainWindow : Form
    {
        const int numPoke = 1154;
        PokeDataRoot pokeDataRoot;
        PokeApiClient pokeClient;

        public MainWindow()
        {           
            pokeClient = new PokeApiClient();
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (FileStream s = File.Open("Data\\pokemon.json", FileMode.Open))
            using (StreamReader sr = new StreamReader(s))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                pokeDataRoot = serializer.Deserialize<PokeDataRoot>(reader);
            }
            pokemon1.DataSource = pokeDataRoot.pokemon.ToList();
            pokemon1.DisplayMember = "name";
            pokemon1.ValueMember = "name";
            pokemon2.DataSource = pokeDataRoot.pokemon.ToList();
            pokemon2.DisplayMember = "name";
            pokemon2.ValueMember = "name";
        }

        public string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;
            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);
            return str.ToUpper();
        }

        async Task<Pokemon[]> getAllPokeAsync()
        {            
            Pokemon[] pokemons = new Pokemon[numPoke];
            for (int i = 0; i < numPoke; i++)
            {
                Pokemon pokemon = await pokeClient.GetResourceAsync<Pokemon>(i);
                pokemons[i] = pokemon;
            }
            return pokemons;
        }

        private async void fuseThem_Click(object sender, EventArgs e)
        {
            Pokemon poke1 = await pokeClient.GetResourceAsync<Pokemon>(pokemon1.SelectedValue.ToString());
            Dictionary<string, int> fused = new Dictionary<string, int>();
            poke1pic.ImageLocation = poke1.Sprites.FrontDefault;
            poke1stats.Text = "";
            int BST1 = 0;
            foreach(PokemonStat stat in poke1.Stats)
            {
                poke1stats.Text += FirstLetterToUpper(stat.Stat.Name) + " : " + stat.BaseStat.ToString();
                poke1stats.Text += Environment.NewLine;
                BST1 += stat.BaseStat;
                fused[stat.Stat.Name] = stat.BaseStat;
            }
            poke1stats.Text += "BST : " + BST1.ToString();

            Pokemon poke2 = await pokeClient.GetResourceAsync<Pokemon>(pokemon2.SelectedValue.ToString());
            poke2pic.ImageLocation = poke2.Sprites.FrontDefault;
            poke2stats.Text = "";
            int BST2 = 0;
            foreach (PokemonStat stat in poke2.Stats)
            {
                poke2stats.Text += FirstLetterToUpper(stat.Stat.Name) + " : " + stat.BaseStat.ToString();
                poke2stats.Text += Environment.NewLine;
                BST2 += stat.BaseStat;
                fused[stat.Stat.Name] += stat.BaseStat;
            }
            poke2stats.Text += "BST : " + BST2.ToString();

            int BSTfuse = 0;
            fusedStats.Text = "";
            foreach(var stat in fused)
            {
                fusedStats.Text += FirstLetterToUpper(stat.Key) + " : " + (stat.Value / 2).ToString();
                fusedStats.Text += Environment.NewLine;
                BSTfuse += stat.Value / 2;
            }
            fusedStats.Text += "BST : " + BSTfuse.ToString();
        }

    }
}