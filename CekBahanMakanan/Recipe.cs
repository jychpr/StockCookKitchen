using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace CekBahanMakanan
{
    class Recipe //class Recipe yang digunakan untuk menampung method pemanggilan API dari food2fork
    {
        //method GetRecipe yang digunakan untuk mendapatkan resep dari database online food2fork, menerima input berupa string food dan int rId
        //food untuk nama makanan yang dicari, dan rId untuk id resep yang didapat dari database food2fork
        public static string GetRecipe(string food,int rId)
        {
            var client = new RestClient("https://www.food2fork.com/"); //meminta ke client food2fork
            var request = new RestRequest($"api/search?key=eb7a48f8af7e7c4928f1042215b73a53&q={food}", Method.GET); //meminta request ke food2fok dengan API key
            IRestResponse response = client.Execute(request); //menjalankan atau execute request
            JsonObject obj = (JsonObject)SimpleJson.DeserializeObject(response.Content); //memecah hasil
            JsonArray recipes = (JsonArray)obj["recipes"];
            JsonObject rIdJson = (JsonObject)recipes[rId];
            string id = (string)rIdJson[4]; //mendapatkan hasil berupa id resep

            return id; //id yang dimaksud yaitu id dari resep yang didapat
        }

        //method GetIngredients yang digunakan untuk mendapatkan bahan bahan yang ada dari database food2fork
        //ketika sebuah menu telah dipilih dari GetRecipe, maka bahan bahannya akan diambil dengan method ini
        public static List<string> GetIngredients(string food,int rId)
        {
            string id = GetRecipe(food,rId);
            List<string> ingredientsList = new List<string>();
            var client = new RestClient("https://www.food2fork.com/"); //meminta ke client food2fork
            var request = new RestRequest($"api/get?key=eb7a48f8af7e7c4928f1042215b73a53&rId={id}", Method.GET); //meminta request ke food2fok dengan API key
            IRestResponse response = client.Execute(request); //menjalankan atau execute request
            JsonObject obj = (JsonObject)SimpleJson.DeserializeObject(response.Content); //memecah hasil
            JsonObject recipes = (JsonObject)obj["recipe"];
            JsonArray ingredients = (JsonArray)recipes["ingredients"]; //mendapatkan hasil berupa ingredients
            foreach(string ingredient in ingredients) //fungsi foreach untuk menuliskan setiap bahan yang ada di dalamnya
            {
                ingredientsList.Add("- " + ingredient); 
            }
            return ingredientsList; //ingredientList adalah bahan bahan yang didapat dari id resep yang didapat
        }

        //method GetTitle digunakan untuk mendapatkan judul dari resep makanan yang dipilih
        public static string GetTitle(string food,int rId)
        {
            var client = new RestClient("https://www.food2fork.com/"); //meminta ke client food2fork
            var request = new RestRequest($"api/search?key=eb7a48f8af7e7c4928f1042215b73a53&q={food}", Method.GET); //meminta request ke food2fok dengan API key
            IRestResponse response = client.Execute(request); //menjalankan atau execute request
            JsonObject obj = (JsonObject)SimpleJson.DeserializeObject(response.Content); //memecah hasil
            JsonArray recipes = (JsonArray)obj["recipes"];
            JsonObject rTitleJson = (JsonObject)recipes[rId];
            string title = (string)rTitleJson[2]; //mendapatkan hasil berupa title 

            return title; //title adalah judul resep yang didapat dari id resep yang didapat
        }

        //CATATAN : jika muncul messagebox yang mengatakan "Resep tidak ditemukan" semacamnya, maka pemanggilan API terkena limit
        //sehingga API key harus diganti secara manual dari source code, dan diganti semuanya
        //API key terletak setelah tulisan "key=" dan sebelum tanda "&" yang dilanjutkan dengan "q" atau "rId"
    }
}
