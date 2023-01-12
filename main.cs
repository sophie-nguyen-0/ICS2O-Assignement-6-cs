// Created by: sophie
// Created on: oct 2020
//
// This program gives random anime quotes

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;

class Program
{
    public static async Task Main()
    {
        HttpClient client = new HttpClient();
        string response = await client.GetStringAsync(
            "https://animechan.vercel.app/api/random"
        );
        // Console.WriteLine(response);
        var jsonAsDictionary = System.Text.Json.JsonSerializer.Deserialize<Object>(response);
        // Console.WriteLine(jsonAsDictionary);
        Console.WriteLine("");
        JsonNode animequote = JsonNode.Parse(response)!;
        // Console.WriteLine(animequote);
        JsonNode anime = animequote!["anime"]!;
        JsonNode character = animequote!["character"]!;
        JsonNode quote = animequote!["quote"]!;

        Console.WriteLine("anime: " + anime);
        Console.WriteLine(" ' " + quote + " '");
        Console.WriteLine("- " + character);
    }
}