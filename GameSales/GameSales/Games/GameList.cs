﻿namespace GameSales.Games
{
    public class GameList
    {
        //Creating a list to hold all the games and their information from the API
        public List<Game>? Games { get; set; }
    }
    //holding information for a game
    public class Game
    {
        public string? internalName { get; set; }
        public string? title { get; set; }
        public string? metacriticLink { get; set; }
        public string? dealID { get; set; }
        public string? storeID { get; set; }
        public string? gameID { get; set; }
        public string? salePrice { get; set; }
        public string? normalPrice {get; set; }
        public string? isOnSale { get; set; }
        public string? savings { get; set;}
        public string? metacriticScore { get; set; }
        public string? steamRatingText { get; set; }
        public string? steamRatingPercent { get; set; }
        public string? steamRatingCount { get; set; }
        public string? steamAppID { get; set; }
        public int releaseDate { get; set; }
        public int lastChange { get; set; }
        public string? dealRating { get; set; }
        public string? thumb { get; set; }
    } 
}
